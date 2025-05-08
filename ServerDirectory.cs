using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpansionTrader_Editor
{
    public class ServerDirectory
    {

        public static string ServerRootDirectoryPath { get; private set; }
        public static string ProfilesFolderPath { get; private set; }
        public static string MpMissionsFolderPath { get; private set; }
        public static string SelectedMissionFolderPath { get; private set; }

        public static void SetServerDirectoryViaDialog()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();

            SetServerDirectory(folderBrowserDialog.SelectedPath);

        }


        public static void SetServerDirectory(string serverPath)
        {
            ServerRootDirectoryPath = serverPath;
            ProfilesFolderPath = ServerRootDirectoryPath + "\\profiles\\";
            MpMissionsFolderPath = ServerRootDirectoryPath + "\\mpmissions\\";
            MessageBox.Show(ProfilesFolderPath);
            ValidateDirectories();
        }

        public static void IsServerDirectorySet()
        {
            if (string.IsNullOrEmpty(ServerRootDirectoryPath))
            {
                Main.Instance.Invoke((MethodInvoker)delegate
                {
                    Main.Instance.SetApplicationTabViewVisibility(false);
                });
            }
        }

        public static void ValidateDirectories()
        {
           



            if (!Directory.Exists(ServerRootDirectoryPath))
            {
                MessageBox.Show("Server folder does not exist!");
                return;
            }

            if (!Directory.Exists(ProfilesFolderPath))
            {
                MessageBox.Show("Profiles folder not found!");
                return;
            }

            if (!Directory.Exists(MpMissionsFolderPath))
            {
                MessageBox.Show("MpmMissions folder not found!");
                return;
            }

            
            File.WriteAllText("PathSettings.conf", ServerRootDirectoryPath);
     
            Main.Instance.ServerFolderLoadedCallback();



        }


    }
}
