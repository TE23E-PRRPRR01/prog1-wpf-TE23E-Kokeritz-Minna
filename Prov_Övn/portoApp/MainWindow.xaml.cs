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

namespace portoApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickaBeräkna(object sender, RoutedEventArgs e)
    {
        bool heltal = int.TryParse(txbVikt.Text, out int vikt);
        if (!heltal || vikt < 0){
            txbVikt.Text = "Inte en riktig vikt i heltal: default 0g";
            vikt = 0;
        } 
            
        
        if(vikt > 0 && vikt <= 50) lblResultat.Content = $"Brev som väger {vikt}g kostar 22kr (1 frimärke)";
        else if(vikt > 50 && vikt <= 100) lblResultat.Content = $"Brev som väger {vikt}g kostar 44kr (2 frimärke)";
        else if(vikt > 100 && vikt <= 250) lblResultat.Content = $"Brev som väger {vikt}g kostar 66kr (3 frimärke)";
        else if(vikt > 250 && vikt <= 500) lblResultat.Content = $"Brev som väger {vikt}g kostar 88kr (4 frimärke)";
        else if(vikt > 500 && vikt <= 1000) lblResultat.Content = $"Brev som väger {vikt}g kostar 132kr (6 frimärke)";
        else if(vikt > 1000 && vikt <= 2000) lblResultat.Content = $"Brev som väger {vikt}g kostar 154kr (7 frimärke)";
        else if(vikt > 2000) lblResultat.Content = $"Brev väger för mycket";
        else lblResultat.Content = "Något blev fel";
    }
}