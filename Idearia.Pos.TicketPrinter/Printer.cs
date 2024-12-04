using System.Drawing;
using System.Drawing.Printing;
using System.IO;

namespace Idearia.Pos.TicketPrinter
{
    public static class Printer
    {

        public static void PrintLogo(string path, int size)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (sender, e) =>
            {
                e.Graphics.DrawImage(Image.FromFile(path), 0, 0, size, size);
            };
            //printDocument.PrinterSettings.PrinterName = printerName; // Replace with your printer name
            printDocument.Print();
        }

        private static void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            throw new NotImplementedException();
        }

        //public void Print()
        //{

        //    RawPrinterHelper.SendStringToPrinter(printerName, "\x1B\x2\x01");

        //    PrintDocument printDocument = new PrintDocument();
        //    printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
        //    printDocument.PrinterSettings.PrinterName = printerName; // Replace with your printer name
        //    printDocument.Print();
        //}

        //public void OpenCashDrawer()
        //{
        //    // Send open cash drawer command
        //    string openCashDrawerCommand = "\x1B\x70\x00\x19\xFA"; // ESC p 0 25 250
        //    RawPrinterHelper.SendStringToPrinter(printerName, openCashDrawerCommand);
        //}

        //public void CutPaper()
        //{
        //    // Send line feed commands to add extra space
        //    string lineFeedCommand = "\n\n\n"; // Adjust the number of line feeds as needed
        //    RawPrinterHelper.SendStringToPrinter(printerName, lineFeedCommand);

        //    // Send cut paper command
        //    string cutCommand = "\x1B\x69"; // ESC i
        //    RawPrinterHelper.SendStringToPrinter(printerName, cutCommand);
        //}

        //private void PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    PrinterTicket ticket = new PrinterTicket(e.Graphics);
        //    g.DrawImage(Image.FromFile(path), _x + x, _y, width, height);
        //    //RawPrinterHelper.SendStringToPrinter(printerName, "\n\n\n");

        //    return;
        //}

    }
}
