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





        public Main()
        {
            InitializeComponent();
        }

        private void setServerRootDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ServerDirectory.SetServerDirectory();
            ServerDirectory.ValidateDirectories();

            Missions.SelectMission();
           


           




        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
