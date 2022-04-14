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

namespace _030_ChessBoard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



            for (int i = 0; i < 64/2; i++) 
            {
                Rectangle r1 = new Rectangle();
                Rectangle r2 = new Rectangle();
                r1.Fill = Brushes.Black;
                r2.Fill = Brushes.Pink;
                if ((i / 4) %2 ==0) 
                {
                    CB.Children.Add(r1);
                    CB.Children.Add(r2);
                }
                else 
                {
                    CB.Children.Add(r2);
                    CB.Children.Add(r1);
                }
            }
        }
    }
}
