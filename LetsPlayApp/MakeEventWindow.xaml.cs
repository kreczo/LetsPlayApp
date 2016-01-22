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

namespace LetsPlayApp
{
    /// <summary>
    /// Interaction logic for MakeEventWindow.xaml
    /// </summary>
    public partial class MakeEventWindow : Window
    {
        public MakeEventWindow()
        {
            InitializeComponent();
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
