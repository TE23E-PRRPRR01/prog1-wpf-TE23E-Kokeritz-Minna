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

namespace Valapp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private int antalRöd = 0;
    private int antalBlå = 0;
    private int antalGrön = 0;
    private int antalGul = 0;
    private int antalLila = 0;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickaRösta(object sender, RoutedEventArgs e)
    {
        if (sender == röd) antalRöd++;
        if (sender == blå) antalBlå++;
        if (sender == grön) antalGrön++;
        if (sender == gul) antalGul++;
        if (sender == lila) antalLila++;

        txbResultat.Text = $"Röd: {antalRöd} \nBlå: {antalBlå} \nGrön: {antalGrön} \nGul: {antalGul} \nLila: {antalLila}";
    }

    private void KlickaReset(object sender, RoutedEventArgs e)
    {
        antalRöd = 0;
        antalBlå = 0;
        antalGrön = 0;
        antalGul = 0;
        antalLila = 0;
        txbResultat.Text = "";
    }
}