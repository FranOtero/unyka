using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;

namespace Idearia.Pos.TicketPrinter
{
    public static class Unyka
    {
        public static void SetName(string printerName)
        {
            RawPrinterHelper._printerName = printerName;
            RawPrinterHelper.SendCommand("\x1B\x52\x0B"); // ESC R 11
            RawPrinterHelper.SendCommand("\x1B\x44\x22\x01\x00"); // ESC D 32 1 0 (tabulador)
        }

        public static void WriteTitle(string v)
        {
            RawPrinterHelper.SendCommand("\x1B\x21\x16");
            WriteText(v + "\n", TextAlign.Center);

            RawPrinterHelper.SendCommand("\x1B\x21\x00");
        }
        static TextAlign last = TextAlign.Right;
        public static void WriteText(string v, TextAlign textAlign = TextAlign.Left)
        {
            if (last != textAlign)
            {
                switch (textAlign)
                {
                    case TextAlign.Left:
                        RawPrinterHelper.SendCommand("\x1B\x61\x00");
                        break;
                    case TextAlign.Center:
                        RawPrinterHelper.SendCommand("\x1B\x61\x01");
                        break;
                    case TextAlign.Right:
                        RawPrinterHelper.SendCommand("\x1B\x61\x02");
                        break;
                }
                last = textAlign;
            }
            RawPrinterHelper.SendString(v + "\n");
        }
        public static void CutPaper()
        {
            RawPrinterHelper.SendString("\n\n\n");
            RawPrinterHelper.SendCommand("\x1B\x69"); // ESC i
        }

        public static void Logo(string path, int size)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (sender, e) =>
            {

                e.Graphics.DrawImage(Image.FromFile(path), (100 - size) / 2, 0, size, size);
                e.Graphics.DrawString("O Boticario CBD", new Font("Arial", 16), new SolidBrush(Color.Black), size * 1.2f, size / 2 - 20);
                e.Graphics.DrawString("Coruxo", new Font("Arial", 10), new SolidBrush(Color.Black), size * 1.2f + 10, size / 2 + 10);
            };
            printDocument.PrinterSettings.PrinterName = RawPrinterHelper._printerName; // Replace with your printer name
            printDocument.Print();
        }

        public static void EmptyLines(int v)
        {
            string a = "";
            for (int i = 0; i < v; i++)
            {
                a += "\n";
            }
            RawPrinterHelper.SendString(a);
        }

        public static void WriteText(string line, string right)
        {
            int max = 30;
            if (line.Length > max)
                line = line.Substring(0, max) + "...";
            WriteText($"{line}\x09 {right.PadLeft(12)}\n", TextAlign.Left);
        }

        public static void WriteLine()
        {
            WriteText("   --------------------------------------------\n");
        }

        public static void WriteTaxLine(decimal rate, decimal importeBase)
        {
            WriteText($"  Tipo               Base             Importe\n");
            WriteText($"  {rate:F2}%           {importeBase:C2}           {(rate * importeBase / 100):C2}\n");
        }
    }

    public enum TextAlign
    {
        Left,
        Center,
        Right,
    }

}
