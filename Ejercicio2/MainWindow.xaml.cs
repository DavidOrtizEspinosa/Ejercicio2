using System;
using System.Windows;
using System.Windows.Controls;


namespace Ejercicio2
{
  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }



        private void operacionButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (operacionTextBox.Text)
                {
                    case "+":
                        resultadoTexxtBox.Text = (int.Parse(numero1TextBox.Text) + int.Parse(numero2TextBox.Text)).ToString();
                        break;
                    case "-":
                        resultadoTexxtBox.Text = (int.Parse(numero1TextBox.Text) - int.Parse(numero2TextBox.Text)).ToString();
                        break;
                    case "*":
                        resultadoTexxtBox.Text = (int.Parse(numero1TextBox.Text) * int.Parse(numero2TextBox.Text)).ToString();
                        break;
                    case "/":
                        resultadoTexxtBox.Text = (int.Parse(numero1TextBox.Text) / int.Parse(numero2TextBox.Text)).ToString();
                        break;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error en los operandos");

            }
           
        }

        private void reiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            operacionTextBox.Text = "";
            numero1TextBox.Text = "";
            numero2TextBox.Text = "";
            resultadoTexxtBox.Text = "";
        }

        private void operacionTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (operacionTextBox.Text == "+" || operacionTextBox.Text == "-" || operacionTextBox.Text == "*" || operacionTextBox.Text == "/")
            {
                operacionButton.IsEnabled = true;

            }
            else
            {
                operacionButton.IsEnabled = false;
            }
        }
    }
}
