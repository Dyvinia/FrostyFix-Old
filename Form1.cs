using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;



namespace FrostyFix {
    public partial class Form1 : Form {
        string bf2015;
        string bf2017;
        string mea;
        string bf1;
        string nfs;
        string nfsheat;
        string datadir;


        public Form1() {
            InitializeComponent();
        }

        private void btn_enable_Click(object sender, EventArgs e) {
            Environment.SetEnvironmentVariable("GAME_DATA_DIR", datadir + "\\ModData", EnvironmentVariableTarget.User);
            var isenabled = Environment.GetEnvironmentVariable("GAME_DATA_DIR", EnvironmentVariableTarget.User);
            if (isenabled != null) {
                lbl_enabled.Text = "Mods are Currently Enabled";
                lbl_enabled.ForeColor = Color.LightGreen;
            }
            else {
                lbl_enabled.Text = "Mods are Currently NOT Enabled";
                lbl_enabled.ForeColor = Color.LightSalmon;
            }
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btn_disable_Click(object sender, EventArgs e) {
            Environment.SetEnvironmentVariable("GAME_DATA_DIR", "", EnvironmentVariableTarget.User);
            var isenabled = Environment.GetEnvironmentVariable("GAME_DATA_DIR", EnvironmentVariableTarget.User);
            if (isenabled != null) {
                lbl_enabled.Text = "Mods are Currently Enabled";
                lbl_enabled.ForeColor = Color.LightGreen;
            }
            else {
                lbl_enabled.Text = "Mods are Currently NOT Enabled";
                lbl_enabled.ForeColor = Color.LightSalmon;
            }
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e) {

            var isenabled = Environment.GetEnvironmentVariable("GAME_DATA_DIR", EnvironmentVariableTarget.User);
            if (isenabled != null) {
                lbl_enabled.Text = "Mods are Currently Enabled";
                lbl_enabled.ForeColor = Color.LightGreen;
            }
            else {
                lbl_enabled.Text = "Mods are Currently NOT Enabled";
                lbl_enabled.ForeColor = Color.LightSalmon;
            }

            using (RegistryKey bf2015key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\EA Games\STAR WARS Battlefront"))
                if (bf2015key != null) {
                    bf2015 = (string)bf2015key.GetValue("Install Dir");
                    rbtn_bf2015.Enabled = true;
                }
                else {
                    rbtn_bf2015.Enabled = false;
                }

            using (RegistryKey bf2017key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\EA Games\STAR WARS Battlefront II"))
                if (bf2017key != null) {
                    bf2017 = (string)bf2017key.GetValue("Install Dir");
                    rbtn_bf2017.Enabled = true;
                }
                else {
                    rbtn_bf2017.Enabled = false;
                }

            using (RegistryKey meakey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\BioWare\Mass Effect Andromeda"))
                if (meakey != null) {
                    mea = (string)meakey.GetValue("Install Dir");
                    rbtn_mea.Enabled = true;
                }
                else {
                    rbtn_mea.Enabled = false;
                }

            using (RegistryKey bf1key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\EA Games\Battlefield 1"))
                if (bf1key != null) {
                    bf1 = (string)bf1key.GetValue("Install Dir");
                    rbtn_bf1.Enabled = true;
                }
                else {
                    rbtn_bf1.Enabled = false;
                }

            using (RegistryKey nfskey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\EA Games\Need for Speed"))
                if (nfskey != null) {
                    nfs = (string)nfskey.GetValue("Install Dir");
                    rbtn_nfs.Enabled = true;
                }
                else {
                    rbtn_nfs.Enabled = false;
                }

            using (RegistryKey nfsheatkey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\EA Games\Need for Speed Heat"))
                if (nfsheatkey != null) {
                    nfsheat = (string)nfsheatkey.GetValue("Install Dir");
                    rbtn_nfsheat.Enabled = true;
                }
                else {
                    rbtn_nfsheat.Enabled = false;
                }

        }

        private void rbtn_bf2015_CheckedChanged(object sender, EventArgs e) {
            datadir = bf2015;
            btn_enable.Enabled = true;
            btn_disable.Enabled = true;
        }

        private void rbtn_bf2017_CheckedChanged(object sender, EventArgs e) {
            datadir = bf2017;
            btn_enable.Enabled = true;
            btn_disable.Enabled = true;
        }

        private void rbtn_mea_CheckedChanged(object sender, EventArgs e) {
            datadir = mea;
            btn_enable.Enabled = true;
            btn_disable.Enabled = true;
        }

        private void rbtn_bf1_CheckedChanged(object sender, EventArgs e) {
            datadir = bf1;
            btn_enable.Enabled = true;
            btn_disable.Enabled = true;
        }

        private void rbtn_nfs_CheckedChanged(object sender, EventArgs e) {
            datadir = nfs;
            btn_enable.Enabled = true;
            btn_disable.Enabled = true;
        }

        private void rbtn_nfsheat_CheckedChanged(object sender, EventArgs e) {
            datadir = nfsheat;
            btn_enable.Enabled = true;
            btn_disable.Enabled = true;
        }

        private void rbtn_custom_CheckedChanged(object sender, EventArgs e) {
        }

        private void btn_customchoose_Click(object sender, EventArgs e) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Executable files (*.exe)|*.exe";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    datadir = Path.GetDirectoryName(openFileDialog.FileName);
                    txtb_custompath.Text = datadir;
                }
            }
        }

        private void btn_info_Click(object sender, EventArgs e) {
            string message = "FrostyFix v1.1.0 for Epic Games Store, Steam, and EA Desktop\r\nCreated by Dulana57, based off the batch file by VictorPLopes and BattleDash\r\n\r\nIt is recommended to launch the game with Frosty after forcing mods.\r\nIt works directly from Origin/EA Desktop but it's better to launch the Game from Frosty Mod Manager/Editor to guarantee everything is working fine and to refresh your mod list.\r\nYou must run this program again every time you want to play another Battlefront game, so you can either disable mods or select the other game.\r\nYou must disable this whenever you play any other Frostbite game or if you encounter issues with other games.\r\nIt may help to restart your computer after running this program.\r\n\r\nFor more information about this fix and/or support, join the Battlefront Modding Discord server at https://discord.gg/EzXSJfUDmq";
            string title = "Info";
            MessageBox.Show(message, title);
        }

        private void btn_github_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/Dulana57/FrostyFix");
        }
    }
}


