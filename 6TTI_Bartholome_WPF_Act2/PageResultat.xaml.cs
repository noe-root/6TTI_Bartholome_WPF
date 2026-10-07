using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _6TTI_Bartholome_WPF_Act2
{
    /// <summary>
    /// Logique d'interaction pour PageResultat.xaml
    /// </summary>
    public partial class PageResultat : Window
    {
        public PageResultat(string message)
        {
            InitializeComponent();
            txtMessage.Text = message;
            btnRetour.Click += btnFermer_Click;
        }
        public void btnFermer_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
