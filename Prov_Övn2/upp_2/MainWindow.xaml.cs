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
        if(!double.TryParse(txbTal1.Text, out double tal1) || !double.TryParse(txbTal2.Text, out double tal2)) MessageBox.Show("Felaktig inmatning.\nFormatera talen som tex 12 eller 12,5");
        else {

            if(sender == plus) txbReusltat.Text = $"{tal1} + {tal2} = {tal1 + tal2}";
            else if (sender == minus) txbReusltat.Text = $"{tal1} - {tal2} = {tal1 - tal2}";
            else if (sender == multi) txbReusltat.Text = $"{tal1} * {tal2} = {tal1 * tal2}";
            else if (sender == divi) txbReusltat.Text = $"{tal1} / {tal2} = {tal1 / tal2}";
            else this.Background = Brushes.AliceBlue;
        }
    }
}