﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3dImageDownloader;
using HtmlAgilityPack;
using Newtonsoft.Json;

namespace _3dImageDownloader
{
    public partial class Form1 : Form
    {
        private void ProcessLink(string url)
        {
            try
            {
                if (url.Contains("cgtrader.com"))
                {
                    Process_cgtrader(url);
                    return;
                }

                if (url.Contains("myminifactory.com"))
                {
                    Process_mmf(url);
                    return;
                }

                if (url.Contains("cults3d.com"))
                {
                    Process_cults(url);
                    return;
                }

                if (url.Contains("comicsgamesandthings.com"))
                {
                    Process_cgnt(url);
                    return;
                }

                Log($"[Error - Link not supported] {url} ");
            }
            catch (Exception e)
            {
                Log(e.Message);
            }
        }

        private void Process_cgnt(string url)
        {
            var request = new DownloadRequest();
            var web = new HtmlWeb();
            var doc = web.Load(url);

            request.Url = url; 
            //request.Author = doc.DocumentNode.SelectNodes("//*[@id=\"content\"]/div[2]/div[2]/div[7]/div[1]/a/span").FirstOrDefault().InnerText;
            request.ProductName = doc.DocumentNode.SelectNodes("/html/body/main/div/div/div[1]/div[1]/h1").FirstOrDefault().InnerText;

            var json = doc.DocumentNode.SelectNodes("/html/body/script[5]").FirstOrDefault().InnerHtml;
            var data = JsonConvert.DeserializeObject<CgntData>(json);
            request.Author = data.Partner.Name;

            //Get images
            var ele = doc.DocumentNode.SelectNodes("//img");
            foreach (var node in ele)
            {
                if (node.HasClass("card-image") || node.HasClass("img-thumbnail"))
                {
                    request.Images.Add(node.GetAttributeValue("src", ""));
                }
            }

            CreateDirectory(request);
            Log($"[Output] {GetOutputPath(request)}");
        }

        private void Process_cgtrader(string url)
        {
            var request = new DownloadRequest();
            var web = new HtmlWeb();
            var doc = web.Load(url);

            request.Url = url;
            request.Author = doc.DocumentNode.SelectNodes("//div").FirstOrDefault(c => c.HasClass("username"))?.InnerText;
            request.ProductName = doc.DocumentNode.SelectNodes("//h1").FirstOrDefault(c => c.HasClass("product-header__title"))?.InnerText;

            //Get images
            var ele = doc.DocumentNode.SelectNodes("//li");
            foreach (var node in ele)
            {
                if (node.HasClass("smimg-gallery "))
                {
                    request.Images.Add(node.GetAttributeValue("id", ""));
                }
            }

            CreateDirectory(request);
            Log($"[Output] {GetOutputPath(request)}");
        }

        private void Process_cults(string url)
        {
            var request = new DownloadRequest();
            var web = new HtmlWeb();
            var doc = web.Load(url);

            request.Url = url;
            request.Author = doc.DocumentNode.SelectNodes("//*[@id=\"content\"]/div[2]/div[2]/div[7]/div[1]/a/span").FirstOrDefault().InnerText;
            request.ProductName = doc.DocumentNode.SelectNodes("//*[@id=\"content\"]/h1").FirstOrDefault().InnerText.Replace("\n", "").Trim();

            //Get images
            var ele = doc.DocumentNode.SelectNodes("//a");
            foreach (var node in ele)
            {
                if (node.HasClass("thumbline__thumb"))
                {
                    request.Images.Add(node.GetAttributeValue("href", ""));
                }
            }

            CreateDirectory(request);
            Log($"[Output] {GetOutputPath(request)}");
        }

        private void Process_mmf(string url)
        {
            var request = new DownloadRequest();
            var web = new HtmlWeb();
            var doc = web.Load(url);

            request.Url = url;
            request.Author = doc.DocumentNode.SelectNodes("//*[@id=\"main\"]/div[3]/div[3]/div[1]/div/div[2]/div[1]/div/p[1]/a").FirstOrDefault().InnerText;
            var productNode = doc.DocumentNode
                .SelectNodes("/html/body/section[1]/section/div[3]/div[3]/div[1]/div/div[1]/div/h1")
                .FirstOrDefault();
            if (productNode.ChildNodes.Count == 3)
            {
                request.ProductName = productNode.ChildNodes[2].InnerText.Replace("\n", "").Replace("\t", "");
            }


            //Get images
            var ele = doc.DocumentNode.SelectNodes("//li");
            foreach (var node in ele)
            {
                if (node.HasClass("smimg-gallery"))
                {
                    request.Images.Add(node.GetAttributeValue("id", "").Replace("70X70", "720X720"));
                }
            }

            CreateDirectory(request);
            Log($"[Output] {GetOutputPath(request)}");
        }

        private void DownloadImage(DownloadRequest req, string src)
        {
            try
            {
                var justFile = Path.GetFileName(src);
                if (justFile.Contains("?"))
                {
                    justFile = justFile.Split("?")[0];
                }
                var fullPath = Path.Combine(GetOutputPath(req), justFile);
                if (Chk_Prefix.Checked)
                {
                    justFile = $"{DateTime.Now.Ticks.ToString()[4..]}_{justFile}";
                    fullPath = Path.Combine(GetOutputPath(req), justFile);
                }

                if (!justFile.Contains(".") && Chk_skipUnknown.Checked)
                {
                    Log($"[Skip] {justFile}");
                    return;
                }


                using (WebClient client = new WebClient())
                {
                    client.DownloadFileAsync(new Uri(src), fullPath);
                }

                Log($"[File Added] {justFile}");
            }
            catch (Exception e)
            {
                Log($"{e.Message}");
            }

        }

        private void CreateDirectory(DownloadRequest request)
        {
            if (request.CompleteData)
            {
                Log($"[Downloading] {request.Author} | {request.ProductName} | {request.Images.Count} Images");
                var output = GetOutputPath(request);
                Directory.CreateDirectory(output);
                foreach (var img in request.Images)
                {
                    DownloadImage(request, img);
                }
            }
            else
            {
                Log($"[Missing data / Invalid parse] {request.Url}");
            }
        }

        private string GetBasePath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Output");
        }

        private string GetOutputPath(DownloadRequest request = null)
        {
            var path = Path.Combine(GetBasePath(), request.Author, request.ProductName);
            if (Chk_subfolder.Checked) path = Path.Combine(path, "Images");
            return path;
        }
    }

}




