using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _019_Listboxx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox ll = sender as ListBox;
            txtSelectedIndex2.Text = ll.SelectedIndex.ToString();
            txtSelectedItem2.Text = ll.SelectedItem.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //(2) ListBox.Items.Add() 사용
            listBox2.Items.Add("뉴질랜드 - 오클랜드");
            listBox2.Items.Add("일본 - 오사카");
            listBox2.Items.Add("호주 - 아델레이드");
            listBox2.Items.Add("뉴질랜드 - 웰링턴");
            listBox2.Items.Add("일본 - 도쿄");
            listBox2.Items.Add("호주 - 퍼스");
            listBox2.Items.Add("스위스 - 취리히");
            listBox2.Items.Add("스위스 - 제네바");
            listBox2.Items.Add("호주 - 멜버른");
            listBox2.Items.Add("호주 - 브리즈번");

            //(3) DataSource 사용법
            List<string> happiness = new List<String>()
            {//초기화
                "필란드","덴마크","아이슬란드","스위스","네덜란드",
                "룩셈부르크","스웨덴","노르웨이","이스라엘","뉴질랜드"
            };

            listBox3.DataSource = happiness;
        }

        private void txtSelectedIndex1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ListBox l = (ListBox(sender));
            ListBox l = sender as ListBox;
            txtSelectedIndex1.Text = l.SelectedIndex.ToString();
            txtSelectedItem1.Text = l.SelectedItem.ToString();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            txtSelectedIndex3.Text = l.SelectedIndex.ToString();
            txtSelectedItem3.Text = l.SelectedItem.ToString();
        }

        private void txtSelectedIndex3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
