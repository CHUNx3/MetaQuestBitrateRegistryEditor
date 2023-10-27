using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        private const string OculusRegKey = "HKEY_CURRENT_USER\\SOFTWARE\\Oculus\\RemoteHeadset";
        private const string OdtCli = "C:\\Program Files\\Oculus\\Support\\oculus-diagnostics\\OculusDebugToolCLI.exe\"";
        private const string BitrateMbpsValueName = "BitrateMbps";
        private const string HevcValueName = "HEVC";
        private const string DbrValueName = "DBR";
        private const string DbrMaxValueName = "DBRMax";
        private const string SharpeningValueName = "LinkSharpeningEnabled";

        private Boolean hevcToggle;
        private Boolean dbrToggle;

        public Form1()
        {
            InitializeComponent();

            Object bitrateValue = Registry.GetValue(OculusRegKey, BitrateMbpsValueName, null);
            if (bitrateValue != null && bitrateValue is int)
            {
                bitrateTextBox.Text = bitrateValue.ToString();
            }

            Object dbrMaxValue = Registry.GetValue(OculusRegKey, DbrMaxValueName, null);
            if (dbrMaxValue != null && dbrMaxValue is int)
            {
                dbmTextBox.Text = dbrMaxValue.ToString();
            }

            Object hevcValue = Registry.GetValue(OculusRegKey, HevcValueName, null);
            if (hevcValue != null && hevcValue is int && int.Parse(hevcValue.ToString()) == 0)
            {
                hevcToggle = false;
                hevcBtn.BackgroundImage = MetaQuestBitrateRegistryEditor.Properties.Resources.off_button;
            }
            else
            {
                hevcToggle = true;
                hevcBtn.BackgroundImage = MetaQuestBitrateRegistryEditor.Properties.Resources.on_button;
            }

            Object dbrValue = Registry.GetValue(OculusRegKey, DbrValueName, null);
            if (dbrValue != null && dbrValue is int && int.Parse(dbrValue.ToString()) == 1)
            {
                dbrValue = true;
                dbrBtn.BackgroundImage = MetaQuestBitrateRegistryEditor.Properties.Resources.on_button;
            }
            else
            {
                dbrValue = false;
                dbrBtn.BackgroundImage = MetaQuestBitrateRegistryEditor.Properties.Resources.off_button;
            }

            Object sharpeningValue = Registry.GetValue(OculusRegKey, SharpeningValueName, null);
            if (sharpeningValue != null && sharpeningValue is int)
            {
                string sharpeningStrValue;
                if ((int) sharpeningValue == 1)
                {
                    sharpeningStrValue = "Disabled";
                }
                else if ((int)sharpeningValue == 2)
                {
                    sharpeningStrValue = "Normal";
                }
                else
                {
                    sharpeningStrValue = "Quality";
                }
                sharpeningComboBox.SelectedItem = sharpeningStrValue;
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = null;
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric characters and control characters (such as backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bitrateTextBox_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(bitrateTextBox.Text))
            {
                Registry.SetValue(OculusRegKey, BitrateMbpsValueName, int.Parse(bitrateTextBox.Text));
            }            
        }

        private void dbmTextBox_Leave(object sender, EventArgs e)
        {
            Registry.SetValue(OculusRegKey, DbrMaxValueName, int.Parse(dbmTextBox.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hevcBtn_Click(object sender, EventArgs e)
        {
            hevcToggle = !hevcToggle;
            hevcBtn.BackgroundImage = hevcToggle ? MetaQuestBitrateRegistryEditor.Properties.Resources.on_button
                : MetaQuestBitrateRegistryEditor.Properties.Resources.off_button;
            Registry.SetValue(OculusRegKey, HevcValueName, hevcToggle ? 1 : 0);
        }

        private void dbrBtn_Click(object sender, EventArgs e)
        {
            dbrToggle = !dbrToggle;
            dbrBtn.BackgroundImage = dbrToggle ? MetaQuestBitrateRegistryEditor.Properties.Resources.on_button
                : MetaQuestBitrateRegistryEditor.Properties.Resources.off_button;
            Registry.SetValue(OculusRegKey, DbrValueName, dbrToggle ? 1 : 0);
        }

        private void perfHudOffBtn_Click(object sender, EventArgs e)
        {
            string command = "echo perfhud reset | \"" + OdtCli;

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c " + command;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            Process.Start(startInfo);
        }

        private void perfHudOnBtn_Click(object sender, EventArgs e)
        {
            string command = "echo perfhud set-mode 7 | \"" + OdtCli;

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c " + command;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            Process.Start(startInfo);
        }


        private void restoreBtn_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\Oculus\\RemoteHeadset", true);

            if (key == null)
            {
                return;
            }

            if (key.GetValue(BitrateMbpsValueName) != null)
            {
                key.DeleteValue(BitrateMbpsValueName);
            }

            if (key.GetValue(HevcValueName) != null)
            {
                key.DeleteValue(HevcValueName);
            }

            if (key.GetValue(DbrValueName) != null)
            {
                key.DeleteValue(DbrValueName);
            }

            if (key.GetValue(DbrMaxValueName) != null)
            {
                key.DeleteValue(DbrMaxValueName);
            }

            key?.Close();

            bitrateTextBox.Text = "";
            dbmTextBox.Text = "";
            hevcToggle = true;
            hevcBtn.BackgroundImage = MetaQuestBitrateRegistryEditor.Properties.Resources.on_button;
            dbrToggle = false;
            dbrBtn.BackgroundImage = MetaQuestBitrateRegistryEditor.Properties.Resources.off_button;
        }

        private void aswOffBtn_Click(object sender, EventArgs e)
        {
            string command = "echo server:asw.Off | \"" + OdtCli;

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c " + command; // "/c" flag tells cmd to execute the command and exit
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;

            Process.Start(startInfo);
        }

        private void sharpeningComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = sharpeningComboBox.SelectedItem.ToString();
            int sharpeningValue;
            if (selectedValue.Equals("Disabled"))
            {
                sharpeningValue = 1;
            }
            else if (selectedValue.Equals("Normal"))
            {
                sharpeningValue = 2;
            } else
            {
                sharpeningValue = 3;
            }
            Registry.SetValue(OculusRegKey, SharpeningValueName, sharpeningValue);
        }
    }
}
