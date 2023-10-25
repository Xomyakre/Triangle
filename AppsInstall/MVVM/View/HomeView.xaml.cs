using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System;
using System.Threading;
using System.Threading.Tasks;


namespace AppsInstall.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();



        }



        private void Result_Click(object sender, RoutedEventArgs e)
        {

            //double sideA = double.Parse(sideATextBox.Text);
            //double sideB = double.Parse(sideBTextBox.Text);
            //double sideC = double.Parse(sideCTextBox.Text);

            //// Проверка типа треугольника
            //if (sideA == sideB && sideB == sideC)
            //{
            //    resultTextBlock.Text = "Равносторонний треугольник";
            //}
            //else if (sideA == sideB || sideA == sideC || sideB == sideC)
            //{
            //    resultTextBlock.Text = "Равнобедренный треугольник";
            //}
            //else
            //{
            //    resultTextBlock.Text = "Разносторонний треугольник";
            //}

            //try
            //{
            //    double side1 = Convert.ToDouble(side1TextBox.Text);
            //    double side2 = Convert.ToDouble(side2TextBox.Text);
            //    double side3 = Convert.ToDouble(side3TextBox.Text);
            //    if (side1 + side2 >= side3 && side2 + side3 >= side1 && side1 + side3 >= side2)
            //    {
            //        if (side1 == side2 && side2 == side3 && side1 == side3)
            //        {
            //            MessageBox.Show("Треугольник равносторонний");
            //        }
            //        else if (side1 == side2 || side1 == side3 || side2 == side3)
            //        {
            //            MessageBox.Show("Треугольник равнобедренный");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Треугольник разносторонний");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Треугольника не существует");
            //    }



            //}
            //catch
            //{
            //    MessageBox.Show("Введите значения сторон треугольника");
            //}

            //    if (!IsValidInput())
            //    {
            //        resultTextBlock.Text = "Ошибка: некорректный ввод сторон треугольника.";
            //        return;
            //    }

            //    double side1 = double.Parse(sideATextBox.Text);
            //    double side2 = double.Parse(sideBTextBox.Text);
            //    double side3 = double.Parse(sideCTextBox.Text);

            //    if (side1 == side2 && side2 == side3)
            //    {
            //        resultTextBlock.Text = "Треугольник - равносторонний.";
            //    }
            //    else if (side1 == side2 || side1 == side3 || side2 == side3)
            //    {
            //        resultTextBlock.Text = "Треугольник - равнобедренный.";
            //    }
            //    else
            //    {
            //        resultTextBlock.Text = "Треугольник - разносторонний.";
            //    }
            //}

            //private bool IsValidInput()
            //{
            //    return double.TryParse(sideATextBox.Text, out _) &&
            //           double.TryParse(sideBTextBox.Text, out _) &&
            //           double.TryParse(sideCTextBox.Text, out _) &&
            //           double.Parse(sideATextBox.Text) > 0 &&
            //           double.Parse(sideBTextBox.Text) > 0 &&
            //           double.Parse(sideCTextBox.Text) > 0;
            //}


            //try
            //{
            //    double side1 = double.Parse(sideATextBox.Text);
            //    double side2 = double.Parse(sideBTextBox.Text);
            //    double side3 = double.Parse(sideCTextBox.Text);

            //    if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            //    {
            //        MessageBox.Show("Значения сторон должны быть положительными числами.");
            //        return;
            //    }

            //    if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
            //    {
            //        MessageBox.Show("Треугольник с такими сторонами не существует.");
            //        return;
            //    }

            //    if (side1 == side2 && side2 == side3)
            //    {
            //        MessageBox.Show("Треугольник равносторонний.");
            //    }
            //    else if (side1 == side2 || side1 == side3 || side2 == side3)
            //    {
            //        MessageBox.Show("Треугольник равнобедренный.");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Треугольник разносторонний.");
            //    }
            //}
            //catch (FormatException)
            //{
            //    MessageBox.Show("Некорректный ввод значений сторон.");
            //}


            if (!IsValidInput())
            {
                resultTextBlock.Text = "Ошибка: некорректный ввод сторон треугольника.";
                return;
            }

            double side1 = double.Parse(side1TextBox.Text);
            double side2 = double.Parse(side2TextBox.Text);
            double side3 = double.Parse(side3TextBox.Text);

            if (side1 == side2 && side2 == side3)
            {
                resultTextBlock.Text = "Треугольник - равносторонний.";
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                resultTextBlock.Text = "Треугольник - равнобедренный.";
            }
            else
            {
                resultTextBlock.Text = "Треугольник - разносторонний.";
            }
        }

        private bool IsValidInput()
        {
            return double.TryParse(side1TextBox.Text, out _) &&
                   double.TryParse(side2TextBox.Text, out _) &&
                   double.TryParse(side3TextBox.Text, out _) &&
                   double.Parse(side1TextBox.Text) > 0 &&
                   double.Parse(side2TextBox.Text) > 0 &&
                   double.Parse(side3TextBox.Text) > 0;
        }
    }
}
        




