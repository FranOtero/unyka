using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idearia.Pos.TicketPrinter
{
    public class PrinterTicket(Graphics g)
    {
        System.Drawing.Font font = new Font("Courier", 10);
        int minX = 0;
        int y = 0;


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
            g.DrawImage(Image.FromFile(path), minX + x, y, width, height);
            y += height;
        }
        public void PrintText(string text)
        {
            g.DrawString(text, font, new SolidBrush(Color.Black), minX, y);
            y += (int)font.GetHeight();
        }


    }
}
