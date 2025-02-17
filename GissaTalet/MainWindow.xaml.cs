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

namespace GissaTalet;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private int slumpTal;
    private int antalFörsök = 0;

    public MainWindow()
    {
        InitializeComponent();
        slumpTal = Random.Shared.Next(1, 101);
        txbResultat.Text = "slumtal: " + slumpTal;
    }

    private void KlickaGissa(object sender, RoutedEventArgs e)
    {
        if (!int.TryParse(txbGissning.Text, out int gissning)) txbResultat.Text = "Inte ett heltal";
        else
        {
            if (gissning == slumpTal) txbResultat.Text = "Rätt svar";
            else txbResultat.Text = "Fel svar, försök igen";
            antalFörsök ++;

            lsbFörsök.Items.Add(int.Parse(txbGissning.Text));
            txbRäknare.Text = $"antal: {antalFörsök}";
        }
    }

    private void KlickaStart(object sender, RoutedEventArgs e)
    {
        slumpTal = Random.Shared.Next(1, 101);
        txbResultat.Text = "slumtal: " + slumpTal;
        lsbFörsök.Items.Clear();
        antalFörsök = 0;
        txbRäknare.Text = "";
    }

}
