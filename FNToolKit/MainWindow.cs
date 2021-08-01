using FNToolKit.sources;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNToolKit
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            checkBox3.Checked = SavedData.ConfigData.LegacyLaunch;
            checkBox2.Checked = SavedData.ConfigData.CloseOnStartGame;
            checkBox1.Checked = SavedData.ConfigData.ForceEAC;
            checkBox1.Enabled = !checkBox3.Checked;
            if (SavedData.ConfigData.CustomFortnitePath == null)
            {
                textBox1.Text = " Keep this in blank to auto detect install location";
                textBox1.ForeColor = Color.DarkGray;
            }
            else
            {
                textBox1.Text = SavedData.ConfigData.CustomFortnitePath;
                textBox1.ForeColor = SystemColors.WindowText;
            }
        }

        private void TwitterLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/Sprintermax");
        }

        private void ResetConfigsBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "You really want to reset the saved settings? This can not be undone!",
                "Revert Settings Back to Default",
                MessageBoxButtons.OKCancel
            ) == DialogResult.OK)
            {
                SavedData.ConfigData = new AppConfig { };
                SavedData.SaveConfigFile();
                LoadSettings();
                MessageBox.Show("Configuration reverted to default values.", "Information");
            }
        }

        private void DeleteAllAccountsBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "You really want to delete all accounts?",
                "Remove Saved Accounts",
                MessageBoxButtons.OKCancel
            ) == DialogResult.OK)
            {
                SavedData.AccountsData = new List<SavedAccs>();
                SavedData.SaveAccountsFile();
                MessageBox.Show("All the stored accounts Data was deleted.", "Information");
            }
        }

        private void textbox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                textBox1.ForeColor = Color.DarkGray;
                textBox1.Text = " Keep this in blank to auto detect install location";
            }
        }

        private void textbox1_Enter(object sender, EventArgs e)
        {
            textBox1.ForeColor = SystemColors.WindowText;
            if (textBox1.Text == " Keep this in blank to auto detect install location")
            {
                textBox1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            if (folderDlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderDlg.SelectedPath;
                textBox1.ForeColor = SystemColors.WindowText;
            }
        }

        async private void SaveCfgBtn_Click(object sender, EventArgs e)
        {
            SavedData.ConfigData.CloseOnStartGame = checkBox2.Checked;
            SavedData.ConfigData.ForceEAC = checkBox1.Checked;
            SavedData.ConfigData.LegacyLaunch = checkBox3.Checked;
            if (textBox1.Text == " Keep this in blank to auto detect install location")
            {
                SavedData.ConfigData.CustomFortnitePath = null;
            }
            else
            {
                SavedData.ConfigData.CustomFortnitePath = textBox1.Text;
            }
            SavedData.SaveConfigFile();
            label6.Visible = true;
            await Task.Delay(3000);
            label6.Visible = false;
        }

        private void TabScreen_TabClicked(object sender, EventArgs e)
        {
            if ((sender as TabControl).SelectedIndex == 4)
            {
                label6.Visible = false;
                LoadSettings();
            }
        }

        async private void LaunchGameBtn_Click(object sender, EventArgs e)
        {
            LaunchGameBtn.Enabled = false;
            string FortniteLauncher = EpicHelper.GetFortniteLauncher();
            if (FortniteLauncher == null)
            {
                MessageBox.Show("The Executable to launch the game was not found", "Unable to Open Fortnite");
            }
            else
            {
                Process Fortnite = new Process();
                Fortnite.StartInfo.FileName = FortniteLauncher;
                if (SavedData.ConfigData.LegacyLaunch == false)
                {
                    if (SavedData.ConfigData.ForceEAC == true) Fortnite.StartInfo.Arguments += "-forceeac ";
                }
                MessageBox.Show("\"" + Fortnite.StartInfo.Arguments + "\"", "Unable to Open Fortnite");
                Fortnite.Start();
                await Task.Delay(5000);
                if (SavedData.ConfigData.CloseOnStartGame == true) Application.Exit();
                LaunchGameBtn.Enabled = true;
            }
        }

        private void OpenGameFolderBtn_Click(object sender, EventArgs e)
        {
            string FortniteLauncher = EpicHelper.GetFortniteLauncher();
            if (FortniteLauncher == null)
            {
                MessageBox.Show("The game installation folder was not found.", "Unable to Find Game Folder");
            }
            else
            {
                Process.Start(Path.Combine(FortniteLauncher, "..\\..\\..\\..\\"));
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = !checkBox3.Checked;
        }
    }
}



/*
                SavedAccs Account = new SavedAccs();
                Account.FNDevID = "test123";
                SavedData.AccountsData.Add(Account);
                SavedData.SaveAccountsFile();

                //SavedAccs Account = new SavedAccs();
                //Account.FNDevID = "test123";
                //SavedData.AccountsData.RemoveAll(item => item.FNDevID == "test3");
                //SavedData.SaveAccountsFile();
*/