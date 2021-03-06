using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrostyFix {
    public partial class Form2 : Form {
        string origindir;
        string eaddir;

        public Form2() {
            InitializeComponent();
            //Get Origin and/or EA Desktop paths
            using (RegistryKey origindirkey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Electronic Arts\EA Core"))
                if (origindirkey != null) {
                    origindir = (string)origindirkey.GetValue("EADM6InstallDir");
                }
                else {
                    btn_restartOrigin.Enabled = false;
                }
            using (RegistryKey eaddirkey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Electronic Arts\EA Desktop"))
                if (eaddirkey != null) {
                    eaddir = (string)eaddirkey.GetValue("DesktopAppPath");
                }
                else {
                    btn_restartEA.Enabled = false;
                }
        }

        private async void btn_restartEA_Click(object sender, EventArgs e) {
            //Kill all EA processes
            foreach (var process in Process.GetProcessesByName("EADesktop")) {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("Origin")) {
                process.Kill();
            }
            Application.UseWaitCursor = true;
            await Task.Delay(8000);
            Application.UseWaitCursor = false;
            System.Diagnostics.Process.Start(eaddir);
            this.Close();
        }

        private async void btn_restartOrigin_Click(object sender, EventArgs e) {
            //Kill all EA processes
            foreach (var process in Process.GetProcessesByName("EADesktop")) {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("Origin")) {
                process.Kill();
            }
            Application.UseWaitCursor = true;
            await Task.Delay(8000);
            Application.UseWaitCursor = false;
            //System.Diagnostics.Process.Start(origindir + "\\Origin.exe");
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.WorkingDirectory = origindir;
            p.StartInfo.FileName = origindir + "\\Origin.exe";
            p.Start();
            this.Close();

        }

        private async void btn_restartPC_Click(object sender, EventArgs e) {
            string message = "Are you sure you want to restart this PC?";
            string title = "Restart PC";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes) {
                await Task.Delay(2000);
                System.Diagnostics.Process.Start("shutdown.exe", "-r -t 0");
            }
        }
    }
}
