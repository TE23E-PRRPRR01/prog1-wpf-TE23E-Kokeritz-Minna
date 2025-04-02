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

namespace upp_2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickRäkna(object sender, RoutedEventArgs e)
    {
        if(!double.TryParse(txbTal1.Text, out double tal1)) txbReusltat.Text = "Tal 1 måste vara ett tal";
        else if(!double.TryParse(txbTal2.Text, out double tal2)) txbReusltat.Text= "Tal 2 måste vara ett tal";
        else {

            if(sender == plus) txbReusltat.Text = $"{tal1} + {tal2} = {tal1 + tal2}";
            else if (sender == minus) txbReusltat.Text = $"{tal1} - {tal2} = {tal1 - tal2}";
            else if (sender == multi) txbReusltat.Text = $"{tal1} * {tal2} = {tal1 * tal2}";
            else if (sender == divi) txbReusltat.Text = $"{tal1} / {tal2} = {tal1 / tal2}";
            else this.Background = Brushes.AliceBlue;
        }
    }
}