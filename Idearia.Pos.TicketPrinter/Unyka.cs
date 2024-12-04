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
        }

        public static void WriteCentered(string v)
        {
            RawPrinterHelper.SendStringToPrinter("\x1B\x21\x16");
            RawPrinterHelper.SendStringToPrinter("\x1B\x61\x01");
            RawPrinterHelper.SendStringToPrinter(v + "\n");
            RawPrinterHelper.SendStringToPrinter("\x1B\x61\x00");
            RawPrinterHelper.SendStringToPrinter("\x1B\x21\x00");
        }

        public static void WriteTitle(string v)
        {
            RawPrinterHelper.SendStringToPrinter("\x1B\x21\x16");
            RawPrinterHelper.SendStringToPrinter("\x1B\x61\x01");
            RawPrinterHelper.SendStringToPrinter(v + "\n");
            RawPrinterHelper.SendStringToPrinter("\x1B\x61\x00");

            RawPrinterHelper.SendStringToPrinter("\x1B\x21\x00");
        }

        public static void WriteText(string v)
        {

            RawPrinterHelper.SendStringToPrinter(v + "\n");
        }
        public static void CutPaper()
        {
            RawPrinterHelper.SendStringToPrinter("\n\n\n"); // ESC i
            RawPrinterHelper.SendStringToPrinter("\x1B\x69"); // ESC i
        }

        public static void Logo(string v)
        {
            throw new NotImplementedException();
        }

        public static void EmptyLines(int v)
        {
            throw new NotImplementedException();
        }

        public static void WriteText(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        public static void WriteLine(int v)
        {
            throw new NotImplementedException();
        }

        public static void WriteText(object producto, object value)
        {
            throw new NotImplementedException();
        }

        public static void WriteTaxLine(string v1, string v2, string v3, string v4)
        {
            throw new NotImplementedException();
        }
    }

    public enum TextAlign
    {
        Left,
        Center,
        Right,
    }

}
