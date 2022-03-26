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

namespace BibliotekaZKLJ
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

        private void Kupi(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Dodao si uspesno");
        }

        private void Vreme_TextInput(object sender, TextCompositionEventArgs e)
        {
            
        }

        private void Vreme_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }

        private void Vreme(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString());
        }

        private void Registracija(object sender, RoutedEventArgs e)
        {


                Login log = new();
                log.Owner = this;
                log.ShowDialog();
            
        }
    }
}
