using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpansionTrader_Editor
{
    public partial class Main : Form
    {


        public static Main Instance { get; private set; }


        public Main()
        {
            Instance = this;
            InitializeComponent();
        }

        private void setServerRootDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {


            StartServerPathSelection();


        }

        private void Main_Load(object sender, EventArgs e)
        {
            ServerDirectory.IsServerDirectorySet();
         
        }

        public void SetApplicationTabViewVisibility(bool isVisible)
        {
            applicationTabView.Visible = isVisible;
        }

        private void StartServerPathSelection()
        {
            ServerDirectory.SetServerDirectory();
            ServerDirectory.ValidateDirectories();
            Missions.SelectMission();
        }

        public void ServerFolderLoadedCallback()
        {

        }

        private void btnSelectServerPath_Click(object sender, EventArgs e)
        {
            StartServerPathSelection();
        }
    }
}
