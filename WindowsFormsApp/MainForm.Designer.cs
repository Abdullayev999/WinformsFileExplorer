
namespace WindowsFormsApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackPathButton = new System.Windows.Forms.Button();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.FoldersTreeView = new System.Windows.Forms.TreeView();
            this.FolderImageList = new System.Windows.Forms.ImageList(this.components);
            this.FilesListView = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDateUpdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderExtansion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FilesImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.DetailModeButton = new System.Windows.Forms.Button();
            this.ListModeButton = new System.Windows.Forms.Button();
            this.SmallIconModeButton = new System.Windows.Forms.Button();
            this.LargeIconModeButton = new System.Windows.Forms.Button();
            this.ElementsCountLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MovetoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertMoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BackPathButton);
            this.panel1.Controls.Add(this.PathTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Size = new System.Drawing.Size(1579, 63);
            this.panel1.TabIndex = 0;
            // 
            // BackPathButton
            // 
            this.BackPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackPathButton.Location = new System.Drawing.Point(11, 15);
            this.BackPathButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackPathButton.Name = "BackPathButton";
            this.BackPathButton.Size = new System.Drawing.Size(35, 32);
            this.BackPathButton.TabIndex = 1;
            this.BackPathButton.Text = "◀";
            this.BackPathButton.UseVisualStyleBackColor = true;
            this.BackPathButton.Click += new System.EventHandler(this.BackPathButton_Click);
            // 
            // PathTextBox
            // 
            this.PathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathTextBox.Location = new System.Drawing.Point(53, 15);
            this.PathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.ReadOnly = true;
            this.PathTextBox.Size = new System.Drawing.Size(1508, 30);
            this.PathTextBox.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 63);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.FoldersTreeView);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(7, 6, 0, 6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.FilesListView);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 6, 7, 6);
            this.splitContainer1.Size = new System.Drawing.Size(1579, 836);
            this.splitContainer1.SplitterDistance = 525;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // FoldersTreeView
            // 
            this.FoldersTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FoldersTreeView.ImageIndex = 24;
            this.FoldersTreeView.ImageList = this.FolderImageList;
            this.FoldersTreeView.Location = new System.Drawing.Point(7, 6);
            this.FoldersTreeView.Margin = new System.Windows.Forms.Padding(4);
            this.FoldersTreeView.Name = "FoldersTreeView";
            this.FoldersTreeView.SelectedImageIndex = 24;
            this.FoldersTreeView.Size = new System.Drawing.Size(518, 824);
            this.FoldersTreeView.TabIndex = 0;
            this.FoldersTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.FoldersTreeView_BeforeExpand);
            this.FoldersTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FoldersTreeView_AfterSelect);
            // 
            // FolderImageList
            // 
            this.FolderImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("FolderImageList.ImageStream")));
            this.FolderImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.FolderImageList.Images.SetKeyName(0, "001-driver.png");
            this.FolderImageList.Images.SetKeyName(1, "001-file.png");
            this.FolderImageList.Images.SetKeyName(2, "002-file.png");
            this.FolderImageList.Images.SetKeyName(3, "002-local-disk.png");
            this.FolderImageList.Images.SetKeyName(4, "003-file.png");
            this.FolderImageList.Images.SetKeyName(5, "003-rom.png");
            this.FolderImageList.Images.SetKeyName(6, "004-cd.png");
            this.FolderImageList.Images.SetKeyName(7, "004-file.png");
            this.FolderImageList.Images.SetKeyName(8, "005-computer.png");
            this.FolderImageList.Images.SetKeyName(9, "005-file.png");
            this.FolderImageList.Images.SetKeyName(10, "006-desktop.png");
            this.FolderImageList.Images.SetKeyName(11, "006-file.png");
            this.FolderImageList.Images.SetKeyName(12, "007-file.png");
            this.FolderImageList.Images.SetKeyName(13, "007-technical-support.png");
            this.FolderImageList.Images.SetKeyName(14, "008-ethernet.png");
            this.FolderImageList.Images.SetKeyName(15, "008-file.png");
            this.FolderImageList.Images.SetKeyName(16, "009-ethernet-1.png");
            this.FolderImageList.Images.SetKeyName(17, "009-file.png");
            this.FolderImageList.Images.SetKeyName(18, "010-file.png");
            this.FolderImageList.Images.SetKeyName(19, "010-harddisk.png");
            this.FolderImageList.Images.SetKeyName(20, "011-file.png");
            this.FolderImageList.Images.SetKeyName(21, "011-harddrive.png");
            this.FolderImageList.Images.SetKeyName(22, "012-file.png");
            this.FolderImageList.Images.SetKeyName(23, "012-keyboard.png");
            this.FolderImageList.Images.SetKeyName(24, "013-file.png");
            this.FolderImageList.Images.SetKeyName(25, "013-laptop.png");
            this.FolderImageList.Images.SetKeyName(26, "014-folder.png");
            this.FolderImageList.Images.SetKeyName(27, "014-master.png");
            this.FolderImageList.Images.SetKeyName(28, "015-folder.png");
            this.FolderImageList.Images.SetKeyName(29, "015-memory.png");
            this.FolderImageList.Images.SetKeyName(30, "016-folder.png");
            this.FolderImageList.Images.SetKeyName(31, "016-monitor.png");
            this.FolderImageList.Images.SetKeyName(32, "017-folder.png");
            this.FolderImageList.Images.SetKeyName(33, "017-motherboard.png");
            this.FolderImageList.Images.SetKeyName(34, "018-folder.png");
            this.FolderImageList.Images.SetKeyName(35, "018-mouse.png");
            this.FolderImageList.Images.SetKeyName(36, "019-folder.png");
            this.FolderImageList.Images.SetKeyName(37, "019-nas.png");
            this.FolderImageList.Images.SetKeyName(38, "020-folder.png");
            this.FolderImageList.Images.SetKeyName(39, "020-network-interface-card.png");
            this.FolderImageList.Images.SetKeyName(40, "021-cloud.png");
            this.FolderImageList.Images.SetKeyName(41, "021-folder.png");
            this.FolderImageList.Images.SetKeyName(42, "022-file.png");
            this.FolderImageList.Images.SetKeyName(43, "022-server.png");
            this.FolderImageList.Images.SetKeyName(44, "023-folder.png");
            this.FolderImageList.Images.SetKeyName(45, "023-pen-tablet.png");
            this.FolderImageList.Images.SetKeyName(46, "024-file.png");
            this.FolderImageList.Images.SetKeyName(47, "024-processor.png");
            this.FolderImageList.Images.SetKeyName(48, "025-file.png");
            this.FolderImageList.Images.SetKeyName(49, "025-server-1.png");
            this.FolderImageList.Images.SetKeyName(50, "026-file.png");
            this.FolderImageList.Images.SetKeyName(51, "026-router.png");
            this.FolderImageList.Images.SetKeyName(52, "027-file.png");
            this.FolderImageList.Images.SetKeyName(53, "027-scanner.png");
            this.FolderImageList.Images.SetKeyName(54, "028-file.png");
            this.FolderImageList.Images.SetKeyName(55, "028-server-2.png");
            this.FolderImageList.Images.SetKeyName(56, "029-file.png");
            this.FolderImageList.Images.SetKeyName(57, "029-server-3.png");
            this.FolderImageList.Images.SetKeyName(58, "030-file.png");
            this.FolderImageList.Images.SetKeyName(59, "030-slave-hard-drive.png");
            this.FolderImageList.Images.SetKeyName(60, "031-file.png");
            this.FolderImageList.Images.SetKeyName(61, "031-ssd.png");
            this.FolderImageList.Images.SetKeyName(62, "032-file.png");
            this.FolderImageList.Images.SetKeyName(63, "032-usb.png");
            this.FolderImageList.Images.SetKeyName(64, "033-file.png");
            this.FolderImageList.Images.SetKeyName(65, "033-usb-1.png");
            this.FolderImageList.Images.SetKeyName(66, "034-file.png");
            this.FolderImageList.Images.SetKeyName(67, "034-vga-card.png");
            this.FolderImageList.Images.SetKeyName(68, "035-file.png");
            this.FolderImageList.Images.SetKeyName(69, "035-webcam.png");
            this.FolderImageList.Images.SetKeyName(70, "036-file.png");
            this.FolderImageList.Images.SetKeyName(71, "036-workstation.png");
            this.FolderImageList.Images.SetKeyName(72, "037-file.png");
            this.FolderImageList.Images.SetKeyName(73, "038-file.png");
            this.FolderImageList.Images.SetKeyName(74, "039-garbage.png");
            this.FolderImageList.Images.SetKeyName(75, "040-file.png");
            this.FolderImageList.Images.SetKeyName(76, "041-file.png");
            this.FolderImageList.Images.SetKeyName(77, "042-file.png");
            this.FolderImageList.Images.SetKeyName(78, "043-file.png");
            this.FolderImageList.Images.SetKeyName(79, "044-file.png");
            this.FolderImageList.Images.SetKeyName(80, "045-file.png");
            this.FolderImageList.Images.SetKeyName(81, "046-file.png");
            this.FolderImageList.Images.SetKeyName(82, "047-file.png");
            this.FolderImageList.Images.SetKeyName(83, "048-file.png");
            this.FolderImageList.Images.SetKeyName(84, "049-file.png");
            this.FolderImageList.Images.SetKeyName(85, "050-file.png");
            this.FolderImageList.Images.SetKeyName(86, "051-file.png");
            // 
            // FilesListView
            // 
            this.FilesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderDateUpdate,
            this.columnHeaderExtansion,
            this.columnHeaderSize});
            this.FilesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilesListView.HideSelection = false;
            this.FilesListView.LargeImageList = this.FilesImageList;
            this.FilesListView.Location = new System.Drawing.Point(0, 6);
            this.FilesListView.Margin = new System.Windows.Forms.Padding(4);
            this.FilesListView.Name = "FilesListView";
            this.FilesListView.Size = new System.Drawing.Size(1042, 824);
            this.FilesListView.SmallImageList = this.FolderImageList;
            this.FilesListView.TabIndex = 0;
            this.FilesListView.UseCompatibleStateImageBehavior = false;
            this.FilesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FilesListView_MouseDoubleClick);
            this.FilesListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FilesListView_MouseUp);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 105;
            // 
            // columnHeaderDateUpdate
            // 
            this.columnHeaderDateUpdate.Text = "Date update";
            this.columnHeaderDateUpdate.Width = 115;
            // 
            // columnHeaderExtansion
            // 
            this.columnHeaderExtansion.Text = "Extension";
            this.columnHeaderExtansion.Width = 72;
            // 
            // columnHeaderSize
            // 
            this.columnHeaderSize.Text = "Size";
            this.columnHeaderSize.Width = 81;
            // 
            // FilesImageList
            // 
            this.FilesImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("FilesImageList.ImageStream")));
            this.FilesImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.FilesImageList.Images.SetKeyName(0, "001-driver.png");
            this.FilesImageList.Images.SetKeyName(1, "001-file.png");
            this.FilesImageList.Images.SetKeyName(2, "002-file.png");
            this.FilesImageList.Images.SetKeyName(3, "002-local-disk.png");
            this.FilesImageList.Images.SetKeyName(4, "003-file.png");
            this.FilesImageList.Images.SetKeyName(5, "003-rom.png");
            this.FilesImageList.Images.SetKeyName(6, "004-cd.png");
            this.FilesImageList.Images.SetKeyName(7, "004-file.png");
            this.FilesImageList.Images.SetKeyName(8, "005-computer.png");
            this.FilesImageList.Images.SetKeyName(9, "005-file.png");
            this.FilesImageList.Images.SetKeyName(10, "006-desktop.png");
            this.FilesImageList.Images.SetKeyName(11, "006-file.png");
            this.FilesImageList.Images.SetKeyName(12, "007-file.png");
            this.FilesImageList.Images.SetKeyName(13, "007-technical-support.png");
            this.FilesImageList.Images.SetKeyName(14, "008-ethernet.png");
            this.FilesImageList.Images.SetKeyName(15, "008-file.png");
            this.FilesImageList.Images.SetKeyName(16, "009-ethernet-1.png");
            this.FilesImageList.Images.SetKeyName(17, "009-file.png");
            this.FilesImageList.Images.SetKeyName(18, "010-file.png");
            this.FilesImageList.Images.SetKeyName(19, "010-harddisk.png");
            this.FilesImageList.Images.SetKeyName(20, "011-file.png");
            this.FilesImageList.Images.SetKeyName(21, "011-harddrive.png");
            this.FilesImageList.Images.SetKeyName(22, "012-file.png");
            this.FilesImageList.Images.SetKeyName(23, "012-keyboard.png");
            this.FilesImageList.Images.SetKeyName(24, "013-file.png");
            this.FilesImageList.Images.SetKeyName(25, "013-laptop.png");
            this.FilesImageList.Images.SetKeyName(26, "014-folder.png");
            this.FilesImageList.Images.SetKeyName(27, "014-master.png");
            this.FilesImageList.Images.SetKeyName(28, "015-folder.png");
            this.FilesImageList.Images.SetKeyName(29, "015-memory.png");
            this.FilesImageList.Images.SetKeyName(30, "016-folder.png");
            this.FilesImageList.Images.SetKeyName(31, "016-monitor.png");
            this.FilesImageList.Images.SetKeyName(32, "017-folder.png");
            this.FilesImageList.Images.SetKeyName(33, "017-motherboard.png");
            this.FilesImageList.Images.SetKeyName(34, "018-folder.png");
            this.FilesImageList.Images.SetKeyName(35, "018-mouse.png");
            this.FilesImageList.Images.SetKeyName(36, "019-folder.png");
            this.FilesImageList.Images.SetKeyName(37, "019-nas.png");
            this.FilesImageList.Images.SetKeyName(38, "020-folder.png");
            this.FilesImageList.Images.SetKeyName(39, "020-network-interface-card.png");
            this.FilesImageList.Images.SetKeyName(40, "021-cloud.png");
            this.FilesImageList.Images.SetKeyName(41, "021-folder.png");
            this.FilesImageList.Images.SetKeyName(42, "022-file.png");
            this.FilesImageList.Images.SetKeyName(43, "022-server.png");
            this.FilesImageList.Images.SetKeyName(44, "023-folder.png");
            this.FilesImageList.Images.SetKeyName(45, "023-pen-tablet.png");
            this.FilesImageList.Images.SetKeyName(46, "024-file.png");
            this.FilesImageList.Images.SetKeyName(47, "024-processor.png");
            this.FilesImageList.Images.SetKeyName(48, "025-file.png");
            this.FilesImageList.Images.SetKeyName(49, "025-server-1.png");
            this.FilesImageList.Images.SetKeyName(50, "026-file.png");
            this.FilesImageList.Images.SetKeyName(51, "026-router.png");
            this.FilesImageList.Images.SetKeyName(52, "027-file.png");
            this.FilesImageList.Images.SetKeyName(53, "027-scanner.png");
            this.FilesImageList.Images.SetKeyName(54, "028-file.png");
            this.FilesImageList.Images.SetKeyName(55, "028-server-2.png");
            this.FilesImageList.Images.SetKeyName(56, "029-file.png");
            this.FilesImageList.Images.SetKeyName(57, "029-server-3.png");
            this.FilesImageList.Images.SetKeyName(58, "030-file.png");
            this.FilesImageList.Images.SetKeyName(59, "030-slave-hard-drive.png");
            this.FilesImageList.Images.SetKeyName(60, "031-file.png");
            this.FilesImageList.Images.SetKeyName(61, "031-ssd.png");
            this.FilesImageList.Images.SetKeyName(62, "032-file.png");
            this.FilesImageList.Images.SetKeyName(63, "032-usb.png");
            this.FilesImageList.Images.SetKeyName(64, "033-file.png");
            this.FilesImageList.Images.SetKeyName(65, "033-usb-1.png");
            this.FilesImageList.Images.SetKeyName(66, "034-file.png");
            this.FilesImageList.Images.SetKeyName(67, "034-vga-card.png");
            this.FilesImageList.Images.SetKeyName(68, "035-file.png");
            this.FilesImageList.Images.SetKeyName(69, "035-webcam.png");
            this.FilesImageList.Images.SetKeyName(70, "036-file.png");
            this.FilesImageList.Images.SetKeyName(71, "036-workstation.png");
            this.FilesImageList.Images.SetKeyName(72, "037-file.png");
            this.FilesImageList.Images.SetKeyName(73, "038-file.png");
            this.FilesImageList.Images.SetKeyName(74, "039-garbage.png");
            this.FilesImageList.Images.SetKeyName(75, "040-file.png");
            this.FilesImageList.Images.SetKeyName(76, "041-file.png");
            this.FilesImageList.Images.SetKeyName(77, "042-file.png");
            this.FilesImageList.Images.SetKeyName(78, "043-file.png");
            this.FilesImageList.Images.SetKeyName(79, "044-file.png");
            this.FilesImageList.Images.SetKeyName(80, "045-file.png");
            this.FilesImageList.Images.SetKeyName(81, "046-file.png");
            this.FilesImageList.Images.SetKeyName(82, "047-file.png");
            this.FilesImageList.Images.SetKeyName(83, "048-file.png");
            this.FilesImageList.Images.SetKeyName(84, "049-file.png");
            this.FilesImageList.Images.SetKeyName(85, "050-file.png");
            this.FilesImageList.Images.SetKeyName(86, "051-file.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DetailModeButton);
            this.panel2.Controls.Add(this.ListModeButton);
            this.panel2.Controls.Add(this.SmallIconModeButton);
            this.panel2.Controls.Add(this.LargeIconModeButton);
            this.panel2.Controls.Add(this.ElementsCountLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 896);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel2.Size = new System.Drawing.Size(1579, 41);
            this.panel2.TabIndex = 2;
            // 
            // DetailModeButton
            // 
            this.DetailModeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.DetailModeButton.Location = new System.Drawing.Point(1200, 6);
            this.DetailModeButton.Margin = new System.Windows.Forms.Padding(4);
            this.DetailModeButton.Name = "DetailModeButton";
            this.DetailModeButton.Size = new System.Drawing.Size(93, 29);
            this.DetailModeButton.TabIndex = 4;
            this.DetailModeButton.Text = "Detail";
            this.DetailModeButton.UseVisualStyleBackColor = true;
            this.DetailModeButton.Click += new System.EventHandler(this.DetailModeButton_Click);
            // 
            // ListModeButton
            // 
            this.ListModeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ListModeButton.Location = new System.Drawing.Point(1293, 6);
            this.ListModeButton.Margin = new System.Windows.Forms.Padding(4);
            this.ListModeButton.Name = "ListModeButton";
            this.ListModeButton.Size = new System.Drawing.Size(93, 29);
            this.ListModeButton.TabIndex = 3;
            this.ListModeButton.Text = "List";
            this.ListModeButton.UseVisualStyleBackColor = true;
            this.ListModeButton.Click += new System.EventHandler(this.ListModeButton_Click);
            // 
            // SmallIconModeButton
            // 
            this.SmallIconModeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SmallIconModeButton.Location = new System.Drawing.Point(1386, 6);
            this.SmallIconModeButton.Margin = new System.Windows.Forms.Padding(4);
            this.SmallIconModeButton.Name = "SmallIconModeButton";
            this.SmallIconModeButton.Size = new System.Drawing.Size(93, 29);
            this.SmallIconModeButton.TabIndex = 2;
            this.SmallIconModeButton.Text = "Small Icon";
            this.SmallIconModeButton.UseVisualStyleBackColor = true;
            this.SmallIconModeButton.Click += new System.EventHandler(this.SmallIconModeButton_Click);
            // 
            // LargeIconModeButton
            // 
            this.LargeIconModeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.LargeIconModeButton.Location = new System.Drawing.Point(1479, 6);
            this.LargeIconModeButton.Margin = new System.Windows.Forms.Padding(4);
            this.LargeIconModeButton.Name = "LargeIconModeButton";
            this.LargeIconModeButton.Size = new System.Drawing.Size(93, 29);
            this.LargeIconModeButton.TabIndex = 1;
            this.LargeIconModeButton.Text = "Large Icon";
            this.LargeIconModeButton.UseVisualStyleBackColor = true;
            this.LargeIconModeButton.Click += new System.EventHandler(this.LargeIconModeButton_Click);
            // 
            // ElementsCountLabel
            // 
            this.ElementsCountLabel.AutoSize = true;
            this.ElementsCountLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ElementsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ElementsCountLabel.Location = new System.Drawing.Point(7, 6);
            this.ElementsCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ElementsCountLabel.Name = "ElementsCountLabel";
            this.ElementsCountLabel.Size = new System.Drawing.Size(115, 25);
            this.ElementsCountLabel.TabIndex = 0;
            this.ElementsCountLabel.Text = "Elements: 0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.MovetoolStripMenuItem1,
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 128);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // MovetoolStripMenuItem1
            // 
            this.MovetoolStripMenuItem1.Name = "MovetoolStripMenuItem1";
            this.MovetoolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.MovetoolStripMenuItem1.Text = "Move";
            this.MovetoolStripMenuItem1.Click += new System.EventHandler(this.MovetoolStripMenuItem1_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createFileToolStripMenuItem,
            this.createFolderToolStripMenuItem,
            this.insertCopyToolStripMenuItem,
            this.insertMoveToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(171, 100);
            // 
            // createFileToolStripMenuItem
            // 
            this.createFileToolStripMenuItem.Name = "createFileToolStripMenuItem";
            this.createFileToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.createFileToolStripMenuItem.Text = "Create file";
            this.createFileToolStripMenuItem.Click += new System.EventHandler(this.createFileToolStripMenuItem_Click);
            // 
            // createFolderToolStripMenuItem
            // 
            this.createFolderToolStripMenuItem.Name = "createFolderToolStripMenuItem";
            this.createFolderToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.createFolderToolStripMenuItem.Text = "Create folder";
            this.createFolderToolStripMenuItem.Click += new System.EventHandler(this.createFolderToolStripMenuItem_Click);
            // 
            // insertCopyToolStripMenuItem
            // 
            this.insertCopyToolStripMenuItem.Name = "insertCopyToolStripMenuItem";
            this.insertCopyToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.insertCopyToolStripMenuItem.Text = "Insert ( Copy )";
            this.insertCopyToolStripMenuItem.Click += new System.EventHandler(this.insertCopyToolStripMenuItem_Click);
            // 
            // insertMoveToolStripMenuItem
            // 
            this.insertMoveToolStripMenuItem.Name = "insertMoveToolStripMenuItem";
            this.insertMoveToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.insertMoveToolStripMenuItem.Text = "Insert (Move )";
            this.insertMoveToolStripMenuItem.Click += new System.EventHandler(this.insertMoveToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 937);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "File explorer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView FoldersTreeView;
        private System.Windows.Forms.ListView FilesListView;
        private System.Windows.Forms.ImageList FolderImageList;
        private System.Windows.Forms.ImageList FilesImageList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ElementsCountLabel;
        private System.Windows.Forms.Button DetailModeButton;
        private System.Windows.Forms.Button ListModeButton;
        private System.Windows.Forms.Button SmallIconModeButton;
        private System.Windows.Forms.Button LargeIconModeButton;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderDateUpdate;
        private System.Windows.Forms.ColumnHeader columnHeaderExtansion;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.Button BackPathButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MovetoolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem createFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertMoveToolStripMenuItem;
    }
}