using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browser_.NET.Source
{
    static class Manager
    {
        public static List<BrowserFile> CurrentBrowserFiles = new List<BrowserFile>();

        public static void GetFiles(string path)
        {
            CurrentBrowserFiles.Clear();
            System.IO.DirectoryInfo dir = new DirectoryInfo(path);
            foreach(System.IO.FileInfo file in dir.GetFiles())
            {
                BrowserFile browserFile = new BrowserFile(file.FullName, file.LastAccessTime.ToString(), "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/i/0dfca4fd-eeaf-48f3-9627-155ab37b2416/dcrcrhr-dd612dc8-b124-4ec9-8f4d-7c45aaf6f32f.png");
                CurrentBrowserFiles.Add(browserFile);
            }
        }
    }
}
