using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ExpansionTrader_Editor
{
    public class Missions
    {
        public static string SelectedMission { get; private set; }
        public static List<string> types { get; private set; }

        public static void SelectMission()
        {
            List<string> tempMissions = new List<string>();

            foreach (string dir in Directory.GetDirectories(ServerDirectory.MpMissionsFolderPath))
            {
                string missionName = Path.GetFileName(dir);
                tempMissions.Add(missionName);
            }


            MissionSelectorForm selector = new MissionSelectorForm(tempMissions);
            selector.ShowDialog();
            
        }

        public static void SetSelectedMission(string mission)
        {

            if (Directory.Exists(ServerDirectory.MpMissionsFolderPath + "\\" + mission))
            {
                // Do nothing
            }
            else
            {
                MessageBox.Show("Selected mission folder does not exist!");
                Main.ResetAppSettings();
                return;
            }

            File.WriteAllText("SelectedMission.conf", mission);
            SelectedMission = mission;
            LoadMissionData();

        }

        
        public static void LoadMissionData()
        {
            
            // 2. Recursief alle .xml-bestanden ophalen
            IEnumerable<string> xmlFiles = Directory.EnumerateFiles(ServerDirectory.MpMissionsFolderPath + "\\" + SelectedMission,"*.xml", SearchOption.AllDirectories);

            int i = 0;
            List<string> typelist = new List<string>();

            // 3. Voor elk xml-bestand: laad en vind <type>-elementen
            foreach (var file in xmlFiles)
            {
                try
                {
                    XDocument doc = XDocument.Load(file);

                    // Haal alle <type> elementen (ongeacht namespace)
                    var types = doc
                        .Descendants()                     // alle descendants
                        .Where(e => e.Name.LocalName == "type")
                        .Select(e => e.Attribute("name")?.Value)
                        .Where(name => !string.IsNullOrEmpty(name));// filter op null of lege waarden
                 

                    // Als er ten minste één <type> is, tonen we de file en de waarden
                    

                    if (types.Any())
                    {
                        foreach (var t in types)
                        {
                           typelist.Add(t);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading types");
                }
            }

            types = typelist;

            foreach (string type in typelist)
            {
                Main.Instance.Invoke((MethodInvoker)delegate
                {
                    Main.Instance.AddTypesToTypesBox(type);
                });

            }

         


            MessageBox.Show("Loaded " + i.ToString() + " XML files with <type> elements.");


        }

        public static void RepopulateTypes(string filter = "")
        {
            foreach (string type in types)
            {
                
                if (type.ToLower().Contains(filter.ToLower()))
                {
                  

                    // Add to the listbox
                    Main.Instance.Invoke((MethodInvoker)delegate
                    {
                        Main.Instance.AddTypesToTypesBox(type);
                    });
                }
               
               

            }
        }


    }
}
