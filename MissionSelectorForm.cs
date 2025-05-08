using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExpansionTrader_Editor
{
    public partial class MissionSelectorForm : Form
    {
        public List<string> missionsList { get; set; }

        public MissionSelectorForm(List<string> missions)
        {
            missionsList = missions;

            InitializeComponent();

        }

        private void MissionSelector_Load(object sender, EventArgs e)
        {
           foreach (string mission in missionsList) {

                missionComboBox.Items.Add(mission);

           }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Directory.Exists(ServerDirectory.MpMissionsFolderPath + "\\" + missionComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("Mission exist!");
            }
            else
            {
                MessageBox.Show("Selected mission folder does not exist!");
                return;
            }

            Missions.SetSelectedMission(missionComboBox.SelectedItem.ToString());
            

        }
    }
}
