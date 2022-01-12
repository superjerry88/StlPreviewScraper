using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace _3dImageDownloader
{
    public partial class Form1 : Form
    {
        private int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Btn_download_Click(object sender, EventArgs e)
        {
            var url = Txt_url.Text;
            Label_count.InvokeIfRequired(_ =>
            {
                counter++;
                Label_count.Text = counter.ToString();
            });
            Log($"[Starting] {url}");

            await Task.Run(() =>
            {
                ProcessLink(url);
            });

            Label_count.InvokeIfRequired(_ =>
            {
                counter--;
                Label_count.Text = counter.ToString();
            });

            Log($"[Complete] {url}");
        }

        private void Btn_outputFolder_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(GetBasePath());
            Process.Start("explorer.exe", GetBasePath());
        }

        private void Log(string msg)
        {
            Txt_output.InvokeIfRequired(_ =>
            {
                Txt_output.AppendText($"[{DateTime.Now:T}] {msg}\n");
            });
        }

    }


}
