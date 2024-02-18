namespace _11_tree_list_view
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TreeNode treeNode1 = new TreeNode("Personal");
            TreeNode treeNode2 = new TreeNode("Work");
            TreeNode treeNode3 = new TreeNode("Documents", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("Downloads");
            TreeNode treeNode5 = new TreeNode("Pictures");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ListViewItem listViewItem1 = new ListViewItem("reghrae ghiaurhuae");
            ListViewItem listViewItem2 = new ListViewItem("aergaregar aerga");
            ListViewItem listViewItem3 = new ListViewItem("vkbreuilgherkn r");
            ListViewItem listViewItem4 = new ListViewItem("ergaer");
            treeView1 = new TreeView();
            imageList1 = new ImageList(components);
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripLabel1 = new ToolStripLabel();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            detailsToolStripMenuItem = new ToolStripMenuItem();
            tileToolStripMenuItem = new ToolStripMenuItem();
            largeIconsToolStripMenuItem = new ToolStripMenuItem();
            smallIconsToolStripMenuItem = new ToolStripMenuItem();
            listToolStripMenuItem = new ToolStripMenuItem();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            imageList2 = new ImageList(components);
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.ImageIndex = 0;
            treeView1.ImageList = imageList1;
            treeView1.Location = new Point(12, 58);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Node4";
            treeNode1.Text = "Personal";
            treeNode2.Name = "Node5";
            treeNode2.Text = "Work";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Documents";
            treeNode4.Name = "Node2";
            treeNode4.Text = "Downloads";
            treeNode5.Name = "Node3";
            treeNode5.Text = "Pictures";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode3, treeNode4, treeNode5 });
            treeView1.SelectedImageIndex = 0;
            treeView1.Size = new Size(623, 901);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "folder (1).png");
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripProgressBar1, toolStripLabel1, toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1881, 42);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(46, 36);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 36);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(173, 36);
            toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { detailsToolStripMenuItem, tileToolStripMenuItem, largeIconsToolStripMenuItem, smallIconsToolStripMenuItem, listToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(119, 36);
            toolStripDropDownButton1.Text = "View";
            // 
            // detailsToolStripMenuItem
            // 
            detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            detailsToolStripMenuItem.Size = new Size(267, 44);
            detailsToolStripMenuItem.Text = "Details";
            // 
            // tileToolStripMenuItem
            // 
            tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            tileToolStripMenuItem.Size = new Size(267, 44);
            tileToolStripMenuItem.Text = "Tile";
            // 
            // largeIconsToolStripMenuItem
            // 
            largeIconsToolStripMenuItem.Name = "largeIconsToolStripMenuItem";
            largeIconsToolStripMenuItem.Size = new Size(267, 44);
            largeIconsToolStripMenuItem.Text = "Large Icons";
            // 
            // smallIconsToolStripMenuItem
            // 
            smallIconsToolStripMenuItem.Name = "smallIconsToolStripMenuItem";
            smallIconsToolStripMenuItem.Size = new Size(267, 44);
            smallIconsToolStripMenuItem.Text = "Small Icons";
            // 
            // listToolStripMenuItem
            // 
            listToolStripMenuItem.Name = "listToolStripMenuItem";
            listToolStripMenuItem.Size = new Size(267, 44);
            listToolStripMenuItem.Text = "List";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4 });
            listView1.LargeImageList = imageList2;
            listView1.Location = new Point(662, 58);
            listView1.Name = "listView1";
            listView1.Size = new Size(1207, 901);
            listView1.SmallImageList = imageList2;
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 500;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Type";
            columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Size";
            columnHeader3.Width = 300;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth8Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "icons8-document-96.png");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1881, 971);
            Controls.Add(listView1);
            Controls.Add(toolStrip1);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private ImageList imageList1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripLabel toolStripLabel1;
        private ListView listView1;
        private ImageList imageList2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem detailsToolStripMenuItem;
        private ToolStripMenuItem tileToolStripMenuItem;
        private ToolStripMenuItem largeIconsToolStripMenuItem;
        private ToolStripMenuItem smallIconsToolStripMenuItem;
        private ToolStripMenuItem listToolStripMenuItem;
    }
}