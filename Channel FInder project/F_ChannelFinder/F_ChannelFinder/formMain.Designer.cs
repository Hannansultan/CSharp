namespace F_ChannelFinder
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.pbFindLogo = new System.Windows.Forms.PictureBox();
            this.pbLoadVideo = new System.Windows.Forms.PictureBox();
            this.grpBoxSlectOperation = new System.Windows.Forms.GroupBox();
            this.lblSelectVideo = new System.Windows.Forms.Label();
            this.lblFindVideo = new System.Windows.Forms.Label();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpBoxSelectVideo = new System.Windows.Forms.GroupBox();
            this.btnConvertToFrames = new System.Windows.Forms.Button();
            this.progrsBarFrames = new System.Windows.Forms.ProgressBar();
            this.lblProgressBar = new System.Windows.Forms.Label();
            this.btnFramesPath = new System.Windows.Forms.Button();
            this.tbFramesPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBoxAddImage = new System.Windows.Forms.GroupBox();
            this.tbChannelName = new System.Windows.Forms.TextBox();
            this.tbLogoTag = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddLogo = new System.Windows.Forms.Button();
            this.btnBrosLogo = new System.Windows.Forms.Button();
            this.tbLogoPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ofdVideoPath = new System.Windows.Forms.OpenFileDialog();
            this.grpBoxFindLogo = new System.Windows.Forms.GroupBox();
            this.btnStartSURF = new System.Windows.Forms.Button();
            this.progrsBarSURF = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVideoPathText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFramesPathText = new System.Windows.Forms.Label();
            this.saveFileDilgFrames = new System.Windows.Forms.FolderBrowserDialog();
            this.grpBoxAllLogo = new System.Windows.Forms.GroupBox();
            this.dgvImageStore = new System.Windows.Forms.DataGridView();
            this.grpBoxPic = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllLogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageBoxSURF = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadVideo)).BeginInit();
            this.grpBoxSlectOperation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpBoxSelectVideo.SuspendLayout();
            this.grpBoxAddImage.SuspendLayout();
            this.grpBoxFindLogo.SuspendLayout();
            this.grpBoxAllLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImageStore)).BeginInit();
            this.grpBoxPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxSURF)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFindLogo
            // 
            this.pbFindLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbFindLogo.Image = global::F_ChannelFinder.Properties.Resources.findLogo;
            this.pbFindLogo.Location = new System.Drawing.Point(376, 98);
            this.pbFindLogo.Name = "pbFindLogo";
            this.pbFindLogo.Size = new System.Drawing.Size(213, 212);
            this.pbFindLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFindLogo.TabIndex = 1;
            this.pbFindLogo.TabStop = false;
            this.pbFindLogo.Click += new System.EventHandler(this.pbFindLogo_Click);
            this.pbFindLogo.MouseEnter += new System.EventHandler(this.pbFindLogo_MouseEnter);
            this.pbFindLogo.MouseLeave += new System.EventHandler(this.pbFindLogo_MouseLeave);
            // 
            // pbLoadVideo
            // 
            this.pbLoadVideo.BackColor = System.Drawing.Color.Transparent;
            this.pbLoadVideo.Image = global::F_ChannelFinder.Properties.Resources.loadVideo;
            this.pbLoadVideo.Location = new System.Drawing.Point(115, 98);
            this.pbLoadVideo.Name = "pbLoadVideo";
            this.pbLoadVideo.Size = new System.Drawing.Size(213, 212);
            this.pbLoadVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoadVideo.TabIndex = 0;
            this.pbLoadVideo.TabStop = false;
            this.pbLoadVideo.Click += new System.EventHandler(this.pbLoadVideo_Click);
            this.pbLoadVideo.MouseEnter += new System.EventHandler(this.pbLoadVideo_MouseEnter);
            this.pbLoadVideo.MouseLeave += new System.EventHandler(this.pbLoadVideo_MouseLeave);
            // 
            // grpBoxSlectOperation
            // 
            this.grpBoxSlectOperation.Controls.Add(this.lblSelectVideo);
            this.grpBoxSlectOperation.Controls.Add(this.lblFindVideo);
            this.grpBoxSlectOperation.Location = new System.Drawing.Point(81, 85);
            this.grpBoxSlectOperation.Name = "grpBoxSlectOperation";
            this.grpBoxSlectOperation.Size = new System.Drawing.Size(533, 280);
            this.grpBoxSlectOperation.TabIndex = 2;
            this.grpBoxSlectOperation.TabStop = false;
            this.grpBoxSlectOperation.Text = "Select Operation";
            // 
            // lblSelectVideo
            // 
            this.lblSelectVideo.AutoSize = true;
            this.lblSelectVideo.Location = new System.Drawing.Point(97, 251);
            this.lblSelectVideo.Name = "lblSelectVideo";
            this.lblSelectVideo.Size = new System.Drawing.Size(67, 13);
            this.lblSelectVideo.TabIndex = 0;
            this.lblSelectVideo.Text = "Select Video";
            // 
            // lblFindVideo
            // 
            this.lblFindVideo.AutoSize = true;
            this.lblFindVideo.Location = new System.Drawing.Point(365, 251);
            this.lblFindVideo.Name = "lblFindVideo";
            this.lblFindVideo.Size = new System.Drawing.Size(54, 13);
            this.lblFindVideo.TabIndex = 3;
            this.lblFindVideo.Text = "Find Logo";
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblProgramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramName.ForeColor = System.Drawing.Color.White;
            this.lblProgramName.Location = new System.Drawing.Point(159, -3);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(367, 55);
            this.lblProgramName.TabIndex = 3;
            this.lblProgramName.Text = "Channel Finder";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.lblProgramName);
            this.panel1.Location = new System.Drawing.Point(-1, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 52);
            this.panel1.TabIndex = 4;
            // 
            // grpBoxSelectVideo
            // 
            this.grpBoxSelectVideo.Controls.Add(this.btnConvertToFrames);
            this.grpBoxSelectVideo.Controls.Add(this.progrsBarFrames);
            this.grpBoxSelectVideo.Controls.Add(this.lblProgressBar);
            this.grpBoxSelectVideo.Controls.Add(this.btnFramesPath);
            this.grpBoxSelectVideo.Controls.Add(this.tbFramesPath);
            this.grpBoxSelectVideo.Controls.Add(this.btnBrowse);
            this.grpBoxSelectVideo.Controls.Add(this.tbFilePath);
            this.grpBoxSelectVideo.Controls.Add(this.lblFilePath);
            this.grpBoxSelectVideo.Controls.Add(this.label2);
            this.grpBoxSelectVideo.Location = new System.Drawing.Point(707, 12);
            this.grpBoxSelectVideo.Name = "grpBoxSelectVideo";
            this.grpBoxSelectVideo.Size = new System.Drawing.Size(533, 143);
            this.grpBoxSelectVideo.TabIndex = 5;
            this.grpBoxSelectVideo.TabStop = false;
            this.grpBoxSelectVideo.Text = "Select Video ";
            // 
            // btnConvertToFrames
            // 
            this.btnConvertToFrames.Enabled = false;
            this.btnConvertToFrames.Location = new System.Drawing.Point(452, 98);
            this.btnConvertToFrames.Name = "btnConvertToFrames";
            this.btnConvertToFrames.Size = new System.Drawing.Size(75, 23);
            this.btnConvertToFrames.TabIndex = 6;
            this.btnConvertToFrames.Text = "Convert";
            this.btnConvertToFrames.UseVisualStyleBackColor = true;
            this.btnConvertToFrames.Click += new System.EventHandler(this.btnConvertToFrames_Click);
            // 
            // progrsBarFrames
            // 
            this.progrsBarFrames.Enabled = false;
            this.progrsBarFrames.Location = new System.Drawing.Point(87, 98);
            this.progrsBarFrames.Name = "progrsBarFrames";
            this.progrsBarFrames.Size = new System.Drawing.Size(359, 23);
            this.progrsBarFrames.TabIndex = 5;
            // 
            // lblProgressBar
            // 
            this.lblProgressBar.AutoSize = true;
            this.lblProgressBar.Location = new System.Drawing.Point(31, 98);
            this.lblProgressBar.Name = "lblProgressBar";
            this.lblProgressBar.Size = new System.Drawing.Size(48, 13);
            this.lblProgressBar.TabIndex = 2;
            this.lblProgressBar.Text = "Progress";
            // 
            // btnFramesPath
            // 
            this.btnFramesPath.Location = new System.Drawing.Point(452, 58);
            this.btnFramesPath.Name = "btnFramesPath";
            this.btnFramesPath.Size = new System.Drawing.Size(75, 23);
            this.btnFramesPath.TabIndex = 4;
            this.btnFramesPath.Text = "Browse...";
            this.btnFramesPath.UseVisualStyleBackColor = true;
            this.btnFramesPath.Click += new System.EventHandler(this.btnFramesPath_Click);
            // 
            // tbFramesPath
            // 
            this.tbFramesPath.Location = new System.Drawing.Point(87, 60);
            this.tbFramesPath.Name = "tbFramesPath";
            this.tbFramesPath.Size = new System.Drawing.Size(359, 20);
            this.tbFramesPath.TabIndex = 3;
            this.tbFramesPath.TextChanged += new System.EventHandler(this.tbFramesPath_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(452, 25);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(87, 27);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(359, 20);
            this.tbFilePath.TabIndex = 1;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(31, 30);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(48, 13);
            this.lblFilePath.TabIndex = 0;
            this.lblFilePath.Text = "File Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Frames Path";
            // 
            // grpBoxAddImage
            // 
            this.grpBoxAddImage.Controls.Add(this.tbChannelName);
            this.grpBoxAddImage.Controls.Add(this.tbLogoTag);
            this.grpBoxAddImage.Controls.Add(this.label8);
            this.grpBoxAddImage.Controls.Add(this.label5);
            this.grpBoxAddImage.Controls.Add(this.btnAddLogo);
            this.grpBoxAddImage.Controls.Add(this.btnBrosLogo);
            this.grpBoxAddImage.Controls.Add(this.tbLogoPath);
            this.grpBoxAddImage.Controls.Add(this.label1);
            this.grpBoxAddImage.Location = new System.Drawing.Point(723, 161);
            this.grpBoxAddImage.Name = "grpBoxAddImage";
            this.grpBoxAddImage.Size = new System.Drawing.Size(533, 143);
            this.grpBoxAddImage.TabIndex = 7;
            this.grpBoxAddImage.TabStop = false;
            this.grpBoxAddImage.Text = "Add Logo";
            // 
            // tbChannelName
            // 
            this.tbChannelName.Location = new System.Drawing.Point(304, 73);
            this.tbChannelName.Name = "tbChannelName";
            this.tbChannelName.Size = new System.Drawing.Size(219, 20);
            this.tbChannelName.TabIndex = 11;
            // 
            // tbLogoTag
            // 
            this.tbLogoTag.Location = new System.Drawing.Point(81, 73);
            this.tbLogoTag.Name = "tbLogoTag";
            this.tbLogoTag.Size = new System.Drawing.Size(134, 20);
            this.tbLogoTag.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(221, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Channel Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Logo Tag";
            // 
            // btnAddLogo
            // 
            this.btnAddLogo.Location = new System.Drawing.Point(448, 114);
            this.btnAddLogo.Name = "btnAddLogo";
            this.btnAddLogo.Size = new System.Drawing.Size(75, 23);
            this.btnAddLogo.TabIndex = 6;
            this.btnAddLogo.Text = "Add";
            this.btnAddLogo.UseVisualStyleBackColor = true;
            this.btnAddLogo.Click += new System.EventHandler(this.btnAddLogo_Click);
            // 
            // btnBrosLogo
            // 
            this.btnBrosLogo.Location = new System.Drawing.Point(448, 30);
            this.btnBrosLogo.Name = "btnBrosLogo";
            this.btnBrosLogo.Size = new System.Drawing.Size(75, 23);
            this.btnBrosLogo.TabIndex = 5;
            this.btnBrosLogo.Text = "Browse...";
            this.btnBrosLogo.UseVisualStyleBackColor = true;
            this.btnBrosLogo.Click += new System.EventHandler(this.btnBrosLogo_Click);
            // 
            // tbLogoPath
            // 
            this.tbLogoPath.Location = new System.Drawing.Point(83, 30);
            this.tbLogoPath.Name = "tbLogoPath";
            this.tbLogoPath.Size = new System.Drawing.Size(359, 20);
            this.tbLogoPath.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose Logo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Video Path";
            // 
            // ofdVideoPath
            // 
            this.ofdVideoPath.FileName = "Select Video";
            // 
            // grpBoxFindLogo
            // 
            this.grpBoxFindLogo.Controls.Add(this.btnStartSURF);
            this.grpBoxFindLogo.Controls.Add(this.progrsBarSURF);
            this.grpBoxFindLogo.Controls.Add(this.label6);
            this.grpBoxFindLogo.Controls.Add(this.lblVideoPathText);
            this.grpBoxFindLogo.Controls.Add(this.label3);
            this.grpBoxFindLogo.Controls.Add(this.lblFramesPathText);
            this.grpBoxFindLogo.Controls.Add(this.label4);
            this.grpBoxFindLogo.Location = new System.Drawing.Point(81, 404);
            this.grpBoxFindLogo.Name = "grpBoxFindLogo";
            this.grpBoxFindLogo.Size = new System.Drawing.Size(533, 143);
            this.grpBoxFindLogo.TabIndex = 6;
            this.grpBoxFindLogo.TabStop = false;
            this.grpBoxFindLogo.Text = "Find Logo";
            // 
            // btnStartSURF
            // 
            this.btnStartSURF.Location = new System.Drawing.Point(450, 95);
            this.btnStartSURF.Name = "btnStartSURF";
            this.btnStartSURF.Size = new System.Drawing.Size(75, 23);
            this.btnStartSURF.TabIndex = 9;
            this.btnStartSURF.Text = "Start";
            this.btnStartSURF.UseVisualStyleBackColor = true;
            this.btnStartSURF.Click += new System.EventHandler(this.btnStartSURF_Click);
            // 
            // progrsBarSURF
            // 
            this.progrsBarSURF.Location = new System.Drawing.Point(108, 95);
            this.progrsBarSURF.Name = "progrsBarSURF";
            this.progrsBarSURF.Size = new System.Drawing.Size(336, 23);
            this.progrsBarSURF.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Progress";
            // 
            // lblVideoPathText
            // 
            this.lblVideoPathText.AutoSize = true;
            this.lblVideoPathText.Location = new System.Drawing.Point(105, 30);
            this.lblVideoPathText.Name = "lblVideoPathText";
            this.lblVideoPathText.Size = new System.Drawing.Size(10, 13);
            this.lblVideoPathText.TabIndex = 6;
            this.lblVideoPathText.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Frames Path";
            // 
            // lblFramesPathText
            // 
            this.lblFramesPathText.AutoSize = true;
            this.lblFramesPathText.Location = new System.Drawing.Point(105, 65);
            this.lblFramesPathText.Name = "lblFramesPathText";
            this.lblFramesPathText.Size = new System.Drawing.Size(10, 13);
            this.lblFramesPathText.TabIndex = 4;
            this.lblFramesPathText.Text = "-";
            // 
            // grpBoxAllLogo
            // 
            this.grpBoxAllLogo.Controls.Add(this.dgvImageStore);
            this.grpBoxAllLogo.Location = new System.Drawing.Point(641, 234);
            this.grpBoxAllLogo.Name = "grpBoxAllLogo";
            this.grpBoxAllLogo.Size = new System.Drawing.Size(533, 143);
            this.grpBoxAllLogo.TabIndex = 7;
            this.grpBoxAllLogo.TabStop = false;
            this.grpBoxAllLogo.Text = "All Logo";
            // 
            // dgvImageStore
            // 
            this.dgvImageStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImageStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImageStore.Location = new System.Drawing.Point(3, 16);
            this.dgvImageStore.Name = "dgvImageStore";
            this.dgvImageStore.Size = new System.Drawing.Size(527, 124);
            this.dgvImageStore.TabIndex = 0;
            this.dgvImageStore.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImageStore_CellEnter);
            // 
            // grpBoxPic
            // 
            this.grpBoxPic.Controls.Add(this.pictureBox1);
            this.grpBoxPic.Location = new System.Drawing.Point(644, 383);
            this.grpBoxPic.Name = "grpBoxPic";
            this.grpBoxPic.Size = new System.Drawing.Size(533, 291);
            this.grpBoxPic.TabIndex = 8;
            this.grpBoxPic.TabStop = false;
            this.grpBoxPic.Text = "Image";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(527, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLogoToolStripMenuItem,
            this.viewAllLogoToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.addToolStripMenuItem.Text = "Add ";
            // 
            // addLogoToolStripMenuItem
            // 
            this.addLogoToolStripMenuItem.Name = "addLogoToolStripMenuItem";
            this.addLogoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.addLogoToolStripMenuItem.Text = "Add Logo";
            this.addLogoToolStripMenuItem.Click += new System.EventHandler(this.addLogoToolStripMenuItem_Click);
            // 
            // viewAllLogoToolStripMenuItem
            // 
            this.viewAllLogoToolStripMenuItem.Name = "viewAllLogoToolStripMenuItem";
            this.viewAllLogoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.viewAllLogoToolStripMenuItem.Text = "View All Logo";
            this.viewAllLogoToolStripMenuItem.Click += new System.EventHandler(this.viewAllLogoToolStripMenuItem_Click);
            // 
            // imageBoxSURF
            // 
            this.imageBoxSURF.Location = new System.Drawing.Point(641, 148);
            this.imageBoxSURF.Name = "imageBoxSURF";
            this.imageBoxSURF.Size = new System.Drawing.Size(75, 49);
            this.imageBoxSURF.TabIndex = 2;
            this.imageBoxSURF.TabStop = false;
            this.imageBoxSURF.Visible = false;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 529);
            this.Controls.Add(this.imageBoxSURF);
            this.Controls.Add(this.grpBoxPic);
            this.Controls.Add(this.grpBoxAddImage);
            this.Controls.Add(this.grpBoxAllLogo);
            this.Controls.Add(this.grpBoxFindLogo);
            this.Controls.Add(this.grpBoxSelectVideo);
            this.Controls.Add(this.pbFindLogo);
            this.Controls.Add(this.pbLoadVideo);
            this.Controls.Add(this.grpBoxSlectOperation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Channel Finder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_FormClosing);
            this.Load += new System.EventHandler(this.formMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFindLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadVideo)).EndInit();
            this.grpBoxSlectOperation.ResumeLayout(false);
            this.grpBoxSlectOperation.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpBoxSelectVideo.ResumeLayout(false);
            this.grpBoxSelectVideo.PerformLayout();
            this.grpBoxAddImage.ResumeLayout(false);
            this.grpBoxAddImage.PerformLayout();
            this.grpBoxFindLogo.ResumeLayout(false);
            this.grpBoxFindLogo.PerformLayout();
            this.grpBoxAllLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImageStore)).EndInit();
            this.grpBoxPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxSURF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLoadVideo;
        private System.Windows.Forms.PictureBox pbFindLogo;
        private System.Windows.Forms.GroupBox grpBoxSlectOperation;
        private System.Windows.Forms.Label lblSelectVideo;
        private System.Windows.Forms.Label lblFindVideo;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpBoxSelectVideo;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProgressBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progrsBarFrames;
        private System.Windows.Forms.Button btnFramesPath;
        private System.Windows.Forms.TextBox tbFramesPath;
        private System.Windows.Forms.Button btnConvertToFrames;
        private System.Windows.Forms.OpenFileDialog ofdVideoPath;
        private System.Windows.Forms.GroupBox grpBoxFindLogo;
        private System.Windows.Forms.Button btnStartSURF;
        private System.Windows.Forms.ProgressBar progrsBarSURF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblVideoPathText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFramesPathText;
        private System.Windows.Forms.FolderBrowserDialog saveFileDilgFrames;
        private System.Windows.Forms.GroupBox grpBoxAddImage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddLogo;
        private System.Windows.Forms.Button btnBrosLogo;
        private System.Windows.Forms.TextBox tbLogoPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbChannelName;
        private System.Windows.Forms.TextBox tbLogoTag;
        private System.Windows.Forms.GroupBox grpBoxAllLogo;
        private System.Windows.Forms.DataGridView dgvImageStore;
        private System.Windows.Forms.GroupBox grpBoxPic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllLogoToolStripMenuItem;
        private Emgu.CV.UI.ImageBox imageBoxSURF;
    }
}