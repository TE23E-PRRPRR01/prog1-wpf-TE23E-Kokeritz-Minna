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

namespace Bakgrundfärg;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickRöd(object sender, RoutedEventArgs e)
    {
        this.Background = Brushes.Red;
    }

      private void KlickGrön(object sender, RoutedEventArgs e)
    {
        this.Background = Brushes.Green;
    }  
    
    private void KlickBlå(object sender, RoutedEventArgs e)
    {
        this.Background = Brushes.Blue;
    }

    private void Klick(object sender, RoutedEventArgs e)
    {
        if(sender == "Gul") this.Background=Brushes.Yellow;
    }
  
}