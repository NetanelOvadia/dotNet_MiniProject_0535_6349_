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

namespace MiniProject_UI
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

        private void settings_MouseEnter(object sender, MouseEventArgs e)
        {
            designedButtonWithDetails tmp = sender as designedButtonWithDetails;
            tmp.Foreground = Brushes.Blue;
            tmp.Cursor = Cursors.Hand;
        }

        private void settings_MouseLeave(object sender, MouseEventArgs e)
        {
            designedButtonWithDetails tmp = sender as designedButtonWithDetails;
            tmp.Foreground = Brushes.Black;
            tmp.Cursor = Cursors.None;
        }
    }
}
