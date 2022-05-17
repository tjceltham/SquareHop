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

namespace SquareHop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            b[0] = B1;
            b[1] = B2;
            b[2] = B3;
            b[3] = B4;
            b[4] = B5;
            b[5] = B6;
            b[6] = B7;
            b[7] = B8;
            b[8] = B9;
            s = new SnakesAndLadders();

        }
        private Button[] b = new Button[9];
        private SnakesAndLadders s;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            s.start();
            update();
        }

        private void update()
        {

            Board boar = s.getBoard();
            for(int x=0; x<6; x++)
            {
                if (boar.getBoard()[x] == 0)
                {
                    
                    b[x].Content = "-";

                }
                else
                {
                    b[x].FontSize = 80;
                    b[x].Content = "*";

                }
            }
          
        }

        private void BR_Click(object sender, RoutedEventArgs e)
        {
           int i = s.roll();
           update();
            if (i == 1)  MessageBox.Show("We have a winner");
        }
    }
}
