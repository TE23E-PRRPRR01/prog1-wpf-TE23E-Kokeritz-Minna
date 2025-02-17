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

namespace Kontaktbok;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private List<(string, int)> kontaktLista = [];

    public MainWindow()
    {
        InitializeComponent();
    }

    private void LäggTill(object sender, RoutedEventArgs e)
    {
        string namn = txbNamn.Text;
        if (!int.TryParse(txbTelefon.Text, out int telfon)) txbTelefon.Text = "inte ett telfon Nummer";
        else if (namn != "")
        {
            lsbKontakter.Items.Add($"{namn} - {telfon}");

            txbNamn.Text = "";
            txbTelefon.Text = "";
        }
    }
}