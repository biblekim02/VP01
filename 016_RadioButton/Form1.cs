using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _016_RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RadioButton[] rbN = { radioButton1, radioButton2, radioButton3, radioButton4 };
            RadioButton[] rbS = { radioButton5, radioButton6 };

            string result = "";
            foreach (RadioButton rb in rbN)
            {
                if (rb.Checked)
                    result += "국적 : " + rb.Text + "\n";
            }
            foreach(RadioButton rb in rbS)
            {
                if (rb.Checked)
                    result += "성별 : " + rb.Text + "성" + "\n";
            }
            MessageBox.Show(result, "Result");
        }
    }
}
