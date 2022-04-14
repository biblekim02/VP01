using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _031_WindowCaculator
{
    public partial class MainWindow : Window
    {
        private bool opFlag = false;
        private bool memFlag = false;
        private double saved; //txtResult
        private string? op; //사칙연산자
        private bool afterClac;

        public MainWindow()
        {
            InitializeComponent();
            btnMC.IsEnabled = false;
            btnMR.IsEnabled = false;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string s = btn.Content.ToString();
            

            //출력창이 0이거나 연산자 버튼이 눌린 후, 메모리 버튼이 눌린 후에
            if (txtResult.Text == "0" || opFlag == true || memFlag == true ||afterClac == true)
            {
                if (afterClac == true)
                    txtExp.Text = "";
                txtResult.Text = s;
                opFlag = false; //원위치
                memFlag = false;
                afterClac = false;
            }
            else txtResult.Text += s;
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            //소수점이 눌렸을 때 결과에 이미 있으면
            if (txtResult.Text.Contains("."))
                return; //그대로
            else txtResult.Text += "."; //없으면 .추가
        }

        //사칙연산자 클릭했을 때
        private void op_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            saved = double.Parse(txtResult.Text);
            op = btn.Content.ToString();
            txtExp.Text = txtResult.Text + op;
            opFlag = true;
            
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            double v = double.Parse(txtResult.Text);
            txtExp.Text += txtResult.Text + "=";

            switch (op)
            {
                case "+":
                    txtResult.Text = (saved + v).ToString();
                    break;
                case "-":
                    txtResult.Text = (saved - v).ToString();
                    break;
                case "÷":
                    txtResult.Text = (saved / v).ToString();
                    break;
                case "x":
                    txtResult.Text = (saved * v).ToString();
                    break;
                default:
                    MessageBox.Show("Error in Equal");
                    break;
            }
            afterClac = true;
        }

        //+-버튼
        private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = (double.Parse(txtResult.Text) * (-1)).ToString();
        }

        private void btnPercent_Click(object sender, RoutedEventArgs e)
        {
            double p = double.Parse(txtResult.Text);
            p = saved * p / 100;
            txtResult.Text = p.ToString();
            //txtExp.Text += txtResult.Text;
        }

        private void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            if (txtExp.Text == "")
                txtExp.Text = "√(" + txtResult.Text + ")";
            else txtExp.Text = "√(" + txtExp.Text + ")";

            txtResult.Text = Math.Sqrt(double.Parse(txtResult.Text)).ToString();
        }

        private void btnSqr_Click(object sender, RoutedEventArgs e)
        {
            //x²
            if (txtExp.Text == "")
                txtExp.Text = "(" + txtResult.Text + ")²";
            else txtExp.Text = "(" + txtExp.Text + ")²";

            double v = Double.Parse(txtResult.Text);
            txtResult.Text = (v * v).ToString();
        }

        private void btnRecip_Click(object sender, RoutedEventArgs e)
        {
            if (txtExp.Text == "")
                txtExp.Text = "1/(" + txtResult.Text + ")";
            else txtExp.Text = "1/(" + txtExp.Text + ")";

            double v = Double.Parse(txtResult.Text);
            txtResult.Text = (1 / v).ToString();
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            txtExp.Text = "";
            txtResult.Text = "0";
            saved = 0;
            op = "";
            opFlag = false;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
            if (txtResult.Text.Length == 0)
                txtResult.Text = "0";
        }
    }
}
