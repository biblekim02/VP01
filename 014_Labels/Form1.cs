using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _014_Labels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "라파옐로, 아테네 학당";
            label1.Text = "";
            label2.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "라파옐로 산치오 다 우르비노, 르네상스 시대 이탈리아의 예술가";
            label2.Text = "아테네 학당(이탈리아어: Scuola di Atene)은 화가 라파엘로의" +
                " 프레스코화로 1510 ~ 1511년에 바티칸 사도 궁전 내부의 방들 가운데 교황의 " +
                "개인 서재인 서명의 방에 교황 율리오 2세를 위해 만들어졌다. 이 그림은 연작의 " +
                "한 부분으로 아테네 학당 옆에는 신성한 성단식의 논의( 성체논의, " +
                "Disputa del Sacramento )와 추덕을 보여주는 파르나소스산을 표현했다.";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
