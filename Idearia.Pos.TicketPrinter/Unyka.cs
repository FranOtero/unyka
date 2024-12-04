using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idearia.Pos.TicketPrinter
{
    public static class Unyka
    {
        public static void SetName(string printerName)
        {
            RawPrinterHelper._printerName = printerName;
            RawPrinterHelper.SendCommand("\x1B\x52\x0B"); // ESC R 11
            RawPrinterHelper.SendCommand("\x1B\x44\x28\x01\x00"); // ESC D 40 1 0 (tabulador)
        }

        public static void WriteCentered(string v)
        {
            RawPrinterHelper.SendCommand("\x1B\x21\x16");
            RawPrinterHelper.SendCommand("\x1B\x61\x01");
            RawPrinterHelper.SendString(v + "\n");
            RawPrinterHelper.SendCommand("\x1B\x61\x00");
            RawPrinterHelper.SendCommand("\x1B\x21\x00");
        }

        public static void WriteTitle(string v)
        {
            RawPrinterHelper.SendCommand("\x1B\x21\x16");
            RawPrinterHelper.SendCommand("\x1B\x61\x01");
            RawPrinterHelper.SendString(v + "\n");
            RawPrinterHelper.SendCommand("\x1B\x61\x00");

            RawPrinterHelper.SendCommand("\x1B\x21\x00");
        }

        public static void WriteText(string v, TextAlign textAlign = TextAlign.Left)
        {
            RawPrinterHelper.SendString(v + "\n");
        }
        public static void CutPaper()
        {
            RawPrinterHelper.SendString("\n\n\n");
            RawPrinterHelper.SendCommand("\x1B\x69"); // ESC i
        }

        public static void Logo(string v)
        {
            RawPrinterHelper.SendString("Los logos no sale por ahora");
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
            RawPrinterHelper.SendString($"{line}\x09 {right}\n");
        }

        public static void WriteLine()
        {
            WriteCentered("______________________________________________\n");
        }

        public static void WriteTaxLine(decimal v1, decimal v2, decimal v3, decimal v4)
        {
            RawPrinterHelper.SendString($"{v1:F2}%  {v2:F2}  {v3:F2}  {v4:F2} \n");
        }
    }

    public enum TextAlign
    {
        Left,
        Center,
        Right,
    }

}
