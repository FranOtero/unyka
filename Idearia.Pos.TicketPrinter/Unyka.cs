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
    }
}
