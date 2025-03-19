using System.Runtime.Intrinsics.X86;
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

namespace luffarschack;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    bool player1Turn = true;
    int Xpoäng = 0;
    int Opoäng = 0;


    public MainWindow()
    {
        InitializeComponent();
    }

    private void Restart(object sender, RoutedEventArgs e)
    {
        b1.Content = ".";
        b2.Content = ".";
        b3.Content = ".";
        b4.Content = ".";
        b5.Content = ".";
        b6.Content = ".";
        b7.Content = ".";
        b8.Content = ".";
        b9.Content = ".";

        b1.IsEnabled = true;
        b2.IsEnabled = true;
        b3.IsEnabled = true;
        b4.IsEnabled = true;
        b5.IsEnabled = true;
        b6.IsEnabled = true;
        b7.IsEnabled = true;
        b8.IsEnabled = true;
        b9.IsEnabled = true;

    }

    private void KlickKnapp(object sender, RoutedEventArgs e)
    {
        string spelare;

        Button knapp = (Button)sender;
        knapp.IsEnabled = false;
        knapp.Content = player1Turn ? "X" : "O";

        if (KontrollVinst())
        {
            MessageBox.Show($"Spelare {(player1Turn ? "X" : "O")} vann !!");

            if (player1Turn)
            {
                Xpoäng += 1;
                poängX.Text = $"Poäng X: {Xpoäng}";
            }
            else
            {
                Opoäng +=1;
                poängO.Text = $"Poäng O: {Opoäng}";
            }

            b1.IsEnabled = false;
            b2.IsEnabled = false;
            b3.IsEnabled = false;
            b4.IsEnabled = false;
            b5.IsEnabled = false;
            b6.IsEnabled = false;
            b7.IsEnabled = false;
            b8.IsEnabled = false;
            b9.IsEnabled = false;

        }



        player1Turn = !player1Turn;
    }

    private bool KontrollVinst()
    {
        if (KontrollRad() || KontrollKol() || KontrollDia()) return true;
        else return false;
    }

    private bool KontrollRad()
    {
        if (b1.Content == b2.Content && b2.Content == b3.Content && (b1.Content == "X" || b1.Content == "O")) return true;
        else if (b4.Content == b5.Content && b5.Content == b6.Content && (b4.Content == "X" || b4.Content == "O")) return true;
        else if (b7.Content == b8.Content && b8.Content == b9.Content && (b7.Content == "X" || b7.Content == "O")) return true;
        else return false;
    }
    private bool KontrollKol()
    {
        if (b1.Content == b4.Content && b4.Content == b7.Content && (b1.Content == "X" || b1.Content == "O")) return true;
        else if (b2.Content == b5.Content && b5.Content == b8.Content && (b2.Content == "X" || b2.Content == "O")) return true;
        else if (b3.Content == b6.Content && b6.Content == b9.Content && (b3.Content == "X" || b3.Content == "O")) return true;
        else return false;
    }

    private bool KontrollDia()
    {
        if (b1.Content == b5.Content && b5.Content == b9.Content && (b1.Content == "X" || b1.Content == "O")) return true;
        else if (b3.Content == b5.Content && b5.Content == b7.Content && (b3.Content == "X" || b3.Content == "O")) return true;
        else return false;
    }


}

