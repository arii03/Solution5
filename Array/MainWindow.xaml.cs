using System;
using System.Collections.Generic;
using System.IO;
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

namespace Array
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

        int c = 0;
        string[] mess = new string[5];
        
        private void btnInserisci_Click(object sender, RoutedEventArgs e)
        {
            c++;
            for (int i = 0; i < 5; i++)
                mess[c - 1] = txtStringa.Text;
            if (c == 5)
            {
                btnInserisci.IsEnabled = false;
                btnStampa.IsEnabled = true;
                btnPubblica.IsEnabled = true;
            }
            txtStringa.Clear();
        }

        private void btnStampa_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 5; i++)
                lblRisposta.Content += $"{i+1}° posizione {mess[i]} \n";
        }

        private void btnPubblica_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("pubblica.txt", false, Encoding.UTF8);
            for (int i = 0; i < 5; i++)
                sw.WriteLine($"{i + 1}° posizione {mess[i]} \n");
            sw.Flush();
            sw.Close();
        }
    }
}
