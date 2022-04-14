﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _021_ComboBox
{
    public partial class Form1 : Form
    {
        TextBox[] titles;
        ComboBox[] crds;
        ComboBox[] grds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.Text = "인체의구조와기능";
            txt2.Text = "일반수학";
            txt3.Text = "디지털기술입문";
            txt4.Text = "설계및프로젝트";
            txt5.Text = "전기전자공학실험";
            txt6.Text = "비주얼프로그래밍";
            txt7.Text = "기업가정신";

            titles = new TextBox[] { txt1, txt2, txt3, txt4, txt5, txt6, txt7 };
            crds = new ComboBox[] { crd1, crd2, crd3, crd4, crd5, crd6, crd7 };
            grds = new ComboBox[] { grd1, grd2, grd3, grd4, grd5, grd6, grd7 };

            int[] arrCredit = { 1, 2, 3, 4, 5 };
            List<string> lstGrade = new List<string>
            {
                "A+","A0","B+","B0","C+","C0","D+","D0","F"
            };
            foreach (var c in crds)
            {
                foreach (var i in arrCredit)
                    c.Items.Add(i);
                c.SelectedItem = 3;
            }

            foreach(var g in grds)
            {
                foreach (var c in lstGrade)
                    g.Items.Add(c);
                g.SelectedItem = "A+";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totalScore = 0;
            int totalCredits = 0;

            for(int i = 0; i < grds.Length; i++)
            {
                if(grds[i].SelectedItem != null) //성적 입력된 과목에 대해서만
                {
                    int crd = int.Parse(crds[i].SelectedItem.ToString());
                    totalCredits += crd;
                    totalScore += crd * GetGrade(grds[i].SelectedItem.ToString());
                }
            }
            txtGrade.Text = (totalScore / totalCredits).ToString("0.00");
        }
        private double GetGrade(string v)
        {
            double grade;

            if (v == "A+") grade = 4.5;
            else if (v == "A0") grade = 4.0;
            else if (v == "B+") grade = 3.5;
            else if (v == "B0") grade = 3.0;
            else if (v == "C+") grade = 2.5;
            else if (v == "C0") grade = 2.0;
            else if (v == "D+") grade = 1.5;
            else if (v == "D0") grade = 1.0;
            else grade = 0;

            return grade;
        }
    }
}