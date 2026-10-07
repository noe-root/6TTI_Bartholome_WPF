using System.Reflection.Metadata;
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

namespace _6TTI_Bartholome_WPF_Act2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBoxA.PreviewTextInput += TxtTextBlockA_PreviewTextInput;
            TextBoxB.PreviewTextInput += TxtTextBlockB_PreviewTextInput;
            TextBoxC.PreviewTextInput += TxtTextBlockC_PreviewTextInput;
            btnCalculer.Click += BtnCalculer_Click;
            btnCalculer.MouseEnter += btnValider_MouseEnter;
            btnCalculer.MouseLeave += btnValider_MouseLeave;
        }
        private void TxtTextBlockA_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!int.TryParse(e.Text, out int n))
            {
                e.Handled = true;
            }
            else if (((TextBox)sender).Text.Length >= 4)
            {
                e.Handled = true;
            }
        }
        private void TxtTextBlockB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!int.TryParse(e.Text, out int n))
            {
                e.Handled = true;
            }
            else if (((TextBox)sender).Text.Length >= 4)
            {
                e.Handled = true;
            }
        }
        private void TxtTextBlockC_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!int.TryParse(e.Text, out int n))
            {
                e.Handled = true;
            }
            else if (((TextBox)sender).Text.Length >= 4)
            {
                e.Handled = true;
            }
        }        
        private void BtnCommencer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Début traitement");
        }
        private void btnValider_MouseEnter(object sender, MouseEventArgs e)
        {           
            btnValider.Visibility = Visibility.Visible;            
            TextBoxA.Background = Brushes.Black;
            TextBoxB.Background = Brushes.Black;
            TextBoxC.Background = Brushes.Black;
        }
        private void btnValider_MouseLeave(object sender, MouseEventArgs e)
        {
            btnValider.Visibility = Visibility.Hidden;            
            TextBoxA.Background = Brushes.White;
            TextBoxB.Background = Brushes.White;
            TextBoxC.Background = Brushes.White;
        }
        private void BtnCalculer_Click(object sender, RoutedEventArgs e)
        {
            string message = "";
            double a = double.Parse(TextBoxA.Text);
            double b = double.Parse(TextBoxB.Text);
            double c = double.Parse(TextBoxC.Text);
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta < 0)
            {
                message = "Il n'y a pas de solution réelle";

            }
            else if (delta == 0)
            {
                double x1 = -b / (2 * a);
                message = "Il y a une solution " + x1;
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                message = "Il y a deux solutions " + x1 + " et " + x2;
                }            
            new PageResultat(message).Show();
        }
        
    }
}