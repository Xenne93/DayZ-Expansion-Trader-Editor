namespace ExpansionTrader_Editor
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setServerRootDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadJSONWeaponsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.applicationStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.applicationTabView = new System.Windows.Forms.TabControl();
            this.MarketPage = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.marketCategoryListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.traderCategoryDataGrid = new System.Windows.Forms.DataGridView();
            this.overviewPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TradersPage = new System.Windows.Forms.TabPage();
            this.loadServerNotificationGroupbox = new System.Windows.Forms.GroupBox();
            this.btnSelectServerPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.typesBox = new System.Windows.Forms.ListBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.applicationTabView.SuspendLayout();
            this.MarketPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traderCategoryDataGrid)).BeginInit();
            this.overviewPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.loadServerNotificationGroupbox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1620, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setServerRootDirectoryToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // setServerRootDirectoryToolStripMenuItem
            // 
            this.setServerRootDirectoryToolStripMenuItem.Name = "setServerRootDirectoryToolStripMenuItem";
            this.setServerRootDirectoryToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.setServerRootDirectoryToolStripMenuItem.Text = "&Set Server Root Directory";
            this.setServerRootDirectoryToolStripMenuItem.Click += new System.EventHandler(this.setServerRootDirectoryToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadJSONWeaponsToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(40, 19);
            this.testToolStripMenuItem.Text = "&Test";
            // 
            // loadJSONWeaponsToolStripMenuItem
            // 
            this.loadJSONWeaponsToolStripMenuItem.Name = "loadJSONWeaponsToolStripMenuItem";
            this.loadJSONWeaponsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.loadJSONWeaponsToolStripMenuItem.Text = "Load JSON Weapons";
            this.loadJSONWeaponsToolStripMenuItem.Click += new System.EventHandler(this.loadJSONWeaponsToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 836);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1620, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // applicationStatusLabel
            // 
            this.applicationStatusLabel.Name = "applicationStatusLabel";
            this.applicationStatusLabel.Size = new System.Drawing.Size(111, 17);
            this.applicationStatusLabel.Text = "Applicationstatus ...";
            // 
            // applicationTabView
            // 
            this.applicationTabView.Controls.Add(this.MarketPage);
            this.applicationTabView.Controls.Add(this.overviewPage);
            this.applicationTabView.Controls.Add(this.TradersPage);
            this.applicationTabView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applicationTabView.Location = new System.Drawing.Point(0, 25);
            this.applicationTabView.Name = "applicationTabView";
            this.applicationTabView.SelectedIndex = 0;
            this.applicationTabView.Size = new System.Drawing.Size(1620, 811);
            this.applicationTabView.TabIndex = 3;
            // 
            // MarketPage
            // 
            this.MarketPage.Controls.Add(this.panel1);
            this.MarketPage.Controls.Add(this.splitContainer2);
            this.MarketPage.Location = new System.Drawing.Point(4, 29);
            this.MarketPage.Name = "MarketPage";
            this.MarketPage.Padding = new System.Windows.Forms.Padding(3);
            this.MarketPage.Size = new System.Drawing.Size(1612, 778);
            this.MarketPage.TabIndex = 1;
            this.MarketPage.Text = "Market";
            this.MarketPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.marketCategoryListBox);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer2.Panel2.Controls.Add(this.lblCategoryName);
            this.splitContainer2.Panel2.Controls.Add(this.traderCategoryDataGrid);
            this.splitContainer2.Size = new System.Drawing.Size(1606, 772);
            this.splitContainer2.SplitterDistance = 302;
            this.splitContainer2.TabIndex = 0;
            // 
            // marketCategoryListBox
            // 
            this.marketCategoryListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marketCategoryListBox.FormattingEnabled = true;
            this.marketCategoryListBox.ItemHeight = 20;
            this.marketCategoryListBox.Location = new System.Drawing.Point(0, 34);
            this.marketCategoryListBox.Name = "marketCategoryListBox";
            this.marketCategoryListBox.Size = new System.Drawing.Size(302, 738);
            this.marketCategoryListBox.TabIndex = 0;
            this.marketCategoryListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SelectMarketCategory);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.label2.Size = new System.Drawing.Size(139, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Market Categories";
            // 
            // traderCategoryDataGrid
            // 
            this.traderCategoryDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.traderCategoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.traderCategoryDataGrid.Location = new System.Drawing.Point(3, 80);
            this.traderCategoryDataGrid.Name = "traderCategoryDataGrid";
            this.traderCategoryDataGrid.RowTemplate.Height = 28;
            this.traderCategoryDataGrid.Size = new System.Drawing.Size(1004, 689);
            this.traderCategoryDataGrid.TabIndex = 0;
            // 
            // overviewPage
            // 
            this.overviewPage.Controls.Add(this.splitContainer1);
            this.overviewPage.Location = new System.Drawing.Point(4, 29);
            this.overviewPage.Name = "overviewPage";
            this.overviewPage.Padding = new System.Windows.Forms.Padding(3);
            this.overviewPage.Size = new System.Drawing.Size(1655, 662);
            this.overviewPage.TabIndex = 0;
            this.overviewPage.Text = "Overview";
            this.overviewPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(1649, 656);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 0;
            // 
            // TradersPage
            // 
            this.TradersPage.Location = new System.Drawing.Point(4, 29);
            this.TradersPage.Name = "TradersPage";
            this.TradersPage.Size = new System.Drawing.Size(1446, 554);
            this.TradersPage.TabIndex = 2;
            this.TradersPage.Text = "Traders";
            this.TradersPage.UseVisualStyleBackColor = true;
            // 
            // loadServerNotificationGroupbox
            // 
            this.loadServerNotificationGroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.loadServerNotificationGroupbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadServerNotificationGroupbox.Controls.Add(this.btnSelectServerPath);
            this.loadServerNotificationGroupbox.Controls.Add(this.label1);
            this.loadServerNotificationGroupbox.Location = new System.Drawing.Point(454, 173);
            this.loadServerNotificationGroupbox.MaximumSize = new System.Drawing.Size(775, 249);
            this.loadServerNotificationGroupbox.MinimumSize = new System.Drawing.Size(775, 249);
            this.loadServerNotificationGroupbox.Name = "loadServerNotificationGroupbox";
            this.loadServerNotificationGroupbox.Size = new System.Drawing.Size(775, 249);
            this.loadServerNotificationGroupbox.TabIndex = 7;
            this.loadServerNotificationGroupbox.TabStop = false;
            this.loadServerNotificationGroupbox.Text = "Load your serverfolder";
            this.loadServerNotificationGroupbox.Visible = false;
            // 
            // btnSelectServerPath
            // 
            this.btnSelectServerPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectServerPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectServerPath.Location = new System.Drawing.Point(148, 165);
            this.btnSelectServerPath.Name = "btnSelectServerPath";
            this.btnSelectServerPath.Size = new System.Drawing.Size(476, 37);
            this.btnSelectServerPath.TabIndex = 5;
            this.btnSelectServerPath.Text = "Select Server Folder";
            this.btnSelectServerPath.UseVisualStyleBackColor = true;
            this.btnSelectServerPath.Click += new System.EventHandler(this.btnSelectServerPath_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(85, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Before you can use the editor you need to load your DayZ server folder.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1322, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 772);
            this.panel1.TabIndex = 1;
            // 
            // typesBox
            // 
            this.typesBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typesBox.FormattingEnabled = true;
            this.typesBox.ItemHeight = 20;
            this.typesBox.Location = new System.Drawing.Point(0, 0);
            this.typesBox.Name = "typesBox";
            this.typesBox.Size = new System.Drawing.Size(287, 675);
            this.typesBox.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.textBox1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.typesBox);
            this.splitContainer3.Size = new System.Drawing.Size(287, 772);
            this.splitContainer3.SplitterDistance = 93;
            this.splitContainer3.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.Location = new System.Drawing.Point(3, 34);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(252, 31);
            this.lblCategoryName.TabIndex = 1;
            this.lblCategoryName.Text = "No Market Selected";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1300, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 858);
            this.Controls.Add(this.applicationTabView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.loadServerNotificationGroupbox);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1232, 673);
            this.Name = "Main";
            this.Text = "DayZ Expansion Trader Editor";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.applicationTabView.ResumeLayout(false);
            this.MarketPage.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.traderCategoryDataGrid)).EndInit();
            this.overviewPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.loadServerNotificationGroupbox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setServerRootDirectoryToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel applicationStatusLabel;
        private System.Windows.Forms.TabControl applicationTabView;
        private System.Windows.Forms.TabPage overviewPage;
        private System.Windows.Forms.TabPage MarketPage;
        private System.Windows.Forms.GroupBox loadServerNotificationGroupbox;
        private System.Windows.Forms.Button btnSelectServerPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage TradersPage;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox marketCategoryListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView traderCategoryDataGrid;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadJSONWeaponsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox typesBox;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

