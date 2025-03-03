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
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Net;

namespace EpostApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickaSkicka(object sender, RoutedEventArgs e)
    {
        string epost = tbxEpost.Text;
        string text = tbxText.Text;

        string regexEpost = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"; 

        /* SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        smtp.EnableSsl = true;
        smtp.Credentials = new NetworkCredential("minna.kokeritz@elev.ga.ntig.se","YA8ZRUaC"); */
        

        if (!Regex.IsMatch(epost, regexEpost)) lblStatus.Content = "Du måste skriva in en epostaddress";
        else
        {
           // smtp.Send("minna.kokeritz@elev.ga.ntig.se", epost, "Medelande från Wpf", text);
            lblStatus.Content = "Meddelande skickades";
        }

    }

    private void ChangedEpost(object sender, RoutedEventArgs e)
    {
        string epost = tbxEpost.Text;
        string regexEpost = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"; 

        if (!Regex.IsMatch(epost, regexEpost)) lblStatus.Content = "Du måste skriva in en epostaddress";
        else lblStatus.Content = "epost är OK";

    }
}
