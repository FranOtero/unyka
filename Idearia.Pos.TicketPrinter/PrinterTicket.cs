using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idearia.Pos.TicketPrinter
{
    internal class PrinterTicket(Graphics g)
    {
        System.Drawing.Font font = new Font("Ticketing", 10);
        const int minX = 5;
        int _x = minX;
        int _y = 0;


        public void SetFont(string fontName)
        {
            font = new Font(fontName, font.Size);
        }
        public void SetFontSize(int fontSize)
        {
            font = new Font(font.FontFamily.Name, fontSize);
        }
        public void SetFontStyle(FontStyle fontStyle)
        {
            font = new Font(font.FontFamily.Name, font.Size, fontStyle);
        }
        public void PrintImage(string path, int x, int width, int height)
        {
            g.DrawImage(Image.FromFile(path), _x + x, _y, width, height);
            _y += height;
        }

        int _y_fin_imagen = 0;
        public void BeginPrintImage(string path, int x, int width, int height)
        {
            g.DrawImage(Image.FromFile(path), _x + x, _y, width, height);
            _y_fin_imagen = _y + height;
        }
        public void EndPrintImage()
        {
            _y = Math.Max(_y, _y_fin_imagen);
        }
        public void PrintText(string text)
        {
            g.DrawString(text, font, new SolidBrush(Color.Black), _x, _y);
            _y += (int)font.GetHeight();
        }
        public void PrintLine(string pattern)
        {
            string l = "";
            for (int i = 0; i < 200; i++)
            {
                l += pattern;
            }
            g.DrawString(l, font, new SolidBrush(Color.Black), _x, _y);
            _y += (int)font.GetHeight();
        }
        public void SetMargin(int x)
        {
            _x = x + minX;
        }


    }
}
