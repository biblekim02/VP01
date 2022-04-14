using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _017_scoreCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = double.Parse(tbKorea.Text) + Convert.ToDouble(tbMath.Text)
                + Convert.ToDouble(tbEng.Text);
            double avrg = sum / 3;
            tbSum.Text = sum.ToString();
            tbAvg.Text = avrg.ToString("0.0"); // 소수점 한 자리
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}