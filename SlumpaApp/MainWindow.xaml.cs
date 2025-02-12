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

namespace SlumpaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Slumpa(object sender, RoutedEventArgs e)
    {
        int max;
        int slumpTal = 0;
        if (!int.TryParse(txbMax.Text, out max))
        {
            txbMedelande.Text = "Inte ett heltal, maxvärde blir default 100";
            slumpTal = Random.Shared.Next(1, 101);
        }
        else
        {
            txbMedelande.Text = "";
            slumpTal = Random.Shared.Next(1, max + 1);
        }
        txbSlump.Text = slumpTal.ToString();
    }

    private void Slumpa5(object sender, RoutedEventArgs e)
    {
        List<int> SlumpadeTal = [];

        for (int i = 0; i < 5; i++)
        {
            int slumpTal = Random.Shared.Next(1, 101);
            SlumpadeTal.Add(slumpTal);
        }
        
        lxbFlera.Items.Clear();
        for (int i = 0; i < SlumpadeTal.Count(); i++)
        {

            lxbFlera.Items.Add(SlumpadeTal[i]);
        }

        //txbFlera.Text = string.Join("\n", SlumpadeTal);
    }
}