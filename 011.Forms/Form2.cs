using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _011.Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(300, 300); //폼 크기 500*500
            button1.Location = new System.Drawing.Point(//버튼1 위치
                300 / 2 - button1.Width / 2, 300 / 2 - button1.Height / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }
    }
}