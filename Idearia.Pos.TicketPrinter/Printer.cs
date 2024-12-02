using System.Drawing;
using System.Drawing.Printing;

namespace Idearia.Pos.TicketPrinter
{
    public class Printer(string printerName)
    {
        public void Print()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
            printDocument.PrinterSettings.PrinterName = printerName; // Replace with your printer name
            printDocument.Print();
        }

        public void OpenCashDrawer()
        {
            // Send open cash drawer command
            string openCashDrawerCommand = "\x1B\x70\x00\x19\xFA"; // ESC p 0 25 250
            RawPrinterHelper.SendStringToPrinter(printerName, openCashDrawerCommand);
        }

        public void CutPaper()
        {
            // Send cut paper command
            string cutCommand = "\x1B\x69"; // ESC i
            RawPrinterHelper.SendStringToPrinter(printerName, cutCommand);
        }

        private static void PrintPage(object sender, PrintPageEventArgs e)
        {
            PrinterTicket ticket = new PrinterTicket(e.Graphics);
            ticket.PrintImage("logo.png", 0, 100, 100);
            ticket.PrintText("Hello, World!");
            ticket.SetFontStyle(FontStyle.Bold);
            ticket.PrintText("This is a test ticket.");
        }

    }
}
