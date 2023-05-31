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
            List<BrowserFile> browserFiles = new List<BrowserFile>();
            Manager.CurrentBrowserFiles.Add(new BrowserFile("fl studio project 1", "20-20-2023", "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/i/0dfca4fd-eeaf-48f3-9627-155ab37b2416/dcrcrhr-dd612dc8-b124-4ec9-8f4d-7c45aaf6f32f.png"));
            Manager.CurrentBrowserFiles.Add(new BrowserFile("fl studio project 2", "20-20-2023", "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/i/0dfca4fd-eeaf-48f3-9627-155ab37b2416/dcrcrhr-dd612dc8-b124-4ec9-8f4d-7c45aaf6f32f.png"));
            Manager.CurrentBrowserFiles.Add(new BrowserFile("fl studio project 3", "20-20-2023", "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/i/0dfca4fd-eeaf-48f3-9627-155ab37b2416/dcrcrhr-dd612dc8-b124-4ec9-8f4d-7c45aaf6f32f.png"));
            Manager.CurrentBrowserFiles.Add(new BrowserFile("asdasd", "20-20-2023", "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/i/0dfca4fd-eeaf-48f3-9627-155ab37b2416/dcrcrhr-dd612dc8-b124-4ec9-8f4d-7c45aaf6f32f.png"));
            Manager.CurrentBrowserFiles.Add(new BrowserFile("wqeqwe dsaads", "20-20-2023", "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/i/0dfca4fd-eeaf-48f3-9627-155ab37b2416/dcrcrhr-dd612dc8-b124-4ec9-8f4d-7c45aaf6f32f.png"));
            BrowserFiles.ItemsSource = Manager.CurrentBrowserFiles;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BrowserFiles.ItemsSource = Manager.CurrentBrowserFiles;
        }
    }
}
