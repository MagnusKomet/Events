using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.ComponentModel;

namespace Events
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Has clicat el botó 1!!!!!!!!!!!!!!!! \nEs propaga");
            //Trace.WriteLine("Text");
            MessageBox.Show("Has clicat el botó 1!!!!!!!!!!!!!!!! \nEs propaga");
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Has clicat el botó 2!!!!!!!!!!!!!!!! \nEs propaga");
            //Trace.WriteLine("Text");
            MessageBox.Show("Has clicat el botó 2!!!!!!!!!!!!!!!! \nEs propaga");
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Has clicat el botó 3!!!!!!!!!!!!!!!! \nNo es propaga");
            //Trace.WriteLine("Text");
            MessageBox.Show("Has clicat el botó 3!!!!!!!!!!!!!!!! \nNo es propaga");
            e.Handled = true;
        }

        /*
        // Tunneling
        private void Panel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("Has clicat l'stack !!!!!!!!!!!!!!!!");
            MessageBox.Show("Has clicat l'stack !!!!!!!!!!!!!!!!");
        }
        */
         
        // Bubbling
        private void Panel_Click(object sender, RoutedEventArgs e)
        {

            Debug.WriteLine("Has clicat l'stack !!!!!!!!!!!!!!!! \nOrigen:\n" + e.OriginalSource.ToString());
            MessageBox.Show("Has clicat l'stack !!!!!!!!!!!!!!!! \nOrigen:\n" + e.OriginalSource.ToString());
            
        }
        

    }
}