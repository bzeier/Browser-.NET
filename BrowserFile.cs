using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browser_.NET.Source
{
    class BrowserFile
    {
        public string Title { get; set; }
        public string LastModified { get; set; }
        public string ImageUrl { get; set; }

        public BrowserFile(string title, string lastModified, string imageUrl) {
            this.Title = title;
            this.LastModified = lastModified;  
            this.ImageUrl = imageUrl;
        }
    }
}
