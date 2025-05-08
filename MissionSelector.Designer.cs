namespace ExpansionTrader_Editor
{
    partial class MissionSelector
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
            this.missionComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // missionComboBox
            // 
            this.missionComboBox.FormattingEnabled = true;
            this.missionComboBox.Location = new System.Drawing.Point(264, 121);
            this.missionComboBox.Name = "missionComboBox";
            this.missionComboBox.Size = new System.Drawing.Size(264, 21);
            this.missionComboBox.TabIndex = 0;
            // 
            // MissionSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.missionComboBox);
            this.Name = "MissionSelector";
            this.Text = "MissionSelector";
            this.Load += new System.EventHandler(this.MissionSelector_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox missionComboBox;
    }
}