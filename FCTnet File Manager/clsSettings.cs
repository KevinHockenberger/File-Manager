using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.IO;

namespace FCTnet_File_Manager
{
	public class clsSettings
	{
		public string pathSource { get; set; }
		public string pathDest { get; set; }
		public string pathLog { get; set; }
		public bool? recursive { get; set; }
		public bool? archive { get; set; }
		public int archiveLength { get; set; }

		public void CopyFilesAsync(string source, string dest) // source and dest used for recursive copy
		{
			if (Directory.Exists(source))
			{
				if (!Directory.Exists(dest))
				{
					try
					{
						Directory.CreateDirectory(dest);
					}
					catch (Exception)
					{
					}
				}
				else { }

				if (recursive==true)
				{
					foreach (var item in Directory.GetDirectories(source))
					{
						try
						{
							CopyFilesAsync(item, item.Replace(source, dest));
						}
						catch (Exception)
						{
						}
					}
				}
				foreach (var item in Directory.GetFiles(source))
				{
					var fi = new FileInfo(item);
					var d = item.Replace(source, dest);
					var filenameD = Path.GetFileName(d);
					string logEntry = null;
					if (archive==true)
					{
						if (DateTime.Today.Subtract(fi.LastWriteTimeUtc > fi.CreationTimeUtc ? fi.LastWriteTimeUtc : fi.CreationTimeUtc).Days > archiveLength)
						{
							if (!File.Exists(d))
							{
								try
								{
									File.Move(item, d);
									logEntry = string.Format("{0} - archive Success - {1}", DateTime.Now, d);
								}
								catch (Exception ex)
								{
									logEntry = string.Format("{0} - archive FAILED - {1}", DateTime.Now, item);
									logEntry += string.Format("\n{0}\n{1}", ex.HResult, ex.Message);
								}
							}
							else
							{
								try
								{
									File.Copy(item, d, true);
									logEntry = string.Format("{0} - archive Success - {1}", DateTime.Now, d);
									File.Delete(item);
								}
								catch (Exception ex)
								{
									logEntry = string.Format("{0} - archive FAILED - {1}", DateTime.Now, item);
									logEntry += string.Format("\n{0}\n{1}", ex.HResult, ex.Message);
								}
							}
						}
						else
						{
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
								logEntry = string.Format("{0} - Success - {1}", DateTime.Now, item);
							}
							catch (Exception ex)
							{
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
									logEntry = string.Format("{0} - Success - {1}", DateTime.Now, item);
								}
								catch (Exception ex)
								{
									logEntry = string.Format("{0} - OVERWRITE FAILED - {1}", DateTime.Now, item);
									logEntry += string.Format("\n{0}\n{1}", ex.HResult, ex.Message);
								}
							}
							else
							{
								logEntry = string.Format("{0} - File up to date, ignored - {1}", DateTime.Now, item);
							}
						}
					}
					if (pathLog.Length > 0 && logEntry != null)
					{
						try
						{
							using (StreamWriter sr = new StreamWriter(pathLog, true))
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
		}

	}
}
