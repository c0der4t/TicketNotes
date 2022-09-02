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

namespace ticketnotes
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

        private void btnCopyNotes_Click(object sender, RoutedEventArgs e)
        {
            string Notes = redtNotes.Text;
            Clipboard.SetText(Notes);
        }

        private void btntabNotes_Click(object sender, RoutedEventArgs e)
        {
            tbctrlContent.SelectedIndex = 0;
        }

        private void btntabSettings_Click(object sender, RoutedEventArgs e)
        {
            tbctrlContent.SelectedIndex = 1;
        }

        private void redtNotes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                redtNotes.AppendText(edtsettings_LinePrefix.Text.ToString());
            }
        }
    }
}
