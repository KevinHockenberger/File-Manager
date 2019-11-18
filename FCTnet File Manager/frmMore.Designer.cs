namespace FCTnet_File_Manager
{
  partial class frmMore
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMore));
      this.txtSource = new System.Windows.Forms.TextBox();
      this.btnBrowseSource = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.chkRecursive = new System.Windows.Forms.CheckBox();
      this.btnEval = new System.Windows.Forms.Button();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.tslblStatus = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblTotalFiles = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblProgress = new System.Windows.Forms.ToolStripStatusLabel();
      this.progressbar = new System.Windows.Forms.ToolStripProgressBar();
      this.panel1 = new System.Windows.Forms.Panel();
      this.lblSize = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.lblFiles = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.lblFolders = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.tree = new System.Windows.Forms.TreeView();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
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
      this.lblMaxSize = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.lblAvgSize = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.lblMinSize = new System.Windows.Forms.Label();
      this.lblSubFileCount = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.btnExport = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtSource
      // 
      this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtSource.Location = new System.Drawing.Point(64, 4);
      this.txtSource.Margin = new System.Windows.Forms.Padding(3, 4, 0, 3);
      this.txtSource.Name = "txtSource";
      this.txtSource.Size = new System.Drawing.Size(535, 20);
      this.txtSource.TabIndex = 6;
      // 
      // btnBrowseSource
      // 
      this.btnBrowseSource.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnBrowseSource.Location = new System.Drawing.Point(599, 3);
      this.btnBrowseSource.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
      this.btnBrowseSource.Name = "btnBrowseSource";
      this.btnBrowseSource.Size = new System.Drawing.Size(28, 22);
      this.btnBrowseSource.TabIndex = 7;
      this.btnBrowseSource.Text = "...";
      this.btnBrowseSource.UseVisualStyleBackColor = true;
      this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Location = new System.Drawing.Point(3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 28);
      this.label1.TabIndex = 8;
      this.label1.Text = "Source";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.btnBrowseSource, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.txtSource, 1, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(630, 28);
      this.tableLayoutPanel1.TabIndex = 9;
      // 
      // chkRecursive
      // 
      this.chkRecursive.AutoSize = true;
      this.chkRecursive.Checked = true;
      this.chkRecursive.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkRecursive.Location = new System.Drawing.Point(3, 3);
      this.chkRecursive.Name = "chkRecursive";
      this.chkRecursive.Size = new System.Drawing.Size(74, 17);
      this.chkRecursive.TabIndex = 20;
      this.chkRecursive.Text = "Recursive";
      this.chkRecursive.UseVisualStyleBackColor = true;
      // 
      // btnEval
      // 
      this.btnEval.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnEval.Location = new System.Drawing.Point(518, 3);
      this.btnEval.Name = "btnEval";
      this.btnEval.Size = new System.Drawing.Size(94, 24);
      this.btnEval.TabIndex = 21;
      this.btnEval.Text = "Evaluate";
      this.btnEval.UseVisualStyleBackColor = true;
      this.btnEval.Click += new System.EventHandler(this.btnEval_Click);
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 3;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel2.Controls.Add(this.btnExport, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.btnEval, 3, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 320);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(615, 30);
      this.tableLayoutPanel2.TabIndex = 22;
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel3.ColumnCount = 1;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
      this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
      this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 34);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 2;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(621, 353);
      this.tableLayoutPanel3.TabIndex = 23;
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblStatus,
            this.lblTotalFiles,
            this.lblProgress,
            this.progressbar});
      this.statusStrip1.Location = new System.Drawing.Point(0, 390);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(630, 24);
      this.statusStrip1.TabIndex = 24;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // tslblStatus
      // 
      this.tslblStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
      this.tslblStatus.Name = "tslblStatus";
      this.tslblStatus.Size = new System.Drawing.Size(380, 19);
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
      // panel1
      // 
      this.panel1.Controls.Add(this.lblSubFileCount);
      this.panel1.Controls.Add(this.label12);
      this.panel1.Controls.Add(this.lblMaxSize);
      this.panel1.Controls.Add(this.label6);
      this.panel1.Controls.Add(this.lblAvgSize);
      this.panel1.Controls.Add(this.label13);
      this.panel1.Controls.Add(this.label14);
      this.panel1.Controls.Add(this.lblMinSize);
      this.panel1.Controls.Add(this.tree);
      this.panel1.Controls.Add(this.lblNodeModified);
      this.panel1.Controls.Add(this.label11);
      this.panel1.Controls.Add(this.lblNodePath);
      this.panel1.Controls.Add(this.label8);
      this.panel1.Controls.Add(this.label9);
      this.panel1.Controls.Add(this.lblNodeSize);
      this.panel1.Controls.Add(this.lblNodeFolders);
      this.panel1.Controls.Add(this.label7);
      this.panel1.Controls.Add(this.label10);
      this.panel1.Controls.Add(this.lblNodeFiles);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.lblFolders);
      this.panel1.Controls.Add(this.chkRecursive);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.lblSize);
      this.panel1.Controls.Add(this.lblFiles);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(615, 311);
      this.panel1.TabIndex = 23;
      // 
      // lblSize
      // 
      this.lblSize.AutoSize = true;
      this.lblSize.Location = new System.Drawing.Point(66, 58);
      this.lblSize.Name = "lblSize";
      this.lblSize.Size = new System.Drawing.Size(13, 13);
      this.lblSize.TabIndex = 5;
      this.lblSize.Text = "0";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(30, 58);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(30, 13);
      this.label5.TabIndex = 4;
      this.label5.Text = "Size:";
      // 
      // lblFiles
      // 
      this.lblFiles.AutoSize = true;
      this.lblFiles.Location = new System.Drawing.Point(66, 45);
      this.lblFiles.Name = "lblFiles";
      this.lblFiles.Size = new System.Drawing.Size(13, 13);
      this.lblFiles.TabIndex = 3;
      this.lblFiles.Text = "0";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(29, 45);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(31, 13);
      this.label4.TabIndex = 2;
      this.label4.Text = "Files:";
      // 
      // lblFolders
      // 
      this.lblFolders.AutoSize = true;
      this.lblFolders.Location = new System.Drawing.Point(66, 32);
      this.lblFolders.Name = "lblFolders";
      this.lblFolders.Size = new System.Drawing.Size(13, 13);
      this.lblFolders.TabIndex = 1;
      this.lblFolders.Text = "0";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(16, 32);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(44, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Folders:";
      // 
      // tree
      // 
      this.tree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tree.ImageIndex = 0;
      this.tree.ImageList = this.imageList1;
      this.tree.Location = new System.Drawing.Point(241, 3);
      this.tree.Name = "tree";
      this.tree.SelectedImageIndex = 1;
      this.tree.Size = new System.Drawing.Size(371, 305);
      this.tree.TabIndex = 21;
      this.tree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tree_NodeMouseClick);
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
      // lblNodeModified
      // 
      this.lblNodeModified.AutoSize = true;
      this.lblNodeModified.Location = new System.Drawing.Point(66, 137);
      this.lblNodeModified.Name = "lblNodeModified";
      this.lblNodeModified.Size = new System.Drawing.Size(13, 13);
      this.lblNodeModified.TabIndex = 31;
      this.lblNodeModified.Text = "0";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(29, 137);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(31, 13);
      this.label11.TabIndex = 30;
      this.label11.Text = "Mod:";
      // 
      // lblNodePath
      // 
      this.lblNodePath.AutoSize = true;
      this.lblNodePath.Location = new System.Drawing.Point(66, 85);
      this.lblNodePath.Name = "lblNodePath";
      this.lblNodePath.Size = new System.Drawing.Size(16, 13);
      this.lblNodePath.TabIndex = 29;
      this.lblNodePath.Text = "...";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(28, 85);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(32, 13);
      this.label8.TabIndex = 28;
      this.label8.Text = "Path:";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(16, 98);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(44, 13);
      this.label9.TabIndex = 22;
      this.label9.Text = "Folders:";
      // 
      // lblNodeSize
      // 
      this.lblNodeSize.AutoSize = true;
      this.lblNodeSize.Location = new System.Drawing.Point(66, 124);
      this.lblNodeSize.Name = "lblNodeSize";
      this.lblNodeSize.Size = new System.Drawing.Size(13, 13);
      this.lblNodeSize.TabIndex = 27;
      this.lblNodeSize.Text = "0";
      // 
      // lblNodeFolders
      // 
      this.lblNodeFolders.AutoSize = true;
      this.lblNodeFolders.Location = new System.Drawing.Point(66, 98);
      this.lblNodeFolders.Name = "lblNodeFolders";
      this.lblNodeFolders.Size = new System.Drawing.Size(13, 13);
      this.lblNodeFolders.TabIndex = 23;
      this.lblNodeFolders.Text = "0";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(30, 124);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(30, 13);
      this.label7.TabIndex = 26;
      this.label7.Text = "Size:";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(29, 111);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(31, 13);
      this.label10.TabIndex = 24;
      this.label10.Text = "Files:";
      // 
      // lblNodeFiles
      // 
      this.lblNodeFiles.AutoSize = true;
      this.lblNodeFiles.Location = new System.Drawing.Point(66, 111);
      this.lblNodeFiles.Name = "lblNodeFiles";
      this.lblNodeFiles.Size = new System.Drawing.Size(13, 13);
      this.lblNodeFiles.TabIndex = 25;
      this.lblNodeFiles.Text = "0";
      // 
      // lblMaxSize
      // 
      this.lblMaxSize.AutoSize = true;
      this.lblMaxSize.Location = new System.Drawing.Point(66, 192);
      this.lblMaxSize.Name = "lblMaxSize";
      this.lblMaxSize.Size = new System.Drawing.Size(13, 13);
      this.lblMaxSize.TabIndex = 37;
      this.lblMaxSize.Text = "0";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(7, 192);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(53, 13);
      this.label6.TabIndex = 36;
      this.label6.Text = "Max Size:";
      // 
      // lblAvgSize
      // 
      this.lblAvgSize.AutoSize = true;
      this.lblAvgSize.Location = new System.Drawing.Point(66, 179);
      this.lblAvgSize.Name = "lblAvgSize";
      this.lblAvgSize.Size = new System.Drawing.Size(13, 13);
      this.lblAvgSize.TabIndex = 35;
      this.lblAvgSize.Text = "0";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(8, 179);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(52, 13);
      this.label13.TabIndex = 34;
      this.label13.Text = "Avg Size:";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(10, 166);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(50, 13);
      this.label14.TabIndex = 32;
      this.label14.Text = "Min Size:";
      // 
      // lblMinSize
      // 
      this.lblMinSize.AutoSize = true;
      this.lblMinSize.Location = new System.Drawing.Point(66, 166);
      this.lblMinSize.Name = "lblMinSize";
      this.lblMinSize.Size = new System.Drawing.Size(13, 13);
      this.lblMinSize.TabIndex = 33;
      this.lblMinSize.Text = "0";
      // 
      // lblSubFileCount
      // 
      this.lblSubFileCount.AutoSize = true;
      this.lblSubFileCount.Location = new System.Drawing.Point(66, 205);
      this.lblSubFileCount.Name = "lblSubFileCount";
      this.lblSubFileCount.Size = new System.Drawing.Size(13, 13);
      this.lblSubFileCount.TabIndex = 39;
      this.lblSubFileCount.Text = "0";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(29, 205);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(31, 13);
      this.label12.TabIndex = 38;
      this.label12.Text = "Files:";
      // 
      // btnExport
      // 
      this.btnExport.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnExport.Location = new System.Drawing.Point(3, 3);
      this.btnExport.Name = "btnExport";
      this.btnExport.Size = new System.Drawing.Size(94, 24);
      this.btnExport.TabIndex = 22;
      this.btnExport.Text = "Export";
      this.btnExport.UseVisualStyleBackColor = true;
      this.btnExport.Visible = false;
      this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
      // 
      // frmMore
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(630, 414);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.tableLayoutPanel3);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "frmMore";
      this.Text = "More ...";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel3.ResumeLayout(false);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtSource;
    private System.Windows.Forms.Button btnBrowseSource;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.CheckBox chkRecursive;
    private System.Windows.Forms.Button btnEval;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel tslblStatus;
    private System.Windows.Forms.ToolStripStatusLabel lblTotalFiles;
    private System.Windows.Forms.ToolStripStatusLabel lblProgress;
    private System.Windows.Forms.ToolStripProgressBar progressbar;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblFolders;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label lblSize;
    private System.Windows.Forms.Label lblFiles;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TreeView tree;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.Label lblNodeModified;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label lblNodePath;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label lblNodeSize;
    private System.Windows.Forms.Label lblNodeFolders;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label lblNodeFiles;
    private System.Windows.Forms.Label lblMaxSize;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label lblAvgSize;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label lblMinSize;
    private System.Windows.Forms.Label lblSubFileCount;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Button btnExport;
  }
}