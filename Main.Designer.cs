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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.applicationStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.applicationTabView = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.loadServerNotificationGroupbox = new System.Windows.Forms.GroupBox();
            this.btnSelectServerPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.applicationTabView.SuspendLayout();
            this.loadServerNotificationGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1454, 25);
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 612);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1454, 22);
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
            this.applicationTabView.Controls.Add(this.tabPage1);
            this.applicationTabView.Controls.Add(this.tabPage2);
            this.applicationTabView.Dock = System.Windows.Forms.DockStyle.Top;
            this.applicationTabView.Location = new System.Drawing.Point(0, 25);
            this.applicationTabView.Name = "applicationTabView";
            this.applicationTabView.SelectedIndex = 0;
            this.applicationTabView.Size = new System.Drawing.Size(1454, 100);
            this.applicationTabView.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1446, 67);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1183, 67);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // loadServerNotificationGroupbox
            // 
            this.loadServerNotificationGroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.loadServerNotificationGroupbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadServerNotificationGroupbox.Controls.Add(this.btnSelectServerPath);
            this.loadServerNotificationGroupbox.Controls.Add(this.label1);
            this.loadServerNotificationGroupbox.Location = new System.Drawing.Point(340, 193);
            this.loadServerNotificationGroupbox.MaximumSize = new System.Drawing.Size(775, 249);
            this.loadServerNotificationGroupbox.MinimumSize = new System.Drawing.Size(775, 249);
            this.loadServerNotificationGroupbox.Name = "loadServerNotificationGroupbox";
            this.loadServerNotificationGroupbox.Size = new System.Drawing.Size(775, 249);
            this.loadServerNotificationGroupbox.TabIndex = 7;
            this.loadServerNotificationGroupbox.TabStop = false;
            this.loadServerNotificationGroupbox.Text = "Load your serverfolder";
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 634);
            this.Controls.Add(this.loadServerNotificationGroupbox);
            this.Controls.Add(this.applicationTabView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
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
            this.loadServerNotificationGroupbox.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox loadServerNotificationGroupbox;
        private System.Windows.Forms.Button btnSelectServerPath;
        private System.Windows.Forms.Label label1;
    }
}

