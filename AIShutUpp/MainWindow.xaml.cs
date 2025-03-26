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
using System.Net.Http;
using System.Net.Http.Json;

namespace AIShutUpp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    HttpClient klient = new HttpClient();
    string url = "http://10.151.168.5:11434/api/generate";

    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickSkicka(object sender, RoutedEventArgs e)
    {

        // läsa av promttexten
        string prompt = txbPrompt.Text;

        // skapa ett json-objekt
        object data = new
        {
            model = "phi4:latest",
            prompt = prompt,
            max_tokens = 50
        };

        // skicka till ollama-ai-servern
        SkickaTillOllama(data);
    }

    public void SkickaTillOllama(object data)
    {
        try
        {
            HttpResponseMessage svar = klient.PostAsJsonAsync(url, data).Result;

            // kontrollera att "requesten" lyckades
            svar.EnsureSuccessStatusCode();


            // läs innehället i svaret
            string råText = svar.Content.ReadAsStringAsync().Result;


            //Dela upp råtexten i rader
            string[] rader = råText.Split("\n");

            // gå igenom alla rader
            foreach (string rad in rader)
            {
                // finns response

                if(rad.Contains("response")){
                   txbSvar.Text += PlockaUtToken(rad);
                }
            }
        }
        catch (HttpRequestException e)
        {
            txbSvar.Text = $"Fel: {e.Message}";
            throw;
        }
    }

    public string PlockaUtToken(string rad)
    {
        int start = rad.IndexOf("response") + 11;
        int end = rad.IndexOf("\"", start);   

        // plocka ut token
        return rad.Substring(start, end - start);
    }
}