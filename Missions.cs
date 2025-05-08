using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpansionTrader_Editor
{
    public class Missions
    {
        public static string SelectedMission { get; private set; }

        public static void SelectMission()
        {
            List<string> tempMissions = new List<string>();

            foreach (string dir in Directory.GetDirectories(ServerDirectory.MpMissionsFolderPath))
            {
                tempMissions.Add(dir);
            }


            MissionSelectorForm selector = new MissionSelectorForm(tempMissions);
            selector.Show();

        }

       
    }
}
