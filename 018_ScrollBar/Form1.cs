using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _018_ScrollBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.LightSteelBlue;
            panel1.BackColor = Color.FromArgb(0, 0, 0);//Color.Black;

            tbR.Text = 0.ToString();
            tbG.Text = "0";
            tbB.Text = "0";
            scrR.Maximum = 255 + 9;
            scrG.Maximum = 255 + 9;
            scrB.Maximum = 255 + 9;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (tbR.Text!="" && tbG.Text != "" && tbB.Text != "")
            {
                scrR.Value = int.Parse(tbR.Text);
                scrG.Value = int.Parse(tbG.Text);
                scrB.Value = int.Parse(tbB.Text);
                panel1.BackColor = Color.FromArgb(scrR.Value, scrG.Value, scrB.Value);
            }
        }
        private void scr_Scroll(object sender, ScrollEventArgs e)
        {
            tbR.Text = scrR.Value.ToString();
            tbG.Text = scrG.Value.ToString();
            tbB.Text = scrB.Value.ToString();
            panel1.BackColor = Color.FromArgb(scrR.Value, scrG.Value, scrB.Value);
        }
    }
}