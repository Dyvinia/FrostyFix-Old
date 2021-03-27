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
        string nfspayback;
        string nfsheat;
        string gw2;
        string dai;
        string datadir;


        public Form1() {
            InitializeComponent();
        }

        private void btn_enable_Click(object sender, EventArgs e) {
            Environment.SetEnvironmentVariable("GAME_DATA_DIR", datadir + "\\ModData", EnvironmentVariableTarget.User);
            
            //Recheck patch status
            var isenabled = Environment.GetEnvironmentVariable("GAME_DATA_DIR", EnvironmentVariableTarget.User);
            if (isenabled == "\\ModData") {
                lbl_enabled.Text = "Registry Key is Currently Broken";
                lbl_enabled.ForeColor = Color.Orange;
            }
            else if (isenabled != null) {
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
            
            //Recheck patch status
            var isenabled = Environment.GetEnvironmentVariable("GAME_DATA_DIR", EnvironmentVariableTarget.User);
            if (isenabled == "\\ModData") {
                lbl_enabled.Text = "Registry Key is Currently Broken";
                lbl_enabled.ForeColor = Color.Orange;
            }
            else if (isenabled != null) {
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

            //Check patch status
            var isenabled = Environment.GetEnvironmentVariable("GAME_DATA_DIR", EnvironmentVariableTarget.User);
            if (isenabled == "\\ModData") {
                lbl_enabled.Text = "Registry Key is Currently Broken";
                lbl_enabled.ForeColor = Color.Orange;
            }
            else if (isenabled != null) {
                lbl_enabled.Text = "Mods are Currently Enabled";
                lbl_enabled.ForeColor = Color.LightGreen;
            }
            else {
                lbl_enabled.Text = "Mods are Currently NOT Enabled";
                lbl_enabled.ForeColor = Color.LightSalmon;
            }

            //Get Paths using Registry
            using (RegistryKey bf2015key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\EA Games\STAR WARS Battlefront"))
                if (bf2015key != null) {
                    bf2015 = (string)bf2015key.GetValue("Install Dir");
                    rbtn_bf2015.Enabled = true;
                }
                else {
                    rbtn_bf2015.AutoCheck = false;
                    rbtn_bf2015.ForeColor = System.Drawing.Color.FromArgb(1, 127, 127, 127);
                }

            using (RegistryKey bf2017key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\EA Games\STAR WARS Battlefront II"))
                if (bf2017key != null) {
                    bf2017 = (string)bf2017key.GetValue("Install Dir");
                    rbtn_bf2017.Enabled = true;
                }
                else {
                    rbtn_bf2017.AutoCheck = false;
                    rbtn_bf2017.ForeColor = System.Drawing.Color.FromArgb(1, 127, 127, 127);
                }

            using (RegistryKey meakey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\BioWare\Mass Effect Andromeda"))
                if (meakey != null) {
                    mea = (string)meakey.GetValue("Install Dir");
                    rbtn_mea.Enabled = true;
                }
                else {
                    rbtn_mea.AutoCheck = false;
                    rbtn_mea.ForeColor = System.Drawing.Color.FromArgb(1, 127, 127, 127);
                }

            using (RegistryKey bf1key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\EA Games\Battlefield 1"))
                if (bf1key != null) {
                    bf1 = (string)bf1key.GetValue("Install Dir");
                    rbtn_bf1.Enabled = true;
                }
                else {
                    rbtn_bf1.AutoCheck = false;
                    rbtn_bf1.ForeColor = System.Drawing.Color.FromArgb(1, 127, 127, 127);
                }

            using (RegistryKey nfskey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\EA Games\Need for Speed"))
                if (nfskey != null) {
                    nfs = (string)nfskey.GetValue("Install Dir");
                    rbtn_nfs.Enabled = true;
                }
                else {
                    rbtn_nfs.AutoCheck = false;
                    rbtn_nfs.ForeColor = System.Drawing.Color.FromArgb(1, 127, 127, 127);
                }

            using (RegistryKey nfspaybackkey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\EA Games\Need for Speed Payback"))
                if (nfspaybackkey != null) {
                    nfspayback = (string)nfspaybackkey.GetValue("Install Dir");
                    rbtn_nfspayback.Enabled = true;
                }
                else {
                    rbtn_nfspayback.AutoCheck = false;
                    rbtn_nfspayback.ForeColor = System.Drawing.Color.FromArgb(1, 127, 127, 127);
                }

            using (RegistryKey nfsheatkey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\EA Games\Need for Speed Heat"))
                if (nfsheatkey != null) {
                    nfsheat = (string)nfsheatkey.GetValue("Install Dir");
                    rbtn_nfsheat.Enabled = true;
                }
                else {
                    rbtn_nfsheat.AutoCheck = false;
                    rbtn_nfsheat.ForeColor = System.Drawing.Color.FromArgb(1, 127, 127, 127);
                }

            using (RegistryKey gw2key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\PopCap\Plants vs Zombies GW2"))
                if (gw2key != null) {
                    gw2 = (string)gw2key.GetValue("Install Dir");
                    rbtn_gw2.Enabled = true;
                }
                else {
                    rbtn_gw2.AutoCheck = false;
                    rbtn_gw2.ForeColor = System.Drawing.Color.FromArgb(1, 127, 127, 127);
                }

            using (RegistryKey daikey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Bioware\Dragon Age Inquisition"))
                if (daikey != null) {
                    dai = (string)daikey.GetValue("Install Dir");
                    rbtn_dai.Enabled = true;
                }
                else {
                    rbtn_dai.AutoCheck = false;
                    rbtn_dai.ForeColor = System.Drawing.Color.FromArgb(1, 127, 127, 127);
                }

        }

        //Choose Game
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

        private void rbtn_nfspayback_CheckedChanged(object sender, EventArgs e) {
            datadir = nfspayback;
            btn_enable.Enabled = true;
            btn_disable.Enabled = true;
        }

        private void rbtn_nfsheat_CheckedChanged(object sender, EventArgs e) {
            datadir = nfsheat;
            btn_enable.Enabled = true;
            btn_disable.Enabled = true;
        }

        private void rbtn_gw2_CheckedChanged(object sender, EventArgs e) {
            datadir = gw2;
            btn_enable.Enabled = true;
            btn_disable.Enabled = true;
        }

        private void rbtn_dai_CheckedChanged(object sender, EventArgs e) {
            datadir = dai;
            btn_enable.Enabled = true;
            btn_disable.Enabled = true;
        }

        //Choose custom path using game executable
        private void btn_customchoose_Click(object sender, EventArgs e) {
            btn_enable.Enabled = true;
            btn_disable.Enabled = true;
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Game executable (*.exe)|*.exe";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    datadir = Path.GetDirectoryName(openFileDialog.FileName);
                    txtb_custompath.Text = datadir;
                }
            }
        }

        private void btn_info_Click(object sender, EventArgs e) {
            string message = "FrostyFix v1.2.3 for Epic Games Store, Steam, and EA Desktop\r\nCreated by Dulana57, based off the batch file by VictorPLopes, BattleDash & Dulana57\r\n\r\nClick the GitHub button to see an FAQ, Software updates, support channels and more\r\n\r\nIt is recommended to launch the game with Frosty after forcing mods.\r\nIt works directly from Origin/EA Desktop but it's better to launch the Game from Frosty Mod Manager/Editor to guarantee everything is working fine and to refresh your mod list.\r\nYou must run this program again every time you want to play another Battlefront game, so you can either disable mods or select the other game.\r\nYou must disable this whenever you play any other Frostbite game or if you encounter issues with other games.\r\nIt may help to restart your computer after running this program.\r\n\r\nFor more information about this fix and/or support, join the Battlefront Modding Discord server at https://discord.gg/EzXSJfUDmq";
            string title = "Info";
            MessageBox.Show(message, title);
        }

        private void btn_github_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/Dulana57/FrostyFix");
        }

        private void rbtn_custom_CheckedChanged(object sender, EventArgs e) {
            btn_customchoose.Enabled = true;
        }
    }
}


