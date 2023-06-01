using Browser_.NET.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Browser_.NET
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string[] types = { "" };
            Manager.GetFiles(@"C:\fl files",types, true);
            BrowserFiles.ItemsSource = Manager.CurrentBrowserFiles;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] types = { "" };
            Manager.GetFiles(@"C:\fl files",types, true);
            BrowserFiles.ItemsSource = Manager.CurrentBrowserFiles;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string[] types = { "mp3", "wav", "ogg" };
            Manager.GetFiles(@"C:\fl files", types, false);
            BrowserFiles.ItemsSource = Manager.CurrentBrowserFiles;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string[] types = { "jpg", "png", "bmp" };
            Manager.GetFiles(@"C:\fl files", types, false);
            BrowserFiles.ItemsSource = Manager.CurrentBrowserFiles;
        }
    }
}
