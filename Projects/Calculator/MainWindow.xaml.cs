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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double firstNumber = 0;
        string operation = "";
        double secondNumber = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SevenButton_Click(object sender, RoutedEventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = 7.ToString();
            }
            else
            {
                DisplayBox.Text += 7.ToString();
            }
        }

        private void EightButton_Click(object sender, RoutedEventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = 8.ToString();
            }
            else
            {
                DisplayBox.Text += 8.ToString();
            }
            
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = double.Parse(DisplayBox.Text);
            DisplayBox.Text = 0.ToString();
            operation = "+";
            StatementDisplay.Text = $"{firstNumber} + ";
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            secondNumber = double.Parse(DisplayBox.Text); 
            StatementDisplay.Text += $"{secondNumber}";
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                case "clear":
                   
                    break;
                
            }
            DisplayBox.Text = result.ToString();
        }

        private void NineButton_Click(object sender, RoutedEventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = 9.ToString();
            }
            else
            {
                DisplayBox.Text += 9.ToString();
            }
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            {
                firstNumber = double.Parse(DisplayBox.Text);
                DisplayBox.Text = 0.ToString();
                operation = "-";
                StatementDisplay.Text = $"{firstNumber} - ";
            }
        }

        private void FourthButton_Click(object sender, RoutedEventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = 4.ToString();
            }
            else
            {
                DisplayBox.Text += 4.ToString();
            }
        }

        private void FifthButton_Click(object sender, RoutedEventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = 5.ToString();
            }
            else
            {
                DisplayBox.Text += 5.ToString();
            }
        }

        private void SixthButton_Click(object sender, RoutedEventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = 6.ToString();
            }
            else
            {
                DisplayBox.Text += 6.ToString();
            }
        }

        private void FirstButton_Click(object sender, RoutedEventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = 1.ToString();
            }
            else
            {
                DisplayBox.Text += 1.ToString();
            }
        }

        private void SecondButton_Click(object sender, RoutedEventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = 2.ToString();
            }
            else
            {
                DisplayBox.Text += 2.ToString();
            }
        }

        private void ThirdButton_Click(object sender, RoutedEventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = 3.ToString();
            }
            else
            {
                DisplayBox.Text += 3.ToString();
            }
        }

        private void PoButton_Click(object sender, RoutedEventArgs e)
        {
            {
                firstNumber = double.Parse(DisplayBox.Text);
                DisplayBox.Text = 0.ToString();
                operation = "*";
                StatementDisplay.Text = $"{firstNumber} * ";
            }
        }

        private void DelenoButton_Click(object sender, RoutedEventArgs e)
        {
            {
                firstNumber = double.Parse(DisplayBox.Text);
                DisplayBox.Text = 0.ToString();
                operation = "/";
                StatementDisplay.Text = $"{firstNumber} / ";
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            {
                firstNumber = double.Parse(DisplayBox.Text);
                DisplayBox.Text = 0.ToString();
                operation = "/";
                StatementDisplay.Text = $"{firstNumber} / ";
            }
        }
    }
}
