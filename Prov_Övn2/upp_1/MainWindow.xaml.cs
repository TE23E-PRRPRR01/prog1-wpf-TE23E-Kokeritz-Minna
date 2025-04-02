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

namespace upp_1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickKryptera(object sender, RoutedEventArgs e)
    {
        this.Background = Brushes.AntiqueWhite;

        int nyckel = 0;
        if (!int.TryParse(txbNyckel.Text, out nyckel))
        {
             txbResult.Text = "Nyckel måste vara ett heltal mellan 1-9";
        }
        else
        {
            string kryptadText = "";

            for (int i = 0; i < txbText.Text.Length; i++)
            {
                char bokstav = txbText.Text[i];
                Console.WriteLine($"Bokstaven på position {i} är {bokstav}");

                int ascii = (int)bokstav;
                Console.WriteLine($"{bokstav} är {ascii}");

                int kryptadAscii = ascii + nyckel;

                if (kryptadAscii >= 90)
                {
                    kryptadAscii -= 26;
                }

                char kryptadBokstav = (char)(kryptadAscii);

                kryptadText += kryptadBokstav.ToString();
            }

            txbResult.Text = $"{kryptadText}";

        }
    }
}