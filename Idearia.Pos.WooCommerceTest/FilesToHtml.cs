using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idearia.Pos.WooCommerceTest
{
    internal static class FilesToHtml
    {
        public static void ConvertFilesToHtml(string folder)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<link rel=\"stylesheet\" href=\"styles.css\" />");
            foreach (var marcaDir in Directory.GetDirectories(folder))
            {
                string marca = Path.GetFileName(marcaDir);
                sb.AppendLine($"<div class=\"marca-card\" id=\"{marca}\">");

                sb.AppendLine($"<p class=\"marca\">{marca}</p>");
                bool empty = true;
                foreach (string familiaDir in Directory.GetDirectories(marcaDir))
                {
                    empty = false;
                    sb.AppendLine($"<div class=\"marca-familia-card\">");
                    string familia = Path.GetFileName(familiaDir);
                    sb.AppendLine($"<p class=\"familia\">{familia}</p>");

                    if (Directory.GetDirectories(familiaDir).Any())
                    {
                        foreach (string subfamiliaDir in Directory.GetDirectories(familiaDir))
                        {
                            string subfamilia = Path.GetFileName(subfamiliaDir);
                            sb.AppendLine($"<p class=\"subfamilia\">{subfamilia}</p>");
                            sb.AppendLine("<div class=\"subfamilia-card\">");
                            foreach (string fileName in Directory.GetFiles(subfamiliaDir))
                            {
                                sb.AppendLine(GetLink(folder, fileName));
                            }
                            sb.AppendLine("</div> <!--subfamilia-card-->");
                        }
                    }
                    else
                    {
                        sb.AppendLine("<div class=\"subfamilia-card\">");
                        foreach (string fileName in Directory.GetFiles(familiaDir))
                        {
                            sb.AppendLine(GetLink(folder, fileName));
                        }
                        sb.AppendLine("</div> <!--subfamilia-card-->");
                    }
                    sb.AppendLine($"</div> <!--marca-familia-card-->");
                }
                if (empty)
                {
                    sb.AppendLine("<div class=\"subfamilia-card\">");
                    foreach (string fileName in Directory.GetFiles(marcaDir))
                    {
                        sb.AppendLine(GetLink(folder, fileName));
                    }
                    sb.AppendLine("</div> <!--subfamilia-card-->");
                }


                sb.AppendLine($"</div> <!--marca-card-->");
            }
            // sb.AppendLine(" <script>parent.window.scrollTo(0,window.outerHeight/2+document.getElementById(parent.window.location.hash.substring(1)).offsetTop);</script>");

            File.WriteAllText("C:/tmp/index.html", sb.ToString());
        }
        internal static string GetLink(string folder, string fileName)
        {
            string href = "/wp-includes/idearia/fichas/" + fileName.Substring(folder.Length).Replace("\\", "/").Replace(" ", "%20");
            return $"<div class=\"link\" title=\"{Path.GetFileName(fileName)}\"><a target=\"_blank\" href=\"{href}\">{Path.GetFileNameWithoutExtension(fileName).Substring(0, 15)}</a></div>";
        }
    }


}
