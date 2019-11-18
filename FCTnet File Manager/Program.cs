using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCTnet_File_Manager
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			clsSettings S = new clsSettings();
			bool silent = false;
			//bool recursive = false;
			//bool archive = false;
			foreach (var s in Environment.GetCommandLineArgs())
			{
				Console.WriteLine(s);

				var arg = s.ToLower().TrimStart('/');
				if (arg == "z") { silent = true; }
				else if (arg == "r") { S.recursive = true; }
				else if (arg == "a") { S.archive = true; }
				else if (arg == "d") { int i; S.archiveLength = int.TryParse(arg, out i) ? i : -1; }
				else if (arg.StartsWith("p1") || arg.StartsWith("s") || arg.StartsWith("source"))
				{
					var start = arg.IndexOf("=");
					if (start > 0) { S.pathSource = arg.Substring(start + 1, arg.Length - start - 1); }
				}
				else if (arg.StartsWith("p2") || arg.StartsWith("d") || arg.StartsWith("dest") || arg.StartsWith("destination"))
				{
					var start = arg.IndexOf("=");
					if (start > 0) { S.pathDest = arg.Substring(start + 1, arg.Length - start - 1); }
				}
				else if (arg.StartsWith("p3") || arg.StartsWith("l") || arg.StartsWith("log"))
				{
					var start = arg.IndexOf("=");
					if (start > 0) { S.pathLog = arg.Substring(start + 1, arg.Length - start - 1); }
				}
			}
			if (silent)
			{ // silent run, don't show form
				S.CopyFilesAsync(S.pathSource, S.pathDest);
				return;
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var frm = new frmMain(S);
			Application.Run(frm);
		}
	}
}
