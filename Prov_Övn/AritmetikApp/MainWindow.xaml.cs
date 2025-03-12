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

namespace AritmetikApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickaRäkna(object sender, RoutedEventArgs e)
    {
        if (int.TryParse(txbTal1.Text, out int tal1) && int.TryParse(txbTal2.Text, out int tal2))
        {
            lblResultat.Content = "";
            if (txbOperator.Text == "-" || txbOperator.Text == "/" || txbOperator.Text == "+" || txbOperator.Text == "*")
            {
                if (txbOperator.Text == "-")   lblResultat.Content = $"{tal1-tal2}"; 
                if (txbOperator.Text == "/")   lblResultat.Content = $"{tal1/tal2}"; 
                if (txbOperator.Text == "+")   lblResultat.Content = $"{tal1+tal2}"; 
                if (txbOperator.Text == "*")   lblResultat.Content = $"{tal1*tal2}"; 

                this.Background = Brushes.AliceBlue;
            }
            else lblResultat.Content = "Invalid Operator";
        }
        else
        {
            lblResultat.Content = "Tal 1 och Tal 2 måste vara heltal";
            txbTal1.Text = "";
            txbTal2.Text = "";
        }

    }
}