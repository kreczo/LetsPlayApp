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



namespace LetsPlayApp
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow logwin = new LoginWindow();
            logwin.Show();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow regwin = new RegisterWindow();
            regwin.Show();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            MakeEventWindow mw = new MakeEventWindow();
            mw.Show();
        }
    }
}
