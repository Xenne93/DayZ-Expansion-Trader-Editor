using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpansionTrader_Editor.DataModels;
using Newtonsoft.Json;

namespace ExpansionTrader_Editor
{
    public class MarketTab
    {


        public static MarketTab instance;

        public List<string> MarketFiles { get; set; } = new List<string>();
        public Dictionary<string, MarketCategory> MarketCategories = new Dictionary<string, MarketCategory>();

        public static void Initialize()
        {

            instance = new MarketTab();


        }

        public MarketCategory GetCategory(string category)
        {
            MarketCategory marketCategory = MarketCategories[category];

            return marketCategory;

        }

        public void LoadCategories()
        {
            foreach (string file in Directory.GetFiles(ServerDirectory.ProfilesFolderPath + "\\ExpansionMod\\Market\\"))
            {

                // Add filename to list

                string fileName = Path.GetFileName(file);



                // Add dictionary entries

                string json = File.ReadAllText(file);
                MarketCategory marketCategory = JsonConvert.DeserializeObject<MarketCategory>(json);
                MarketCategories.Add(fileName, marketCategory);

                Main.Instance.Invoke((MethodInvoker)delegate
                {
                    Main.Instance.AddMarketCategory(fileName);
                });

            }


        }

    }


}
