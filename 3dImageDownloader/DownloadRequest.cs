using System.Collections.Generic;

namespace _3dImageDownloader
{
    public class DownloadRequest
    {
        public List<string> Images { get; set; } = new List<string>();
        public string Author { get; set; } = "";
        public string ProductName { get; set; } = "";
        public string Url { get; set; } = "";
        public bool CompleteData => Author != "" && ProductName != "";
    }
}