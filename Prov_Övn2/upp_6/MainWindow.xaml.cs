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

namespace upp_6;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    double medelVärde = 0;
    double summa = 0;
    int antal = 0;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickAdd(object sender, RoutedEventArgs e)
    {
        if (!double.TryParse(txbTal.Text, out double tal)) MessageBox.Show("Felaktig inmatning");
        else
        {   
            txbSumma.Text = $"{summa} + {tal} = {tal+summa}";
            summa += tal;

            antal ++; 
            medelVärde =  summa/antal; 

            txbMedel.Text = $"{summa} / {antal} = {medelVärde}";
        }
    }
}