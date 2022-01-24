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

namespace WPF_Lab_1._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Set_Name.IsEnabled = false;
            Ret_Name.IsEnabled = false;
        }

        private void Set_Name_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter("F:\\username.txt");
                sw.WriteLine (textBox.Text);
                sw.Close();
                Ret_Name.IsEnabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Ret_Name_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader("F:\\username.txt");
                label.Content = "Приветствую Вас, уважаемый " + sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Set_Name.IsEnabled = true;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            myTextBox.Text = DateTime.Now.ToString();
        }
    }
}
