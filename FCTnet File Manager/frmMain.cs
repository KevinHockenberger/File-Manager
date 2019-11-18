using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCTnet_File_Manager
{
	public partial class frmMain : Form
	{
		delegate TreeNode delegateAddNodeByString(TreeNode n, string t, int image);
		delegate TreeNode delegateAddNode(TreeNode n, TreeNode t);

    private int archiveLength; // in days

		public int ArchiveLength
		{
			get { return archiveLength; }
			set { archiveLength = value; nudArchive.Value = value; }
		}

		public string Status
		{
			get { return tslblStatus.Text; }
			set { tslblStatus.Text = value + (string.IsNullOrEmpty(FileProcessingStatus) ? "" : string.Format(" || {0}", FileProcessingStatus)); }
		}
		string logFileSpec;
		public string LogFileSpec
		{
			get { return logFileSpec; }
			set
			{
				//validate filename
				logFileSpec = value;
				txtLog.Text = value;
			}
		}
		public int Progress
		{
			get { return progressbar.Value; }
			set
			{
				value = Math.Max(progressbar.Minimum, value);
				value = Math.Min(progressbar.Maximum, value);
				progressbar.Value = value;
				lblProgress.Text = value.ToString() + " %";
			}
		}
		public int totalFolderCount
		{
			get { return folders; }
			set
			{
				folders = value;
				if (InvokeRequired)
				{
					Invoke(new Action(() => { totalFolderCount = value; }));
				}
				else
				{
					lblFolders.Text = value.ToString("N0");
				}
			}
		}
		public int totalFileCount
		{
			get { return files; }
			set
			{
				files = value;
				if (InvokeRequired)
				{
					Invoke(new Action(() => { totalFileCount = value; }));
				}
				else
				{
					lblFiles.Text = value.ToString("N0");
				}
			}
		}
		public long totalFileSize
		{
			get { return size; }
			set
			{
				size = value;
				if (InvokeRequired)
				{
					Invoke(new Action(() => { totalFileSize = value; }));
				}
				else
				{
					lblSize.Text = value.ToString("N0");
				}
			}
		}
		public int totalFileCountPreview
		{
			get { return totalCount; }
			set
			{
				totalCount = value;
				if (InvokeRequired)
				{
					Invoke(new Action(() => { totalFileCountPreview = value; }));
				}
				else
				{
					lblTotalFiles.Text = "total # of files: " + (value <= 0 ? "unknown" : value.ToString("N0"));
				}
			}
		}
    public string FileProcessingStatus { get; set; }

    public TreeNode AddTreeNodeSource(TreeNode n, string t, int image)
		{
			if (InvokeRequired)
			{
				return (TreeNode)Invoke(new delegateAddNodeByString(AddTreeNodeSource), n, t, image);
			}
			else
			{
				TreeNode ret = null;
				if (n == null)
				{
					ret = treeSource.Nodes.Add(t);
				}
				else
				{
					ret = n.Nodes.Add(Path.GetFileName(t));
				}
				ret.Tag = new dirInfo() { path = t };
				ret.ImageIndex = ret.SelectedImageIndex = image;
				return ret;
			}
		}
		public void AddTreeNodeToNode(TreeNode SourceNode, TreeNode DestNode)
		{
			if (InvokeRequired)
			{
				Invoke(new Action(() => AddTreeNodeToNode(SourceNode, DestNode)));
			}
			else
			{
				SourceNode.Nodes.Add(DestNode);
			}
		}
		public TreeNode AddTreeNodeDest(TreeNode n, string t, int image)
		{
			if (InvokeRequired)
			{
				return (TreeNode)Invoke(new delegateAddNodeByString(AddTreeNodeDest), n, t, image);
			}
			else
			{
				TreeNode ret = null;
				if (n == null)
				{
					ret = treeDest.Nodes.Add(t);
				}
				else
				{
					ret = n.Nodes.Add(Path.GetFileName(t));
				}
				ret.Tag = new dirInfo() { path = t };
				ret.ImageIndex = ret.SelectedImageIndex = image;
				return ret;
			}
		}

		CancellationTokenSource cts;
		private int folders;
		private int files;
		private int totalCount;
		private long size;
		DateTime? start = null;
		//DateTime? stop = null;
		public frmMain(clsSettings settings)
		{
			InitializeComponent();
			txtSource.Text = settings.pathSource ?? txtSource.Text;
			txtDest.Text = settings.pathDest ?? txtDest.Text;
			LogFileSpec = settings.pathLog ?? txtLog.Text;
			ArchiveLength = settings.archiveLength > 0 ? settings.archiveLength : 730;
			chkRecursive.Checked = settings.recursive?? chkRecursive.Checked;
			chkArchive.Checked = settings.archive?? chkArchive.Checked;
		}

		private async void btnScan_Click(object sender, EventArgs e)
		{
			if (cts != null)
			{
				Status = "task cancelling...";
				cts.Cancel();
				return;
			}
			btnStart.Enabled = false;
			btnScan.Text = "cancel";
			tslblStatus.Text = string.Empty;
			tlpPreview.Visible = true;
			this.Height = Math.Max(this.Height, 350);

			treeSource.Nodes.Clear();
			totalFolderCount = 0;
			totalFileCount = 0;
			totalFileSize = 0;
			totalFileCountPreview = 0;
			cts = new CancellationTokenSource();
			start = DateTime.Now;
			Progress = 0;
			System.Windows.Forms.Timer t = new System.Windows.Forms.Timer() { Interval = 1000, Enabled = true };
			t.Tick += new EventHandler(tmr_Tick);
			t.Start();
			try
			{
				if (Directory.Exists(txtSource.Text))
				{
					Task<int> task1 = Task<int>.Run(() => Directory.GetFiles(txtSource.Text, "*", SearchOption.AllDirectories).Length);
					task1.ContinueWith(t1 => { totalCount = t1.Result; totalFileCountPreview = t1.Result; });
				}
				//totalCount = Directory.GetFiles(txtSource.Text,"*", SearchOption.AllDirectories).Length);
			}
			catch (Exception)
			{
			}
			try
			{
				//int contentLength = await PreviewFilesAsync(txtSource.Text, null, 0, cts.Token); // this will block without adding a task.delay
				await Task.Run(() => PreviewFilesAsync(txtSource.Text, null, chkRecursive.Checked, cts.Token));

				t.Stop();
				Status = "task complete. " + (DateTime.Now.Subtract(start.Value)).ToString(@"hh\:mm\:ss");
				Progress = 100;
			}
			// *** If cancellation is requested, an OperationCanceledException results.  
			catch (OperationCanceledException)
			{
				t.Stop();
				Status = "task canceled. " + (DateTime.Now.Subtract(start.Value)).ToString(@"hh\:mm\:ss");
			}
			catch (Exception)
			{
				t.Stop();
				Status = "task failed. " + (DateTime.Now.Subtract(start.Value)).ToString(@"hh\:mm\:ss");
			}
			// ***Set the CancellationTokenSource to null when the download is complete.  
			cts = null;
			btnScan.Text = "preview";
			btnStart.Enabled = true;
		}

		private void btnBrowseSource_Click(object sender, EventArgs e)
		{
			var f = new FolderBrowserDialog() { SelectedPath = txtSource.Text };
			f.ShowDialog();
			txtSource.Text = f.SelectedPath;
		}

		private void btnBrowseDest_Click(object sender, EventArgs e)
		{
			var f = new FolderBrowserDialog() { SelectedPath = txtDest.Text };
			f.ShowDialog();
			txtDest.Text = f.SelectedPath;
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(LogFileSpec))
			{
				LogFileSpec = AppDomain.CurrentDomain.BaseDirectory + "log.txt";// @"E:\Visual Studio\FCTnet File Manager\log.txt";
			}
			this.Height = this.MinimumSize.Height;
			tlpPreview.Visible = false;
		}

		private void tree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			try
			{
				if (((TreeNode)e.Node).Tag != null)
				{
					var tagData = ((dirInfo)((TreeNode)e.Node).Tag);
					lblNodeFolders.Text = tagData.folderCount.ToString("N0");
					lblNodeFiles.Text = tagData.fileCount.ToString("N0");
					lblNodeSize.Text = tagData.fileSize.ToString("N0");
					lblNodePath.Text = tagData.path;
					lblNodeModified.Text = tagData.lastMod.ToShortDateString();
				}
			}
			catch (Exception)
			{
			}
		}

		private void tmr_Tick(object sender, EventArgs e)
		{
			if (start != null)
			{
				Status = (DateTime.Now.Subtract(start.Value)).ToString(@"hh\:mm\:ss");
			}
			if (totalCount > 0)
			{
				Progress = (int)(((decimal)files / totalCount) * 100);
			}
		}

		private async void btnStart_Click(object sender, EventArgs e)
		{
			if (cts != null)
			{
				Status = "task cancelling...";
				cts.Cancel();
				return;
			}
			btnScan.Enabled = false;
			btnStart.Text = "cancel";
			tslblStatus.Text = string.Empty;
			tlpPreview.Visible = true;
			this.Height = Math.Max(this.Height, 350);

			treeSource.Nodes.Clear();
			treeDest.Nodes.Clear();
			totalFolderCount = 0;
			totalFileCount = 0;
			totalFileSize = 0;
			totalFileCountPreview = 0;
			cts = new CancellationTokenSource();
			start = DateTime.Now;
			Progress = 0;
			System.Windows.Forms.Timer t = new System.Windows.Forms.Timer() { Interval = 1000, Enabled = true };
			t.Tick += new EventHandler(tmr_Tick);
			t.Start();
			File.Delete(LogFileSpec);

			try
			{
				//totalCount = Directory.GetFiles(txtSource.Text,"*", SearchOption.AllDirectories).Length);
				Task<int> task1 = Task<int>.Run(() => Directory.GetFiles(txtSource.Text, "*", SearchOption.AllDirectories).Length);
				task1.ContinueWith(t1 => { totalCount = t1.Result; totalFileCountPreview = t1.Result; });
			}
			catch (Exception)
			{
			}
			try
			{
				//int contentLength = await PreviewFilesAsync(txtSource.Text, null, 0, cts.Token); // this will block without adding a task.delay
				await Task.Run(() => CopyFilesAsync(txtSource.Text, txtDest.Text, null, null, chkRecursive.Checked, chkArchive.Checked, chkDeleteSource.Checked, cts.Token));

				t.Stop();
				Status = "task complete. " + (DateTime.Now.Subtract(start.Value)).ToString(@"hh\:mm\:ss");
				Progress = 100;
			}
			// *** If cancellation is requested, an OperationCanceledException results.  
			catch (OperationCanceledException)
			{
				t.Stop();
				Status = "task canceled. " + (DateTime.Now.Subtract(start.Value)).ToString(@"hh\:mm\:ss");
			}
			catch (Exception)
			{
				t.Stop();
				Status = "task failed. " + (DateTime.Now.Subtract(start.Value)).ToString(@"hh\:mm\:ss");
			}
			cts = null;
			btnStart.Text = "Start Copy";
			btnScan.Enabled = true;
		}

		private void btnBrowseLog_Click(object sender, EventArgs e)
		{
			var f = new SaveFileDialog() { InitialDirectory = Path.GetDirectoryName(txtLog.Text), DefaultExt = " txt", Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*" };
			f.ShowDialog();
			LogFileSpec = f.FileName;
		}

		private void txtLog_TextChanged(object sender, EventArgs e)
		{
			LogFileSpec = txtLog.Text;
		}

		async Task PreviewFilesAsync(string directory, TreeNode n, bool recursive, CancellationToken ct)
		{
			if (ct.IsCancellationRequested)
			{
				return;
			}
			if (Directory.Exists(directory))
			{
				folders++;
				totalFolderCount = folders;
				n = AddTreeNodeSource(n, directory, 0);
				if (recursive)
				{
					foreach (var item in Directory.GetDirectories(directory))
					{
						((dirInfo)n.Tag).folderCount++;
						try
						{
							await PreviewFilesAsync(item, n, recursive, ct);
							//await Task.Delay(0, ct);
						}
						catch (Exception)
						{
						}
					}
				}
				foreach (var item in Directory.GetFiles(directory))
				{
					if (ct.IsCancellationRequested)
					{
						return;
					}
					files++;
					totalFileCount = files;
					var fi = new FileInfo(item);
					//fi.Refresh();
					var fileSize = fi.Length;
					((dirInfo)n.Tag).lastMod = fi.LastWriteTimeUtc > ((dirInfo)n.Tag).lastMod ? fi.LastWriteTimeUtc : ((dirInfo)n.Tag).lastMod;
					((dirInfo)n.Tag).lastMod = fi.CreationTimeUtc > ((dirInfo)n.Tag).lastMod ? fi.CreationTimeUtc : ((dirInfo)n.Tag).lastMod;
					size += fileSize;
					totalFileSize = size;
					((dirInfo)n.Tag).fileCount++;
					((dirInfo)n.Tag).fileSize += fileSize;
					TreeNode n1 = new TreeNode(Path.GetFileName(item)) { Tag = new dirInfo() { path = item, fileSize = fileSize } };
					((dirInfo)n1.Tag).lastMod = fi.LastWriteTimeUtc > fi.CreationTimeUtc ? fi.LastWriteTimeUtc : fi.CreationTimeUtc;
					n1.ImageIndex = 1;
					AddTreeNodeToNode(n, n1);
					//await Task.Delay(0, ct);
				}
			}
		}

		async Task CopyFilesAsync(string source, string dest, TreeNode nS, TreeNode nD, bool recursive, bool archive, bool deleteSource, CancellationToken ct)
		{
			if (ct.IsCancellationRequested)
			{
				return;
			}
			if (Directory.Exists(source))
			{
				if (!Directory.Exists(dest))
				{
					try
					{
						Directory.CreateDirectory(dest);
						nD = AddTreeNodeDest(nD, dest + " ... success", 2);
					}
					catch (Exception)
					{
						nD = AddTreeNodeDest(nD, dest + " ... failed",1);
					}
				}
				else { nD = AddTreeNodeDest(nD, dest + " ... existing",0); }

				folders++;
				totalFolderCount = folders;
				nS = AddTreeNodeSource(nS, source,0);
				if (recursive)
				{
					foreach (var item in Directory.GetDirectories(source))
					{
						((dirInfo)nS.Tag).folderCount++;
						try
						{
							await CopyFilesAsync(item, item.Replace(source, dest), nS, nD, recursive, archive, deleteSource, ct);
							//await Task.Delay(0, ct);
						}
						catch (Exception)
						{
						}
					}
				}
				foreach (var item in Directory.GetFiles(source))
				{
					if (ct.IsCancellationRequested)
					{
						return;
					}
					files++;
					totalFileCount = files;
					var fi = new FileInfo(item);
					//fi.Refresh();
					var fileSize = fi.Length;
					((dirInfo)nS.Tag).lastMod = fi.LastWriteTimeUtc > ((dirInfo)nS.Tag).lastMod ? fi.LastWriteTimeUtc : ((dirInfo)nS.Tag).lastMod;
					((dirInfo)nS.Tag).lastMod = fi.CreationTimeUtc > ((dirInfo)nS.Tag).lastMod ? fi.CreationTimeUtc : ((dirInfo)nS.Tag).lastMod;
					size += fileSize;
					totalFileSize = size;
					((dirInfo)nS.Tag).fileCount++;
					((dirInfo)nS.Tag).fileSize += fileSize;
					TreeNode n1 = new TreeNode(Path.GetFileName(item)) { Tag = new dirInfo() { path = item, fileSize = fileSize } };n1.ImageIndex = 1;
					((dirInfo)n1.Tag).lastMod = fi.LastWriteTimeUtc > fi.CreationTimeUtc ? fi.LastWriteTimeUtc : fi.CreationTimeUtc;
					AddTreeNodeToNode(nS, n1);
					var d = item.Replace(source, dest);
					FileProcessingStatus = d + " ... working";
					var filenameD = Path.GetFileName(d);
					TreeNode n2 = new TreeNode(filenameD + " ... working"); n2.ImageIndex = 1;
					string logEntry=null;
					if (archive)
					{
						if(DateTime.Today.Subtract(((dirInfo)n1.Tag).lastMod).Days>ArchiveLength)
						{
							if (!File.Exists(d))
							{
								try
								{
									File.Move(item, d);
									n2.Text = filenameD + " ... archive success"; n2.ImageIndex = 4;
									FileProcessingStatus = d + " ... archive success";
									logEntry = string.Format("{0} - archive Success - {1}", DateTime.Now, d);
								}
								catch (Exception ex)
								{
									n2.Text = filenameD + " ... archive failed"; n2.ImageIndex = 5;
									FileProcessingStatus = d + " ... archive failed";
									logEntry = string.Format("{0} - archive FAILED - {1}", DateTime.Now, item);
									logEntry += string.Format("\n{0}\n{1}", ex.HResult, ex.Message);
								}
							}
							else
							{
								try
								{
									File.Copy(item, d, true);
									n2.Text = filenameD + " ... archive success"; n2.ImageIndex = 4;
									FileProcessingStatus = d + " ... archive success";
									logEntry = string.Format("{0} - archive Success - {1}", DateTime.Now, d);
									File.Delete(item);
								}
								catch (Exception ex)
								{
									n2.Text = filenameD + " ... archive failed"; n2.ImageIndex = 5;
									FileProcessingStatus = d + " ... archive failed";
									logEntry = string.Format("{0} - archive FAILED - {1}", DateTime.Now, item);
									logEntry += string.Format("\n{0}\n{1}", ex.HResult, ex.Message);
								}
							}
						}
						else
						{
							n2.Text = filenameD + " ... archive not due"; n2.ImageIndex = 4;
							FileProcessingStatus = d + " ... archive not due";
							logEntry = string.Format("{0} - archive not due - {1}", DateTime.Now, d);
						}
					}
					else
					{
						if (!File.Exists(d))
						{
							try
							{
								File.Copy(item, d);
								//CopyFileWithProgress(item, d);
								n2.Text = filenameD + " ... success"; n2.ImageIndex = 4;
								FileProcessingStatus = d + " ... success";
								logEntry = string.Format("{0} - Success - {1}", DateTime.Now, item);
							}
							catch (Exception ex)
							{
								n2.Text = filenameD + " ... failed"; n2.ImageIndex = 5;
								FileProcessingStatus = d + " ... failed";
								logEntry = string.Format("{0} - FAILED - {1}", DateTime.Now, item);
								logEntry += string.Format("\n{0}\n{1}", ex.HResult, ex.Message);
							}
						}
						else
						{
							var dfi = new FileInfo(d);
							if (fi.LastWriteTimeUtc > dfi.LastWriteTimeUtc)
							{
								try
								{
									File.Copy(item, d, true);
									n2.Text = filenameD + " ... success"; n2.ImageIndex = 4;
									FileProcessingStatus = d + " ... success";
									logEntry = string.Format("{0} - Success - {1}", DateTime.Now, item);
								}
								catch (Exception ex)
								{
									n2.Text = filenameD + " ... overwrite failed"; n2.ImageIndex = 5;
									FileProcessingStatus = d + " ... overwrite failed";
									logEntry = string.Format("{0} - OVERWRITE FAILED - {1}", DateTime.Now, item);
									logEntry += string.Format("\n{0}\n{1}", ex.HResult, ex.Message);
								}
							}
							else
							{
								n2.Text = filenameD + " ... ignored"; n2.ImageIndex = 6;
								FileProcessingStatus = d + " ... ignored";
								logEntry = string.Format("{0} - File up to date, ignored - {1}", DateTime.Now, item);
							}
						}
					}
					AddTreeNodeToNode(nD, n2);
					if (LogFileSpec.Length > 0 && logEntry!=null)
					{
						try
						{
							using (StreamWriter sr = new StreamWriter(LogFileSpec, true))
							{
								sr.WriteLine(logEntry);
							}
						}
						catch (Exception)
						{
						}
					}
					//await Task.Delay(0, ct);
				}
			}
			FileProcessingStatus = "complete";
		}

		// this works but as it is async, it causes problems with the loop as it stands
		//public delegate void IntDelegate(int Int);

		////public event IntDelegate FileCopyProgress;
		//public void CopyFileWithProgress(string source, string destination)
		//{
		//	var webClient = new System.Net.WebClient();
		//	webClient.DownloadProgressChanged += DownloadProgress;
		//	webClient.DownloadFileAsync(new Uri(source), destination);
		//}

		//private void DownloadProgress(object sender, System.Net.DownloadProgressChangedEventArgs e)
		//{
		//	if (InvokeRequired) {
		//		Invoke(new Action(() => { DownloadProgress(sender, e); }));
		//		//Invoke(new Action(() => { totalFileCountPreview = value; }));
		//	}
		//	else
		//	{
		//		lblFileProgress.Text = e.ProgressPercentage.ToString("N2");
		//	}
		//}


		private void nudArchive_ValueChanged(object sender, EventArgs e)
		{
			ArchiveLength = (int)nudArchive.Value;
		}

		private void lblHelp_Click(object sender, EventArgs e)
		{
			pnlHelp.Visible = !pnlHelp.Visible;
		}

    private void btnMore_Click(object sender, EventArgs e)
    {
      var f = new frmMore();
      f.ShowDialog();
    }
  }
  class dirInfo
	{
		public string path { get; set; }
		public int folderCount { get; set; }
		public int fileCount { get; set; }
		public long fileSize { get; set; }
		public DateTime lastMod { get; set; }
	}

}
