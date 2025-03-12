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

namespace Klapp_App;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    int maxJulklappar;
    List<String> julklappar = [];

    public MainWindow()
    {
        InitializeComponent();

        listan.IsEnabled = false;
        inmatning.IsEnabled = false;

    }

    private void KlickaMax(object sender, RoutedEventArgs e)
    {
        if (int.TryParse(txbAntal.Text, out int antal) && antal > 0)
        {
            maxJulklappar = antal;

            lstJulklappar.ItemsSource = julklappar;

            listan.IsEnabled = true;
            inmatning.IsEnabled = true;
            limit.IsEnabled = false;

            txbStatus.Text = "";
        }
        else
        {
            txbStatus.Text = "Ange ett positivt heltal";
            txbAntal.Text = "";
        }
    }

    private void KlickaLäggTill(object sender, RoutedEventArgs e)
    {
        if (julklappar.Count < maxJulklappar)
        {
            if (txbJulklapp.Text != "" && txbMottagare.Text != "")
            {
                string julklapp = $"{txbJulklapp.Text} till {txbMottagare.Text}";
                julklappar.Add(julklapp);
                lstJulklappar.Items.Refresh();

                txbJulklapp.Text = "";
                txbMottagare.Text = "";
            }
            else txbStatus.Text = "Ange både julklappa och mottagare ";
        }
        else txbStatus.Text = "Max antal julklappar har nåtts";
    }

    private void KlickaBytUt(object sender, RoutedEventArgs e)
    {
        if (lstJulklappar.SelectedIndex >= 0 && txbJulklapp.Text != "" && txbMottagare.Text != "")
        {
            string julklapp = $"{txbJulklapp.Text} till {txbMottagare.Text}";
            julklappar[lstJulklappar.SelectedIndex] = julklapp;
            lstJulklappar.Items.Refresh();
        }
        else txbStatus.Text = "Välj en julklapp och ange både julklapp och motagare";

        txbJulklapp.Text = "";
        txbMottagare.Text = "";
    }
}