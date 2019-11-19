namespace FCTnet_File_Manager
{
	partial class frmMain
	{
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
      this.btnStart = new System.Windows.Forms.Button();
      this.txtSource = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtDest = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.btnBrowseSource = new System.Windows.Forms.Button();
      this.btnBrowseDest = new System.Windows.Forms.Button();
      this.btnScan = new System.Windows.Forms.Button();
      this.tlpPreview = new System.Windows.Forms.TableLayoutPanel();
      this.treeDest = new System.Windows.Forms.TreeView();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.panel1 = new System.Windows.Forms.Panel();
      this.label3 = new System.Windows.Forms.Label();
      this.lblFolders = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.lblFiles = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.lblSize = new System.Windows.Forms.Label();
      this.treeSource = new System.Windows.Forms.TreeView();
      this.panel2 = new System.Windows.Forms.Panel();
      this.lblNodeModified = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.lblNodePath = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.lblNodeSize = new System.Windows.Forms.Label();
      this.lblNodeFolders = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.lblNodeFiles = new System.Windows.Forms.Label();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.tslblStatus = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblTotalFiles = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblProgress = new System.Windows.Forms.ToolStripStatusLabel();
      this.progressbar = new System.Windows.Forms.ToolStripProgressBar();
      this.panel3 = new System.Windows.Forms.Panel();
      this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
      this.panel6 = new System.Windows.Forms.Panel();
      this.chkDeleteSource = new System.Windows.Forms.CheckBox();
      this.label13 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.nudArchive = new System.Windows.Forms.NumericUpDown();
      this.chkArchive = new System.Windows.Forms.CheckBox();
      this.chkRecursive = new System.Windows.Forms.CheckBox();
      this.panel5 = new System.Windows.Forms.Panel();
      this.txtLog = new System.Windows.Forms.TextBox();
      this.btnBrowseLog = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.panel4 = new System.Windows.Forms.Panel();
      this.lblHelp = new System.Windows.Forms.Label();
      this.btnMore = new System.Windows.Forms.Button();
      this.pnlHelp = new System.Windows.Forms.Panel();
      this.label19 = new System.Windows.Forms.Label();
      this.label20 = new System.Windows.Forms.Label();
      this.label21 = new System.Windows.Forms.Label();
      this.label18 = new System.Windows.Forms.Label();
      this.label17 = new System.Windows.Forms.Label();
      this.label16 = new System.Windows.Forms.Label();
      this.label15 = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.tlpPreview.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.panel3.SuspendLayout();
      this.tlpMain.SuspendLayout();
      this.panel6.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudArchive)).BeginInit();
      this.panel5.SuspendLayout();
      this.panel4.SuspendLayout();
      this.pnlHelp.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnStart
      // 
      this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnStart.Location = new System.Drawing.Point(673, 104);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(94, 24);
      this.btnStart.TabIndex = 0;
      this.btnStart.Text = "Start Copy";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // txtSource
      // 
      this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtSource.Location = new System.Drawing.Point(3, 4);
      this.txtSource.Name = "txtSource";
      this.txtSource.Size = new System.Drawing.Size(663, 20);
      this.txtSource.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(22, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(41, 35);
      this.label1.TabIndex = 2;
      this.label1.Text = "Source";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtDest
      // 
      this.txtDest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtDest.Location = new System.Drawing.Point(3, 3);
      this.txtDest.Name = "txtDest";
      this.txtDest.Size = new System.Drawing.Size(663, 20);
      this.txtDest.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 35);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(60, 33);
      this.label2.TabIndex = 4;
      this.label2.Text = "Destination";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // btnBrowseSource
      // 
      this.btnBrowseSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnBrowseSource.Location = new System.Drawing.Point(665, 3);
      this.btnBrowseSource.Name = "btnBrowseSource";
      this.btnBrowseSource.Size = new System.Drawing.Size(30, 22);
      this.btnBrowseSource.TabIndex = 5;
      this.btnBrowseSource.Text = "...";
      this.btnBrowseSource.UseVisualStyleBackColor = true;
      this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
      // 
      // btnBrowseDest
      // 
      this.btnBrowseDest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnBrowseDest.Location = new System.Drawing.Point(665, 2);
      this.btnBrowseDest.Name = "btnBrowseDest";
      this.btnBrowseDest.Size = new System.Drawing.Size(30, 22);
      this.btnBrowseDest.TabIndex = 6;
      this.btnBrowseDest.Text = "...";
      this.btnBrowseDest.UseVisualStyleBackColor = true;
      this.btnBrowseDest.Click += new System.EventHandler(this.btnBrowseDest_Click);
      // 
      // btnScan
      // 
      this.btnScan.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnScan.Location = new System.Drawing.Point(573, 104);
      this.btnScan.Name = "btnScan";
      this.btnScan.Size = new System.Drawing.Size(94, 24);
      this.btnScan.TabIndex = 0;
      this.btnScan.Text = "preview";
      this.btnScan.UseVisualStyleBackColor = true;
      this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
      // 
      // tlpPreview
      // 
      this.tlpPreview.ColumnCount = 2;
      this.tlpMain.SetColumnSpan(this.tlpPreview, 5);
      this.tlpPreview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tlpPreview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tlpPreview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpPreview.Controls.Add(this.treeDest, 1, 1);
      this.tlpPreview.Controls.Add(this.panel1, 0, 0);
      this.tlpPreview.Controls.Add(this.treeSource, 0, 1);
      this.tlpPreview.Controls.Add(this.panel2, 1, 0);
      this.tlpPreview.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlpPreview.Location = new System.Drawing.Point(3, 134);
      this.tlpPreview.Name = "tlpPreview";
      this.tlpPreview.RowCount = 2;
      this.tlpPreview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
      this.tlpPreview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tlpPreview.Size = new System.Drawing.Size(764, 288);
      this.tlpPreview.TabIndex = 14;
      // 
      // treeDest
      // 
      this.treeDest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.treeDest.ImageIndex = 0;
      this.treeDest.ImageList = this.imageList1;
      this.treeDest.Location = new System.Drawing.Point(385, 100);
      this.treeDest.Name = "treeDest";
      this.treeDest.SelectedImageIndex = 0;
      this.treeDest.Size = new System.Drawing.Size(376, 185);
      this.treeDest.TabIndex = 16;
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "Folder");
      this.imageList1.Images.SetKeyName(1, "document");
      this.imageList1.Images.SetKeyName(2, "CheckGreen");
      this.imageList1.Images.SetKeyName(3, "paper-check");
      this.imageList1.Images.SetKeyName(4, "paper-check");
      this.imageList1.Images.SetKeyName(5, "paper-error");
      this.imageList1.Images.SetKeyName(6, "paper-info");
      this.imageList1.Images.SetKeyName(7, "write");
      this.imageList1.Images.SetKeyName(8, "watch");
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.lblFolders);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.lblFiles);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.lblSize);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(376, 91);
      this.panel1.TabIndex = 14;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 3);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(44, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Folders:";
      // 
      // lblFolders
      // 
      this.lblFolders.AutoSize = true;
      this.lblFolders.Location = new System.Drawing.Point(53, 3);
      this.lblFolders.Name = "lblFolders";
      this.lblFolders.Size = new System.Drawing.Size(13, 13);
      this.lblFolders.TabIndex = 1;
      this.lblFolders.Text = "0";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(16, 22);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(31, 13);
      this.label4.TabIndex = 2;
      this.label4.Text = "Files:";
      // 
      // lblFiles
      // 
      this.lblFiles.AutoSize = true;
      this.lblFiles.Location = new System.Drawing.Point(53, 22);
      this.lblFiles.Name = "lblFiles";
      this.lblFiles.Size = new System.Drawing.Size(13, 13);
      this.lblFiles.TabIndex = 3;
      this.lblFiles.Text = "0";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(17, 41);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(30, 13);
      this.label5.TabIndex = 4;
      this.label5.Text = "Size:";
      // 
      // lblSize
      // 
      this.lblSize.AutoSize = true;
      this.lblSize.Location = new System.Drawing.Point(53, 41);
      this.lblSize.Name = "lblSize";
      this.lblSize.Size = new System.Drawing.Size(13, 13);
      this.lblSize.TabIndex = 5;
      this.lblSize.Text = "0";
      // 
      // treeSource
      // 
      this.treeSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.treeSource.ImageIndex = 0;
      this.treeSource.ImageList = this.imageList1;
      this.treeSource.Location = new System.Drawing.Point(3, 100);
      this.treeSource.Name = "treeSource";
      this.treeSource.SelectedImageIndex = 1;
      this.treeSource.Size = new System.Drawing.Size(376, 185);
      this.treeSource.TabIndex = 6;
      this.treeSource.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tree_NodeMouseClick);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.lblNodeModified);
      this.panel2.Controls.Add(this.label11);
      this.panel2.Controls.Add(this.lblNodePath);
      this.panel2.Controls.Add(this.label8);
      this.panel2.Controls.Add(this.label9);
      this.panel2.Controls.Add(this.lblNodeSize);
      this.panel2.Controls.Add(this.lblNodeFolders);
      this.panel2.Controls.Add(this.label7);
      this.panel2.Controls.Add(this.label10);
      this.panel2.Controls.Add(this.lblNodeFiles);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(385, 3);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(376, 91);
      this.panel2.TabIndex = 15;
      // 
      // lblNodeModified
      // 
      this.lblNodeModified.AutoSize = true;
      this.lblNodeModified.Location = new System.Drawing.Point(53, 75);
      this.lblNodeModified.Name = "lblNodeModified";
      this.lblNodeModified.Size = new System.Drawing.Size(13, 13);
      this.lblNodeModified.TabIndex = 16;
      this.lblNodeModified.Text = "0";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(17, 75);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(31, 13);
      this.label11.TabIndex = 15;
      this.label11.Text = "Mod:";
      // 
      // lblNodePath
      // 
      this.lblNodePath.AutoSize = true;
      this.lblNodePath.Location = new System.Drawing.Point(53, 3);
      this.lblNodePath.Name = "lblNodePath";
      this.lblNodePath.Size = new System.Drawing.Size(16, 13);
      this.lblNodePath.TabIndex = 14;
      this.lblNodePath.Text = "...";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(15, 3);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(32, 13);
      this.label8.TabIndex = 13;
      this.label8.Text = "Path:";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(3, 20);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(44, 13);
      this.label9.TabIndex = 7;
      this.label9.Text = "Folders:";
      // 
      // lblNodeSize
      // 
      this.lblNodeSize.AutoSize = true;
      this.lblNodeSize.Location = new System.Drawing.Point(53, 56);
      this.lblNodeSize.Name = "lblNodeSize";
      this.lblNodeSize.Size = new System.Drawing.Size(13, 13);
      this.lblNodeSize.TabIndex = 12;
      this.lblNodeSize.Text = "0";
      // 
      // lblNodeFolders
      // 
      this.lblNodeFolders.AutoSize = true;
      this.lblNodeFolders.Location = new System.Drawing.Point(53, 20);
      this.lblNodeFolders.Name = "lblNodeFolders";
      this.lblNodeFolders.Size = new System.Drawing.Size(13, 13);
      this.lblNodeFolders.TabIndex = 8;
      this.lblNodeFolders.Text = "0";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(17, 56);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(30, 13);
      this.label7.TabIndex = 11;
      this.label7.Text = "Size:";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(16, 38);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(31, 13);
      this.label10.TabIndex = 9;
      this.label10.Text = "Files:";
      // 
      // lblNodeFiles
      // 
      this.lblNodeFiles.AutoSize = true;
      this.lblNodeFiles.Location = new System.Drawing.Point(53, 38);
      this.lblNodeFiles.Name = "lblNodeFiles";
      this.lblNodeFiles.Size = new System.Drawing.Size(13, 13);
      this.lblNodeFiles.TabIndex = 10;
      this.lblNodeFiles.Text = "0";
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblStatus,
            this.lblTotalFiles,
            this.lblProgress,
            this.progressbar});
      this.statusStrip1.Location = new System.Drawing.Point(0, 325);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(770, 24);
      this.statusStrip1.TabIndex = 15;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // tslblStatus
      // 
      this.tslblStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
      this.tslblStatus.Name = "tslblStatus";
      this.tslblStatus.Size = new System.Drawing.Size(520, 19);
      this.tslblStatus.Spring = true;
      this.tslblStatus.Text = "...";
      this.tslblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblTotalFiles
      // 
      this.lblTotalFiles.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
      this.lblTotalFiles.Name = "lblTotalFiles";
      this.lblTotalFiles.Size = new System.Drawing.Size(17, 19);
      this.lblTotalFiles.Text = "0";
      // 
      // lblProgress
      // 
      this.lblProgress.Name = "lblProgress";
      this.lblProgress.Size = new System.Drawing.Size(16, 19);
      this.lblProgress.Text = "...";
      // 
      // progressbar
      // 
      this.progressbar.AutoSize = false;
      this.progressbar.Name = "progressbar";
      this.progressbar.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
      this.progressbar.Size = new System.Drawing.Size(200, 18);
      this.progressbar.Step = 100;
      this.progressbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
      // 
      // panel3
      // 
      this.tlpMain.SetColumnSpan(this.panel3, 4);
      this.panel3.Controls.Add(this.txtSource);
      this.panel3.Controls.Add(this.btnBrowseSource);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel3.Location = new System.Drawing.Point(69, 3);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(698, 29);
      this.panel3.TabIndex = 16;
      // 
      // tlpMain
      // 
      this.tlpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tlpMain.ColumnCount = 5;
      this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tlpMain.Controls.Add(this.panel6, 1, 3);
      this.tlpMain.Controls.Add(this.panel5, 1, 2);
      this.tlpMain.Controls.Add(this.label6, 0, 2);
      this.tlpMain.Controls.Add(this.panel4, 1, 1);
      this.tlpMain.Controls.Add(this.tlpPreview, 0, 4);
      this.tlpMain.Controls.Add(this.label2, 0, 1);
      this.tlpMain.Controls.Add(this.label1, 0, 0);
      this.tlpMain.Controls.Add(this.btnScan, 3, 3);
      this.tlpMain.Controls.Add(this.panel3, 1, 0);
      this.tlpMain.Controls.Add(this.btnStart, 4, 3);
      this.tlpMain.Controls.Add(this.lblHelp, 0, 3);
      this.tlpMain.Controls.Add(this.btnMore, 2, 3);
      this.tlpMain.Location = new System.Drawing.Point(0, 1);
      this.tlpMain.Name = "tlpMain";
      this.tlpMain.RowCount = 5;
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpMain.Size = new System.Drawing.Size(770, 321);
      this.tlpMain.TabIndex = 17;
      // 
      // panel6
      // 
      this.panel6.Controls.Add(this.chkDeleteSource);
      this.panel6.Controls.Add(this.label13);
      this.panel6.Controls.Add(this.label12);
      this.panel6.Controls.Add(this.nudArchive);
      this.panel6.Controls.Add(this.chkArchive);
      this.panel6.Controls.Add(this.chkRecursive);
      this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel6.Location = new System.Drawing.Point(69, 104);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(398, 24);
      this.panel6.TabIndex = 18;
      // 
      // chkDeleteSource
      // 
      this.chkDeleteSource.AutoSize = true;
      this.chkDeleteSource.Location = new System.Drawing.Point(89, 4);
      this.chkDeleteSource.Name = "chkDeleteSource";
      this.chkDeleteSource.Size = new System.Drawing.Size(95, 17);
      this.chkDeleteSource.TabIndex = 24;
      this.chkDeleteSource.Text = "Delete Original";
      this.chkDeleteSource.UseVisualStyleBackColor = true;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(359, 5);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(29, 13);
      this.label13.TabIndex = 23;
      this.label13.Text = "days";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(268, 5);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(31, 13);
      this.label12.TabIndex = 22;
      this.label12.Text = "after:";
      // 
      // nudArchive
      // 
      this.nudArchive.Location = new System.Drawing.Point(300, 3);
      this.nudArchive.Maximum = new decimal(new int[] {
            3650,
            0,
            0,
            0});
      this.nudArchive.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
      this.nudArchive.Name = "nudArchive";
      this.nudArchive.Size = new System.Drawing.Size(56, 20);
      this.nudArchive.TabIndex = 21;
      this.nudArchive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.nudArchive.Value = new decimal(new int[] {
            730,
            0,
            0,
            0});
      this.nudArchive.ValueChanged += new System.EventHandler(this.nudArchive_ValueChanged);
      // 
      // chkArchive
      // 
      this.chkArchive.AutoSize = true;
      this.chkArchive.Location = new System.Drawing.Point(202, 4);
      this.chkArchive.Name = "chkArchive";
      this.chkArchive.Size = new System.Drawing.Size(62, 17);
      this.chkArchive.TabIndex = 20;
      this.chkArchive.Text = "Archive";
      this.chkArchive.UseVisualStyleBackColor = true;
      // 
      // chkRecursive
      // 
      this.chkRecursive.AutoSize = true;
      this.chkRecursive.Location = new System.Drawing.Point(3, 4);
      this.chkRecursive.Name = "chkRecursive";
      this.chkRecursive.Size = new System.Drawing.Size(74, 17);
      this.chkRecursive.TabIndex = 19;
      this.chkRecursive.Text = "Recursive";
      this.chkRecursive.UseVisualStyleBackColor = true;
      // 
      // panel5
      // 
      this.tlpMain.SetColumnSpan(this.panel5, 4);
      this.panel5.Controls.Add(this.txtLog);
      this.panel5.Controls.Add(this.btnBrowseLog);
      this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel5.Location = new System.Drawing.Point(69, 71);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(698, 27);
      this.panel5.TabIndex = 18;
      // 
      // txtLog
      // 
      this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtLog.Location = new System.Drawing.Point(3, 3);
      this.txtLog.Name = "txtLog";
      this.txtLog.Size = new System.Drawing.Size(663, 20);
      this.txtLog.TabIndex = 18;
      this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
      // 
      // btnBrowseLog
      // 
      this.btnBrowseLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnBrowseLog.Location = new System.Drawing.Point(665, 2);
      this.btnBrowseLog.Name = "btnBrowseLog";
      this.btnBrowseLog.Size = new System.Drawing.Size(30, 22);
      this.btnBrowseLog.TabIndex = 19;
      this.btnBrowseLog.Text = "...";
      this.btnBrowseLog.UseVisualStyleBackColor = true;
      this.btnBrowseLog.Click += new System.EventHandler(this.btnBrowseLog_Click);
      // 
      // label6
      // 
      this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(38, 68);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(25, 33);
      this.label6.TabIndex = 18;
      this.label6.Text = "Log";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // panel4
      // 
      this.tlpMain.SetColumnSpan(this.panel4, 4);
      this.panel4.Controls.Add(this.txtDest);
      this.panel4.Controls.Add(this.btnBrowseDest);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel4.Location = new System.Drawing.Point(69, 38);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(698, 27);
      this.panel4.TabIndex = 18;
      // 
      // lblHelp
      // 
      this.lblHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblHelp.Cursor = System.Windows.Forms.Cursors.Hand;
      this.lblHelp.Image = ((System.Drawing.Image)(resources.GetObject("lblHelp.Image")));
      this.lblHelp.Location = new System.Drawing.Point(3, 101);
      this.lblHelp.Name = "lblHelp";
      this.lblHelp.Size = new System.Drawing.Size(60, 30);
      this.lblHelp.TabIndex = 19;
      this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
      // 
      // btnMore
      // 
      this.btnMore.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnMore.Location = new System.Drawing.Point(473, 104);
      this.btnMore.Name = "btnMore";
      this.btnMore.Size = new System.Drawing.Size(94, 24);
      this.btnMore.TabIndex = 20;
      this.btnMore.Text = "more";
      this.btnMore.UseVisualStyleBackColor = true;
      this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
      // 
      // pnlHelp
      // 
      this.pnlHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnlHelp.Controls.Add(this.label19);
      this.pnlHelp.Controls.Add(this.label20);
      this.pnlHelp.Controls.Add(this.label21);
      this.pnlHelp.Controls.Add(this.label18);
      this.pnlHelp.Controls.Add(this.label17);
      this.pnlHelp.Controls.Add(this.label16);
      this.pnlHelp.Controls.Add(this.label15);
      this.pnlHelp.Controls.Add(this.label14);
      this.pnlHelp.Location = new System.Drawing.Point(69, 1);
      this.pnlHelp.Name = "pnlHelp";
      this.pnlHelp.Size = new System.Drawing.Size(520, 106);
      this.pnlHelp.TabIndex = 18;
      this.pnlHelp.Visible = false;
      // 
      // label19
      // 
      this.label19.AutoSize = true;
      this.label19.Location = new System.Drawing.Point(18, 139);
      this.label19.Name = "label19";
      this.label19.Size = new System.Drawing.Size(93, 13);
      this.label19.TabIndex = 7;
      this.label19.Text = "p3, l, log = Log file";
      // 
      // label20
      // 
      this.label20.AutoSize = true;
      this.label20.Location = new System.Drawing.Point(18, 120);
      this.label20.Name = "label20";
      this.label20.Size = new System.Drawing.Size(222, 13);
      this.label20.TabIndex = 6;
      this.label20.Text = "p2, d, dest, destination = Destination directory";
      // 
      // label21
      // 
      this.label21.AutoSize = true;
      this.label21.Location = new System.Drawing.Point(18, 101);
      this.label21.Name = "label21";
      this.label21.Size = new System.Drawing.Size(157, 13);
      this.label21.TabIndex = 5;
      this.label21.Text = "p1, s, source = Source directory";
      // 
      // label18
      // 
      this.label18.AutoSize = true;
      this.label18.Location = new System.Drawing.Point(18, 82);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(139, 13);
      this.label18.TabIndex = 4;
      this.label18.Text = "i = Archiving Interval in days";
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.Location = new System.Drawing.Point(18, 63);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(61, 13);
      this.label17.TabIndex = 3;
      this.label17.Text = "a = Archive";
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Location = new System.Drawing.Point(18, 44);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(70, 13);
      this.label16.TabIndex = 2;
      this.label16.Text = "r = Recursive";
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Location = new System.Drawing.Point(18, 25);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(484, 13);
      this.label15.TabIndex = 1;
      this.label15.Text = "z = Silent Mode. Does not show form and will copy files based on other parameters" +
    " (or defaults) given.";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(5, 5);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(131, 13);
      this.label14.TabIndex = 0;
      this.label14.Text = "Command line parameters:";
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(770, 349);
      this.Controls.Add(this.pnlHelp);
      this.Controls.Add(this.tlpMain);
      this.Controls.Add(this.statusStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MinimumSize = new System.Drawing.Size(785, 221);
      this.Name = "frmMain";
      this.Text = "FCTnet File Manager";
      this.Load += new System.EventHandler(this.frmMain_Load);
      this.tlpPreview.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.tlpMain.ResumeLayout(false);
      this.tlpMain.PerformLayout();
      this.panel6.ResumeLayout(false);
      this.panel6.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudArchive)).EndInit();
      this.panel5.ResumeLayout(false);
      this.panel5.PerformLayout();
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.pnlHelp.ResumeLayout(false);
      this.pnlHelp.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.TextBox txtSource;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDest;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBrowseSource;
		private System.Windows.Forms.Button btnBrowseDest;
		private System.Windows.Forms.Button btnScan;
		private System.Windows.Forms.TableLayoutPanel tlpPreview;
		private System.Windows.Forms.TableLayoutPanel tlpMain;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblFolders;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblFiles;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblSize;
		private System.Windows.Forms.TreeView treeSource;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblNodeSize;
		private System.Windows.Forms.Label lblNodeFolders;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lblNodeFiles;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel tslblStatus;
		private System.Windows.Forms.ToolStripProgressBar progressbar;
		private System.Windows.Forms.Label lblNodePath;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ToolStripStatusLabel lblProgress;
		private System.Windows.Forms.Label lblNodeModified;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TreeView treeDest;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TextBox txtLog;
		private System.Windows.Forms.Button btnBrowseLog;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ToolStripStatusLabel lblTotalFiles;
		private System.Windows.Forms.CheckBox chkRecursive;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.CheckBox chkArchive;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.NumericUpDown nudArchive;
		private System.Windows.Forms.Label lblHelp;
		private System.Windows.Forms.Panel pnlHelp;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
    private System.Windows.Forms.CheckBox chkDeleteSource;
    private System.Windows.Forms.Button btnMore;
  }
}

