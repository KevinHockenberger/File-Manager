using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FCTnet_File_Manager
{
  public partial class frmMore : Form
  {
    delegate TreeNode delegateAddNodeByString(TreeNode n, string t, int image);
    delegate TreeNode delegateAddNode(TreeNode n, TreeNode t);

    CancellationTokenSource cts;
    public string FileProcessingStatus { get; set; }
    private int folders;
    private int files;
    private int totalCount;
    private long size;
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

    DateTime? start = null;
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

    public string Status
    {
      get { return tslblStatus.Text; }
      set { tslblStatus.Text = value + (string.IsNullOrEmpty(FileProcessingStatus) ? "" : string.Format(" || {0}", FileProcessingStatus)); }
    }

    public frmMore()
    {
      InitializeComponent();
    }

    private void btnBrowseSource_Click(object sender, EventArgs e)
    {
      var f = new FolderBrowserDialog() { SelectedPath = txtSource.Text };
      f.ShowDialog();
      txtSource.Text = f.SelectedPath;
    }

    private async void btnEval_Click(object sender, EventArgs e)
    {
      if (cts != null)
      {
        Status = "task cancelling...";
        cts.Cancel();
        return;
      }
      btnExport.Visible = false;
      btnEval.Text = "cancel";
      tslblStatus.Text = string.Empty;
      tree.Nodes.Clear();
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
      btnEval.Text = "Evaluate";
      btnExport.Visible = true;
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
          ret = tree.Nodes.Add(t);
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
    private void tree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
      lblMinSize.Text = string.Empty;
      lblMaxSize.Text = string.Empty;
      lblAvgSize.Text = string.Empty;
      try
      {
        if (((TreeNode)e.Node).Tag != null)
        {
          var tagData = ((dirInfo)((TreeNode)e.Node).Tag);
          lblNodeFolders.Text = tagData.folderCount.ToString("N0");
          lblNodeFiles.Text = tagData.fileCount.ToString("N0");
          lblNodeSize.Text = string.Format("{0} ({1:N0})", FormatFileSize(tagData.fileSize), tagData.fileSize);
          lblNodePath.Text = tagData.path;
          lblNodeModified.Text = tagData.lastMod.ToShortDateString();
          List<decimal> vals = new List<decimal>();
          foreach (TreeNode node in e.Node.Nodes)
          {
            vals = appendStats(node, vals, chkRecursive.Checked);
          }
          var min = vals.Min();
          var max = vals.Max();
          var avg = vals.Average();
          lblMinSize.Text = string.Format("{0} ({1:N0})", FormatFileSize(min), min);
          lblMaxSize.Text = string.Format("{0} ({1:N0})", FormatFileSize(max), max);
          lblAvgSize.Text = string.Format("{0} ({1:N0})", FormatFileSize(avg), avg);
          lblSubFileCount.Text = vals.Count.ToString("N0");
        }
      }
      catch (Exception)
      {
      }
    }
    private List<decimal> appendStats(TreeNode node, List<decimal> vals, bool recursive)
    {
      try
      {
        var tagData = ((dirInfo)((TreeNode)node).Tag);
        if (recursive && (tagData.folderCount > 0 || tagData.fileCount > 0)) // is a folder with sub-folders
        {
          foreach (TreeNode sub in node.Nodes)
          {
            vals = appendStats(sub, vals, recursive);
          }
        }
        else if (tagData.fileCount == 0) // is a file (or empty folder)
        {
          if (tagData.fileSize > 0) { vals.Add(tagData.fileSize); }
        }
      }
      catch (Exception)
      {
      }



      //vals.Add(0);
      return vals;
    }

    private string FormatFileSize(decimal bytes)
    {
      
      /*
      549755813888 = .5 TB
      536870912 = .5 GB
      524288 = .5 MB
      512 = .5 KB
      */
      if (bytes > 549755813888)
      {
        return string.Format("{0:N2} TB",bytes / 1099511627776);
      }
      else if (bytes > 536870912)
      {
        return string.Format("{0:N2} GB",bytes / 1073741824);
      }
      else if (bytes > 524288)
      {
        return string.Format("{0:N2} MB",bytes / 1048576);
      }
      else if (bytes > 512)
      {
        return string.Format("{0:N2} KB",bytes / 1024);
      }
      else
      {
        return string.Format("{0:N0} B",bytes);
      }
    }

    private void btnExport_Click(object sender, EventArgs e)
    {
      SaveFileDialog fileDialog = new SaveFileDialog() { ValidateNames = true, InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), CreatePrompt=true,DefaultExt="csv",AddExtension=true,OverwritePrompt=true,Filter="comma seperated values (.csv)|*.csv|text file (.txt)|*.txt|all files|*.*" };
      if(fileDialog.ShowDialog()==DialogResult.OK)
      {
        using (StreamWriter sw = new StreamWriter(fileDialog.FileName, false))
        {
          sw.WriteLine("\"location\",\"Modified\",\"#folders\",\"# files\",\"raw size\",\"size\"");
          foreach (TreeNode node in tree.Nodes)
          {
            AppendExportFile(sw, node);
          }
        }
        MessageBox.Show("File saved.");
      }
    }

    private void AppendExportFile(StreamWriter sw, TreeNode node)
    {
      if (node.Nodes.Count>0)
      {
        foreach (TreeNode sub in node.Nodes)
        {
          AppendExportFile(sw, sub);
        }
      }
      else
      {
        try
        {
          var tagData = ((dirInfo)((TreeNode)node).Tag);
          sw.WriteLine("\"{0}\",\"{1:yyyy-MM-dd HH:mm}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\"", tagData.path, tagData.lastMod,tagData.folderCount,tagData.fileCount,tagData.fileSize, FormatFileSize(tagData.fileSize));
        }
        catch (Exception)
        {
        }
      }
    }

  }
}
