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
using System.Windows.Shapes;

namespace ITMO.DesktopCSharp.WPF.Lab.Ex02.WinDialog
{
    /// <summary>
    /// Логика взаимодействия для TaskWind.xaml
    /// </summary>
    public partial class TaskWind : Window
    {
        public string ViewModel { get; set; }

        public TaskWind()
        {
            InitializeComponent();
        }

        public void ShowViewModel()
        {
            this.Title = ViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wnd1 = this.Owner as MainWindow;
            wnd1.butMain.Content = textBox.Text;
            wnd1.Background = new SolidColorBrush(Colors.Green);
        }
    }
}
