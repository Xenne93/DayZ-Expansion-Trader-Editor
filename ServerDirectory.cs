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

        public static void SetServerDirectory()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();

            ServerRootDirectoryPath = folderBrowserDialog.SelectedPath;
            ProfilesFolderPath = ServerRootDirectoryPath + "\\profiles\\";
            MpMissionsFolderPath = ServerRootDirectoryPath + "\\mpmissions\\";
            MessageBox.Show(ProfilesFolderPath);

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


        }


    }
}
