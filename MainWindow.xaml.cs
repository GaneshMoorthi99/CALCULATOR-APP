using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace calculatorapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        string firstno = "";
        string secondno = "";
        string oper = "";
        public MainWindow()
        {
            InitializeComponent();
        }

      

        private void btnoper_Click(object sender, RoutedEventArgs e)
        {
            Button btnoper = (Button)sender;
            oper = btnoper.Content.ToString();

        }
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
         if (oper =="")
            {
                firstno = firstno + button.Content.ToString();
                txtresult.Text = firstno;
            }
            else
            {
                secondno = secondno + button.Content.ToString();
                txtresult.Text = secondno;
            }
           
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            int first = Convert.ToInt32(firstno);
            int second = Convert.ToInt32(secondno);
            int result = 0;

            switch (oper)
            {
                case "+":
                    {
                        result = first + second;
                        break;
                    }

                case "-":
                    {
                        result = first - second;
                        break;
                    }
                case "*":
                    {
                        result = first * second;
                        break;
                    }
                case "/":
                    {
                        result = first / second;
                        break;
                    }

            }
            txtresult.Text = Convert.ToString(result);
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            firstno = "";
            secondno = "";
            oper = "";
            txtresult.Text = "";
        }

     
    }
}