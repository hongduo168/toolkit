using RazorEngine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolkit.WinForm.ApiDesign
{
    public class TemplateBuilder<T>
    {
        public string TemplatePath { get; set; }

        public T RenderData { get; set; }

        public string Namespace { get; set; }

        public string OutputPath { get; set; }


        public TemplateBuilder(string templatePath, T renderData, string @namespace, string outputPath)
        {
            this.RenderData = renderData;
            this.Namespace = @namespace;
            this.OutputPath = outputPath;
            this.TemplatePath = templatePath;
        }

        public void Render(bool isCover = true)
        {
            var rootPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "code");
            var filePath = Path.Combine(rootPath, this.OutputPath);

            if (!isCover)
            {
                if (File.Exists(filePath))
                {
                    return;
                }
            }

            //读取模板文件
            var template = System.IO.File.ReadAllText(this.TemplatePath);
            var result = Razor.Parse<T>(template, this.RenderData)
                .Replace("{Namespace}", Namespace)
                .Replace("&gt;", ">")
                .Replace("&lt;", "<")
                .Replace("&quot;", "\"")
                .Replace("&amp;", "&");

            EnsureFloder(Path.GetDirectoryName(filePath));

            System.IO.File.WriteAllText(filePath, result);
        }


        public static void EnsureFloder(string path)
        {
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
        }

    }
}
