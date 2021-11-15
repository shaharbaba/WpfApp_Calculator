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
using System.Text.RegularExpressions;

namespace WpfApp_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String operation = "";
        Double firstNum, secondNum;
        public MainWindow()
        {
            InitializeComponent();
            resultBox.Text = "0";
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;

            if(b.Content.ToString() == "C")
            {
                resultBox.Text = "0";
                firstNum = 0;
                secondNum = 0;
                operation = "";
            }
            else
                if(operation == "")
            {
                resultBox.Text = "0";
                firstNum = 0;
            }
            else
            {
                resultBox.Text = "0";
                secondNum = 0;
            }
            
        }

        private void numeric_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if(operation == "")
            {
                firstNum = (firstNum * 10) + double.Parse(b.Content.ToString());
                resultBox.Text = firstNum.ToString();
            }
            else
            {
                secondNum = (secondNum * 10) + double.Parse(b.Content.ToString());
                resultBox.Text = secondNum.ToString();
            }
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if (b.Content.ToString() == "=")
            {
                switch (operation)
                {
                    case "+":
                        resultBox.Text = (firstNum + secondNum).ToString();
                        break;
                    case "/":
                        resultBox.Text = (firstNum / secondNum).ToString();
                        break;
                    case "-":
                        resultBox.Text = (firstNum - secondNum).ToString();
                        break;
                    case "X":
                        resultBox.Text = (firstNum * secondNum).ToString();
                        break;
                }
                operation = "";
                firstNum = 0;
                secondNum = 0;
            }
        }

        private void minusPlus_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;

            if (b.Content.ToString() == "+-")
            {
                if (operation == "")
                {
                    firstNum *= -1;
                    resultBox.Text = firstNum.ToString();
                }
                else
                {
                    secondNum *= -1;
                    resultBox.Text = secondNum.ToString();
                }
            }
        }

        private void action_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if(operation != "" && firstNum != 0 && secondNum != 0)
            {
                switch (operation)
                {
                    case "+":
                        firstNum += secondNum;
                        secondNum = 0;
                        break;
                    case "-":
                        firstNum -= secondNum;
                        secondNum = 0;
                        break;
                    case "/":
                        firstNum /= secondNum;
                        secondNum = 0;
                        break;
                    case "X":
                        firstNum *= secondNum;
                        secondNum = 0;
                        break;
                }
                    
            }
            if (b.Content.ToString() == "+")
            {
                operation = "+";
                resultBox.Text = "0";
            }
            else
                if (b.Content.ToString() == "-")
            {
                operation = "-";
                resultBox.Text = "0";
            }
            else
                if (b.Content.ToString() == "/")
            {
                operation = "/";
                resultBox.Text = "0";
            }
            else
                if (b.Content.ToString() == "X")
            {
                operation = "X";
                resultBox.Text = "0";
            }
            
        }

    }
}
