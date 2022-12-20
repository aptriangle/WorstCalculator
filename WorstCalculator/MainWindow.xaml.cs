using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using WorstMath;

namespace WorstCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string currentEquation = "";
        private char[] operators = new char[] { '+', '-','×', '÷' };
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool isOperator(char test)
        {
            return operators.Contains(test);
        }

        private void updateEquation()
        {
            if (currentEquation.Length > 1 && isOperator(currentEquation[currentEquation.Length - 1]) && isOperator(currentEquation[currentEquation.Length - 2])) {
                currentEquation = currentEquation.Substring(0, currentEquation.Length - 1);
            }
            equationTextBlock.Text = currentEquation;

            Regex regex = new Regex(@"([-+×÷]?)([\d\.]+)");
            Match match = regex.Match(currentEquation);

            WorstNumber value = new WorstNumber(0);
            while (match.Success)
            {
                WorstNumber modifer = new WorstNumber(double.Parse(match.Groups[2].Value));
                switch (match.Groups[1].Value)
                {
                    case "+":
                        value = value + modifer;
                        break;
                    case "-":
                        value = value - modifer;
                        break;
                    case "×":
                        value = value * modifer;
                        break;
                    case "÷":
                        value = value / modifer;
                        break;
                    default:
                        value = value + modifer;
                        break;
                }
                match = match.NextMatch();
            }
            outputTextBlock.Text = value.ToString();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            currentEquation += "1";
            updateEquation();
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            currentEquation += "2";
            updateEquation();
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            currentEquation += "3";
            updateEquation();
        }

        private void ba_Click(object sender, RoutedEventArgs e)
        {
            currentEquation += "+";
            updateEquation();
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            currentEquation += "4";
            updateEquation();
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            currentEquation += "5";
            updateEquation();
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            currentEquation += "6";
            updateEquation();
        }

        private void bs_Click(object sender, RoutedEventArgs e)
        {
            currentEquation += "-";
            updateEquation();
        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            currentEquation += "7";
            updateEquation();
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            currentEquation += "8";
            updateEquation();
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            currentEquation += "9";
            updateEquation();
        }

        private void bm_Click(object sender, RoutedEventArgs e)
        {
            currentEquation += "×";
            updateEquation();
        }

        private void b0_Click(object sender, RoutedEventArgs e)
        {
            currentEquation += "0";
            updateEquation();

        }

        private void bc_Click(object sender, RoutedEventArgs e)
        {
            currentEquation = "";
            updateEquation();
        }

        private void bp_Click(object sender, RoutedEventArgs e)
        {
            currentEquation += ".";
            updateEquation();
        }

        private void bd_Click(object sender, RoutedEventArgs e)
        {
            currentEquation += "÷";
            updateEquation();
        }
    }
}
