using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;

namespace Idearia.Pos.WooCommerceTest
{
    internal class PruebasUnyka
    {
        internal static void Print()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
            printDocument.PrinterSettings.PrinterName = "POS-80"; // Replace with your printer name
            printDocument.Print();

            // Send cut paper command
            string cutCommand = "\x1B\x69"; // ESC i
            RawPrinterHelper.SendStringToPrinter(printDocument.PrinterSettings.PrinterName, cutCommand);
        }

        private static void PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 10);
            float fontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphics.DrawString("Hello, this is a test print.", new Font("Arial", 12), new SolidBrush(Color.Black), startX, startY);
            offset += (int)fontHeight + 5;
            graphics.DrawString("Thank you for your purchase!", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight + 5;
            graphics.DrawImage(Image.FromFile("logo.png"), 0, 0, 100, 100);
            offset += (int)fontHeight + 5;
        }
    }
}
