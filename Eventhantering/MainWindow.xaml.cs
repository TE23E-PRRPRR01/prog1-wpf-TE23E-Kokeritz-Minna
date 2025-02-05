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

namespace Eventhantering;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    
    private void KlickOK(object sender, RoutedEventArgs e)
    {
       MessageBox.Show("Du klickade på OK");
        string text = tbxText.Text;
        MessageBox.Show($"Du skrev: {text}");
        tbxResultat.Text = text;
    }

    private void KlickAvbryt(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Du klickade på Avbryt");
        Close();
    }
}