using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const string OculusRegKey = "HKEY_CURRENT_USER\\SOFTWARE\\Oculus\\RemoteHeadset";
        private const string BitrateMbpsValueName = "BitrateMbps";
        private const string HevcValueName = "HEVC";
        private const string DbrValueName = "DBR";        
        private const string DbrMaxValueName = "DBRMax";        

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
            Registry.SetValue(OculusRegKey, BitrateMbpsValueName, int.Parse(bitrateTextBox.Text));
        }

        private void dbmTextBox_Leave(object sender, EventArgs e)
        {
            Registry.SetValue(OculusRegKey, DbrMaxValueName, int.Parse(dbmTextBox.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hevcOffBtn_Click(object sender, EventArgs e)
        {
            Registry.SetValue(OculusRegKey, HevcValueName, 0);
        }

        private void hevcOnBtn_Click(object sender, EventArgs e)
        {
            Registry.SetValue(OculusRegKey, HevcValueName, 1);
        }

        private void dbrOffBtn_Click(object sender, EventArgs e)
        {
            Registry.SetValue(OculusRegKey, DbrValueName, 0);
        }

        private void dbrOnBtn_Click(object sender, EventArgs e)
        {
            Registry.SetValue(OculusRegKey, DbrValueName, 1);

        }
    }
}
