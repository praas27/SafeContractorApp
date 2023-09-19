using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeContractorApp
{
    internal class Globaal
    {
        public static string user = "";
        public static string foutcode = "";
        public static string database = "";
        public static string username = "";
        public static string host = "";
        public static int vuurId = 0;
        public static int openId = 0;
        public static int sluitId = 0;
        public static string noodnummer = "";
        public static string uitvoerder = "";
        public static string opdrachtgever = "";

        public static string[] FormatText(string text, XFont font, int margin)
        {
            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            List<string> lines = new List<string>();
            StringBuilder currentLine = new StringBuilder();

            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                string testLine = currentLine.ToString() + word + " ";
                double lineSize = gfx.MeasureString(testLine, font).Width;

                if (lineSize < page.Width - (2 * margin))
                {
                    // The word fits on the current line
                    currentLine.Append(word + " ");
                }
                else
                {
                    // The word exceeds the margin, start a new line
                    lines.Add(currentLine.ToString().Trim());
                    currentLine = new StringBuilder(word + " ");
                }
            }

            // Add the last line
            lines.Add(currentLine.ToString().Trim());

            return lines.ToArray();
        }

        public static string[] FormatTextTwo(string text, XFont font, int maxSize)
        {
            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            List<string> lines = new List<string>();
            StringBuilder currentLine = new StringBuilder();

            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                string testLine = currentLine.ToString() + word + " ";
                double lineSize = gfx.MeasureString(testLine, font).Width;

                if (lineSize < maxSize)
                {
                    // The word fits on the current line
                    currentLine.Append(word + " ");
                }
                else
                {
                    // The word exceeds the margin, start a new line
                    lines.Add(currentLine.ToString().Trim());
                    currentLine = new StringBuilder(word + " ");
                }
            }

            // Add the last line
            lines.Add(currentLine.ToString().Trim());

            return lines.ToArray();
        }
    }
}
