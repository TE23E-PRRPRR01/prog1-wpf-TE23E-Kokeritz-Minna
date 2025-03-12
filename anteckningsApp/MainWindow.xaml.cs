using System.IO;
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

namespace anteckningsApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    List<String> anteckningar = [];
    
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickaSkicka(object sender, RoutedEventArgs e)
    {
        txbNote.Text += $"- {txbInput.Text} \n";
        anteckningar.Add(txbInput.Text);
        txbInput.Text = "";
    }

    private void KlickaSpara(object sender, RoutedEventArgs e)
    {
        File.AppendAllLines("anteckningar.txt", anteckningar);
    }

    private void KlickaRensa(object sender, RoutedEventArgs e)
    {
        txbNote.Text = "";
    }
}