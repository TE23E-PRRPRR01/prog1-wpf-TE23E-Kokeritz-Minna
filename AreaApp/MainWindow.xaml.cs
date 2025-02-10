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

namespace AreaApp;

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
        //int bredd = int.Parse(txbBredd.Text);
        //int höjd = int.Parse(txbHöjd.Text);

        if (!int.TryParse(txbBredd.Text, out int bredd)) txbArea.Text = "Fel på bredd, Ange heltal";
        else if (!int.TryParse(txbHöjd.Text, out int höjd)) txbArea.Text = "Fel på Höjd, Ange heltal";
        else
        {
            int area = bredd * höjd;
            txbArea.Text = area.ToString();
        }
    }

    private void KlickaRensa(object sender, RoutedEventArgs e)
    {
        txbArea.Text = "";
        txbBredd.Text = "";
        txbHöjd.Text = "";
    }
}