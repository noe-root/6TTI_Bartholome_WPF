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

namespace _6TTI_Bartholome_Act3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnPage1.Click += BtnPage1_Click;
            btnPage2.Click += BtnPage2_Click;
            btnQuitter.Click += BtnQuitter_Click;
        }

        private void BtnPage1_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Views.Page_1());
        }

        private void BtnPage2_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Views.Page_2());
        }

        private void BtnQuitter_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}