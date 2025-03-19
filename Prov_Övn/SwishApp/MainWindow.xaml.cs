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

namespace SwishApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    int balans = Random.Shared.Next(1, 301);
    public MainWindow()
    {
        InitializeComponent();
        txbBalans.Text = $"{balans} kr";
    }

    private void KlickaSwisha(object sender, RoutedEventArgs e)
    {
        if (txbBelopp.Text != "" && int.TryParse(txbBelopp.Text, out int belopp) && belopp > 0)
        {
            lblStatus.Content = "";
            if (belopp < balans)
            {
                lblStatus.Content = $"Swishat: {belopp} kr";
                balans = balans-belopp;
                txbBalans.Text = $"{balans} kr";
            }
            else{
                lblStatus.Content = $"För lite pengar i kontot. \nDu saknar {belopp-balans} kr för at kunna swisha";
            }

        }
        else lblStatus.Content = "Belopp måste vara ett positivt heltal";

    }
}