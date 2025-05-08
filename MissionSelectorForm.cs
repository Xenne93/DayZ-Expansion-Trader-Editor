using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpansionTrader_Editor
{
    public partial class MissionSelectorForm : Form
    {
        public List<string> Missions { get; set; }

        public MissionSelectorForm(List<string> missions)
        {
            Missions = missions;

            InitializeComponent();

        }

        private void MissionSelector_Load(object sender, EventArgs e)
        {
           foreach (string mission in Missions) {

                missionComboBox.Items.Add(mission);

           }

        }



    }
}
