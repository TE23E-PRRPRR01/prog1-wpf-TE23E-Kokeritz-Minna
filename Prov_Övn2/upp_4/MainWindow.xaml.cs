﻿using System.IO;
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

namespace upp_4;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickÖppna(object sender, RoutedEventArgs e)
    {
        if(!File.Exists(txbFilNamn.Text)) MessageBox.Show("Fel: fil finns inte");
        else  {
            txbResult.Text = File.ReadAllText(txbFilNamn.Text);
        }
    }
}