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

namespace ITMO.DesktopCSharp.WPF.Lab.Ex02.WinDialog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void butMain_Click(object sender, RoutedEventArgs e)
        {
            TaskWind taskWindow = new TaskWind();
            taskWindow.Owner = this;
            taskWindow.ViewModel = "ViewModel";
            taskWindow.ShowViewModel();
            taskWindow.Show();
        }

        private void butLogin_Click(object sender, RoutedEventArgs e)
        {
            PasswordWindow passwordWindow = new PasswordWindow();
            if (passwordWindow.ShowDialog() == true)
            {
                if (passwordWindow.Password == "qwerty")
                    MessageBox.Show("Авторизация пройдена",
                                    "Пароль",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information);
                else
                    MessageBox.Show("Неверный пароль", 
                                    "Пароль",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Авторизация не пройдена", "Пароль",
                MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
