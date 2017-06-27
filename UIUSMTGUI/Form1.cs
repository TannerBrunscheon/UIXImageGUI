//Created by Tanner Brunscheon
//6/22/2017

using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UIUSMTGUI
{ 
    public partial class Form1 : Form
    {
        //Initialize the HasEdits field. Use to populate the text box at the bottom correctly. Global
        private bool boxHasEdits = false;
        //Initialize keepsake as a string to store the users input in the output text box
        private string keepsake;
        public Form1()
        {
            InitializeComponent();
           // this.Size = new Size(250, 560);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            //FOUND AT https://stackoverflow.com/questions/485341/in-vb-net-how-do-you-get-a-list-of-all-users-in-the-current-windows-machine by Nathan W
            // On load grab all user profile on the computer
            var i = 0;
            RegistryKey userskey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\ProfileList");
            foreach (string keyname in userskey.GetSubKeyNames())
            {
                using (RegistryKey key = userskey.OpenSubKey(keyname))
                {

                    string userpath = (string)key.GetValue("ProfileImagePath");
                    string username = Path.GetFileNameWithoutExtension(userpath);

                    if (i > 2)
                    {
                        profilesBox.Items.Add(username);
                    }
                    i++;
                }
            }

        }

        private void encryptBtn_CheckedChanged(object sender, EventArgs e)
        {

            //Allow encription if user selects it
            if (encryptBtn.Checked)
            {
                encryptBox.Enabled = true;
            }
            else
            {
                encryptBox.Enabled = false;
            }

        }

        private void selectAllBtn_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (selectAllBtn.Checked)
                {
                    for (int i = 0; i < profilesBox.Items.Count; i++)
                        profilesBox.SetItemChecked(i, true);
                }
                else
                {
                    for (int i = 0; i < profilesBox.Items.Count; i++)
                        profilesBox.SetItemChecked(i, false);
                }
            }
        }

        private void btnMigrate_Click(object sender, EventArgs e)
        {
            
            if (!Directory.Exists(txtBackLocal.Text))
            {
                if (boxHasEdits)
                {
                    Directory.CreateDirectory(txtBackLocal.Text);
                }
                else
                {
                    MessageBox.Show("Folder Not Found!");

                    return;
                }
                
            }
            string op;
            if (Environment.Is64BitOperatingSystem)
            {
                op = "amd64";
            }
            else
            {
                op = "x86";
            }
            string root = Path.GetPathRoot(Environment.SystemDirectory);
            string args = txtBackLocal.Text + " /i:" + root + "\\USMT\\" + op + "\\migdocs.xml /i:" + root + "\\USMT\\" + op + "\\migapp.xml /i:" + root + "\\USMT\\" + op + "\\wallpaper.xml /config:" + root + "\\USMT\\" + op + "\\config.xml /l:" + root + "\\USMT\\" + op + "\\scan.log /progress:" + root + "\\USMT\\" + op + "\\progress.log /localonly /vsc /c /efs:copyraw /v:13";
            if (allprofileBtn.Checked)
            {
                args += " /ue:iowa\\*_*";
            }
            else if (specificProfilesBtn.Checked)
            {
                foreach (Object checkedItem in profilesBox.CheckedItems)
                {
                    args = args + " /ui:iowa\\" + checkedItem.ToString();
                }
            }
            else if (dateBtn.Checked)
            {
                int x;
                if (Int32.TryParse(daysBox.Text, out x))
                {
                    if (x < 0)
                    {
                        MessageBox.Show("Enter in a positive number of days", "Error");
                        return;
                    }
                    args += "/uel:" + daysBox.Text;
                }
                else if (Regex.IsMatch(daysBox.Text, "^\\d{4}\\/(0?[1-9]|1[012])\\/(0?[1-9]|[12][0-9]|3[01])$"))
                {
                    args += "/uel:" + daysBox.Text;
                }
                else
                {
                    MessageBox.Show("Enter in day in correct format", "Error");
                    return;
                }

            }
            if (encryptBtn.Checked)
            {
                args += " /encrypt /key:" + encryptBox.Text;
            }
            if (overwriteBtn.Checked)
            {
                args += " /o";
            }
            if (Directory.Exists(root + "\\USMT\\" + op))
            {
                Directory.Delete(root + "\\USMT\\" + op, true);
            }
            DialogResult result = MessageBox.Show("Please Confirm Your Details", "Confirm", MessageBoxButtons.OKCancel);
            
            if(result == DialogResult.OK)
            {
                this.Visible = false;
                moveDIR(Directory.GetCurrentDirectory() + "\\" + op, root + "\\USMT\\" + op);

                int ExitCode =-1;
                ProcessStartInfo ProcessInfo;
                Process Process;

                ProcessInfo = new ProcessStartInfo(root + "\\USMT\\" + op + "\\scanstate.exe");
                ProcessInfo.Arguments = args;
                ProcessInfo.Verb = "runas";
                try
                {
                    Process = Process.Start(ProcessInfo);
                    Process.WaitForExit();

                    ExitCode = Process.ExitCode;
                    Process.Close();

                }
                catch
                {
                    MessageBox.Show("Must give elevated permssions", "ExecuteCommand");
                }


                this.Visible = true;
                if (ExitCode.ToString().Equals("0")){
                    MessageBox.Show("Ran Sucessfully", "ExecuteCommand");
                }
                else
                {
                    MessageBox.Show("Exit Code: " + ExitCode.ToString(), "ExecuteCommand");
                }
                
            }
          

        }
        //FOUND AT https://stackoverflow.com/questions/10014322/performance-of-copying-directories by Nikhil Agrawal
        private void moveDIR(string SourcePath, string DestinationPath)
        {
            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(SourcePath, "*",
                SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(SourcePath, DestinationPath));

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(SourcePath, "*.*",
                SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(SourcePath, DestinationPath), true);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtRestoreLocal.Text))
            {
                MessageBox.Show("Folder not found!");
                return;
            }
            string op;
            if (Environment.Is64BitOperatingSystem)
            {
                op = "amd64";
            }
            else
            {
                op = "x86";
            }
            string root = Path.GetPathRoot(Environment.SystemDirectory);
            string args = txtRestoreLocal.Text + " /i:" + root + "\\USMT\\" + op + "\\migdocs.xml /i:" + root + "\\USMT\\" + op + "\\migapp.xml /i:" + root + "\\USMT\\" + op + "\\wallpaper.xml /config:" + root + "\\USMT\\" + op + "\\config.xml /l:" + root + "\\USMT\\" + op + "\\load.log /progress:" + root + "\\USMT\\" + op + "\\progress.log /c /v:13";
            if (decryptBtn.Checked)
            {
                if (!decryptBox.Equals(""))
                {
                    args += " /decrypt /key:" + decryptBox.Text;
                }
                else
                {
                    MessageBox.Show("Enter a key");
                }
            }
            
            if (restoreNoTechBtn.Checked)
            {
                args += " /ue:iowa\\*_*";
            }
            if (Directory.Exists(root + "\\USMT\\" + op))
            {
                Directory.Delete(root + "\\USMT\\" + op, true);
            }
            DialogResult result = MessageBox.Show("Please Confirm Your Details", "Confirm", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                this.Visible = false;
                moveDIR(Directory.GetCurrentDirectory() + "\\" + op, root + "\\USMT\\" + op);

                int ExitCode;
                ProcessStartInfo ProcessInfo;
                Process Process;

                ProcessInfo = new ProcessStartInfo(root + "\\USMT\\" + op + "\\loadstate.exe");
                ProcessInfo.Arguments = args;
                ProcessInfo.Verb = "runas";

                Process = Process.Start(ProcessInfo);
                
                Process.WaitForExit();

                ExitCode = Process.ExitCode;
                Process.Close();
                this.Visible = true;
                if (ExitCode.ToString().Equals("0"))
                {
                    MessageBox.Show("Ran Sucessfully", "ExecuteCommand");
                }
                else
                {
                    MessageBox.Show("Exit Code: " + ExitCode.ToString(), "ExecuteCommand");
                }
            }
        }


        private void daysBox_Enter(object sender, EventArgs e)
        {
            if (daysBox.Text == "YYYY/MM/DD")
            {
                daysBox.Text = "";
                daysBox.ForeColor = Color.Black;
            }
        }

        private void daysBox_Leave(object sender, EventArgs e)
        {
            if (daysBox.Text == "")
            {
                daysBox.Text = "YYYY/MM/DD";
                daysBox.ForeColor = Color.Gray;
            }
        }

        private void specificProfilesBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (specificProfilesBtn.Checked)
            {
                selectAllBtn.Enabled = true;
                profilesBox.Enabled = true;
            }
            else
            {
                selectAllBtn.Enabled = false;
                profilesBox.Enabled = false;
            }
        }

        private void dateBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (dateBtn.Checked)
            {
                daysBox.Enabled = true;
            }
            else
            {
                daysBox.Enabled = false;
            }
        }

        private void decryptBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (decryptBtn.Checked)
            {
                decryptBox.Enabled = true;
            }
            else
            {
                decryptBox.Enabled = false;
            }
        }

        private void restoreAllBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
           string op;
           if (Environment.Is64BitOperatingSystem)
            {
                op = "amd64";
            }
           else
            {
                op = "x86";
            }
                string root = Path.GetPathRoot(Environment.SystemDirectory);
            if (File.Exists(root + "\\USMT\\" + op + "\\scan.log"))
            {
                Process.Start(root + "\\USMT\\" + op + "\\scan.log");
            }
            else
            {
                MessageBox.Show("Does Not Exist!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string op;
            if (Environment.Is64BitOperatingSystem)
            {
                op = "amd64";
            }
            else
            {
                op = "x86";
            }
            string root = Path.GetPathRoot(Environment.SystemDirectory);
            if (File.Exists(root + "\\USMT\\" + op + "\\load.log"))
            {
                Process.Start(root + "\\USMT\\" + op + "\\load.log");
            }
            else
            {
                MessageBox.Show("Does Not Exist!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                string op;
                if (Environment.Is64BitOperatingSystem)
                {
                    op = "amd64";
                }
                else
                {
                    op = "x86";
                }
                string root = Path.GetPathRoot(Environment.SystemDirectory);
                if (File.Exists(root + "\\USMT\\" + op + "\\MigViewer.exe"))
                {
                    Process.Start(root + "\\USMT\\" + op + "\\MigViewer.exe");
                }
                else
                {
                    MessageBox.Show("Does Not Exist!");
                }
            }
        }

        private void btnBackLocal_Click(object sender, EventArgs e)
        {
            txtBackLocal.Text = keepsake;
            DialogResult dialog = folderBrowserDialog.ShowDialog();
            string selection = folderBrowserDialog.SelectedPath;
            if (selection != "")
            {
                txtBackLocal.Text = selection;
                boxHasEdits = false;
                keepsake = txtBackLocal.Text;
            }

        }

        private void btnRestoreLocal_Click(object sender, EventArgs e)
        {
            DialogResult dialog = folderBrowserDialog.ShowDialog();
            string selection = folderBrowserDialog.SelectedPath;
            if (selection != "")
            {
                txtRestoreLocal.Text = selection;
            }

        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            string op;
            if (Environment.Is64BitOperatingSystem)
            {
                op = "amd64";
            }
            else
            {
                op = "x86";
            }
            string root = Path.GetPathRoot(Environment.SystemDirectory);
            if (File.Exists(root + "\\USMT\\" + op + "\\progress.log"))
            {
                Process.Start(root + "\\USMT\\" + op + "\\progress.log");
            }
            else
            {
                MessageBox.Show("Does Not Exist!");
            }
        }

        private void btnTemplate_CheckedChanged(object sender, EventArgs e)
        {
            if(btnTemplate.Checked)
            {
                if (!Directory.Exists(txtBackLocal.Text))
                {
                    MessageBox.Show("Folder not found!");
                    btnTemplate.Checked = false;
                    return;
                }
                boxProfiles.Enabled = true;
            }
            else
            {
                boxProfiles.Enabled = false;
                txtBackLocal.Text = keepsake;
            }
        }

        private void txtBackLocal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void boxProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!boxHasEdits)
            {
                keepsake = txtBackLocal.Text;
            }


            if((txtBackLocal.Text.Substring(txtBackLocal.Text.Length - 1, 1)).Equals(@"\")){
                txtBackLocal.Text = txtBackLocal.Text.Substring(0, txtBackLocal.Text.Length - 1);
            }
            switch (boxProfiles.SelectedIndex)
            {
                case 0:
                    txtBackLocal.Text = keepsake + @"\" + Environment.MachineName;
                    boxHasEdits = true;
                        break;
                case 1:
                    txtBackLocal.Text = keepsake + @"\" + Environment.MachineName + "~" + DateTime.Now.ToString("yyyyMMdd", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
                    boxHasEdits = true;
                    break;
                case 2:
                    txtBackLocal.Text = keepsake + @"\" + DateTime.Now.ToString("yyyyMMdd", System.Globalization.CultureInfo.GetCultureInfo("en-US")) + "~" + Environment.MachineName;
                    boxHasEdits = true;
                    break;
                case 3:
                    txtBackLocal.Text = keepsake + @"\";
                    int i = 0;
                    foreach(Object checkedItem in profilesBox.CheckedItems)
                    {
                        if (i < 1)
                        {
                            txtBackLocal.Text += checkedItem.ToString();
                            i++;
                        }
                    }
                    boxHasEdits = true;
                        break;
                case 4:
                    txtBackLocal.Text = keepsake + @"\";
                    int j = 0;
                    foreach (Object checkedItem in profilesBox.CheckedItems)
                    {
                        if (j < 3)
                        {
                            txtBackLocal.Text += checkedItem.ToString() + "~";
                            j++;
                        }
                    }
                    boxHasEdits = true;
                    break;

            };
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void txtBackLocal_KeyPress(object sender, KeyPressEventArgs e)
        {
            boxHasEdits = false;
            keepsake = txtBackLocal.Text;
            btnTemplate.Checked = false;
        }


        private void txtBackLocal_MouseClick(object sender, MouseEventArgs e)
        {
            boxHasEdits = false;
            txtBackLocal.Text = keepsake;
            btnTemplate.Checked = false;
        }
    }
}
