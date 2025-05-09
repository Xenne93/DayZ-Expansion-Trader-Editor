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
using ExpansionTrader_Editor.DataModels;
using Newtonsoft.Json;

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

            if (File.Exists("PathSettings.conf"))
            {
           
                string serverPathFromConfig = File.ReadAllText("PathSettings.conf");
                ServerDirectory.SetServerDirectory(serverPathFromConfig);

                if (File.Exists("SelectedMission.conf"))
                {
                    string selectedMission = File.ReadAllText("SelectedMission.conf");
                    Missions.SetSelectedMission(selectedMission);
                    MessageBox.Show("Selected mission: " + selectedMission);
                }

            }
            else
            {
                applicationTabView.Visible = false;
                loadServerNotificationGroupbox.Visible = true;

                return;
            }


        }

        public void SetApplicationTabViewVisibility(bool isVisible)
        {
            applicationTabView.Visible = isVisible;
        }

        private void StartServerPathSelection()
        {
            ServerDirectory.SetServerDirectoryViaDialog();
            Missions.SelectMission();
        }

        public void ServerFolderLoadedCallback()
        {
            loadServerNotificationGroupbox.Visible = false;
            applicationTabView.Visible = true;
            applicationStatusLabel.Text = "Working Directory: " + ServerDirectory.ServerRootDirectoryPath;
            MarketTab.Initialize();
            MarketTab.instance.LoadCategories();


        }

        private void btnSelectServerPath_Click(object sender, EventArgs e)
        {
            StartServerPathSelection();
        }

        private void loadJSONWeaponsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }


        public void AddMarketCategory (string category)
        {
            marketCategoryListBox.Items.Add(category);
        }

        public void AddTypesToTypesBox(string type)
        {
            typesBox.Items.Add(type);
        }

        public void ResetTypesBox()
        {
            typesBox.Items.Clear();
            
        }

        private void SelectMarketCategory(object sender, MouseEventArgs e)
        {
            MarketCategory cat = MarketTab.instance.GetCategory(marketCategoryListBox.SelectedItem.ToString());
            
            // Add headers to the datagri
            traderCategoryDataGrid.Columns.Clear();
            traderCategoryDataGrid.Rows.Clear();
            traderCategoryDataGrid.Columns.Add("ClassName", "Item");
            traderCategoryDataGrid.Columns.Add("MaxPriceThreshold", "Price");
            traderCategoryDataGrid.Columns.Add("MinPriceThreshold", "Price");
            traderCategoryDataGrid.Columns.Add("SellPricePercent", "Price");
            traderCategoryDataGrid.Columns.Add("MaxStockThreshold", "Price");
            traderCategoryDataGrid.Columns.Add("MinStockThreshold", "Price");
            traderCategoryDataGrid.Columns.Add("QuantityPercent", "Price");
            traderCategoryDataGrid.Columns.Add("SpawnAttachments", "Price");
            traderCategoryDataGrid.Columns.Add("Variants", "Price");

            // add rows to the datagrid
            foreach (MarketObject obj in cat.Items)
            {
                traderCategoryDataGrid.Rows.Add(obj.ClassName, obj.MaxPriceThreshold, obj.MinPriceThreshold, obj.SellPricePercent, obj.MaxStockThreshold, obj.MinStockThreshold, obj.QuantityPercent, string.Join(", ", obj.SpawnAttachments), string.Join(", ", obj.Variants));
            }

            lblCategoryName.Text = marketCategoryListBox.SelectedItem.ToString();









        }



        public static void ResetAppSettings()
        {
            File.Delete("PathSettings.conf");
            File.Delete("SelectedMission.conf");
            ServerDirectory.SetServerDirectory(string.Empty);
            Missions.SetSelectedMission(string.Empty);
            Instance.applicationTabView.Visible = false;
            Instance.loadServerNotificationGroupbox.Visible = true;
            Instance.applicationStatusLabel.Text = "Working Directory: ";
            Application.Restart();
        }

        private void OnFilterTextChanged(object sender, EventArgs e)
        {

           
                typesBox.Items.Clear();
                Missions.RepopulateTypes(filterTxtBox.Text);
            
           

        }
    }
}
