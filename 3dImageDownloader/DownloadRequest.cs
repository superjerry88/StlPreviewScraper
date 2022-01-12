using System.Collections.Generic;
using System.IO;

namespace _3dImageDownloader
{
    public class DownloadRequest
    {
        public List<string> Images { get; set; } = new List<string>();
        public string Author { get; set; } = "";
        public string ProductName { get; set; } = "";
        public string Url { get; set; } = "";
        public bool CompleteData => Author != "" && ProductName != "";

        public Dictionary<string, int> FileCounter = new Dictionary<string, int>();

        public string GetFileName(string filename)
        {
            if (!FileCounter.ContainsKey(filename))
            {
                FileCounter.Add(filename,0);
            }
            else
            {
                FileCounter[filename]++;
                var arr = filename.Split(".");
                arr[^2] = $"{arr[^2]}{FileCounter[filename]}";
                filename = string.Join(".", arr);
            }
            return filename;
        }
    }
}