using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ebay.Enums;
using System.IO;

namespace ebay.Utilities
{
    public static class FileReaderService
    {
        public static string GetTextFromFile(string productName, TemplateSections section )
        {
            string path = HttpContext.Current.Server.MapPath("/TemplateContent/"+productName + "/" + section.ToString() + ".html");

            string readText = File.ReadAllText(path);

            return readText;
        }

        public static string[] GetImages(string productName)
        {
            string[] files = Directory.GetFiles(HttpContext.Current.Server.MapPath("/TemplateContent/"+productName+"/Images/"));
            for (int i = 0; i < files.Length; i++)
                files[i] = Path.GetFileName(files[i]);
            return files;
        }
    }
}