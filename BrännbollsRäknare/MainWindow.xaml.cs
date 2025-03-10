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

namespace BrännbollsRäknare;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    int poängUte = 0;
    int poängInne = 0;


    public MainWindow()
    {
        InitializeComponent();
    }

    private void PoängRäknare(object sender, RoutedEventArgs e)
    {
        this.Background = Brushes.AliceBlue;

        if (sender == Frivarv)
        {
            poängInne += 5;
            tbxLagInne.Text = poängInne.ToString();

            DateTime tid = DateTime.Now;

            tbxHistorik.Text += $"{tid.ToString("HH:mm:ss")} Frivarv + 5 \n";
        }

        if (sender == Bränning)
        {
            poängUte += 2;
            tbxLagUte.Text = poängUte.ToString();

            DateTime tid = DateTime.Now;


            tbxHistorik.Text += $"{tid.ToString("HH:mm:ss")} Bränning + 2 \n";
        }

        if (sender == Lyra)
        {
            poängUte += 3;
            tbxLagUte.Text = poängUte.ToString();

            DateTime tid = DateTime.Now;

            tbxHistorik.Text += $"{tid.ToString("HH:mm:ss")} Lyra + 3 \n";
        }

        if (sender == Varv)
        {
            poängInne += 1;
            tbxLagInne.Text = poängInne.ToString();

            DateTime tid = DateTime.Now;

            tbxHistorik.Text += $"{tid.ToString("HH:mm:ss")} Varv + 1 \n";
        }
    }
}