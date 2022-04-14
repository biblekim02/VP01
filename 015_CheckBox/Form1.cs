using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _015_CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckBox[] cBox = { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5 };

            string checkStates = "";
            foreach (var c in cBox)
            {
                checkStates += String.Format("{0} : {1}\n", c.Text, c.Checked);
            }

            string summary = "";
            foreach (var c in cBox)
            {
                if (c.Checked) //==True
                    summary += c.Text + " ";
            }

            MessageBox.Show(checkStates, "checkStates");
            MessageBox.Show(summary,"summary");
        }
    }
}
