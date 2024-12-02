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
            // Send line feed commands to add extra space
            string lineFeedCommand = "\n\n\n"; // Adjust the number of line feeds as needed
            RawPrinterHelper.SendStringToPrinter(printerName, lineFeedCommand);

            // Send cut paper command
            string cutCommand = "\x1B\x69"; // ESC i
            RawPrinterHelper.SendStringToPrinter(printerName, cutCommand);
        }

        private static void PrintPage(object sender, PrintPageEventArgs e)
        {
            PrinterTicket ticket = new PrinterTicket(e.Graphics);
            /*
                        ticket.BeginPrintImage("logo.png", 0, 100, 100);
                        ticket.SetMargin(120);
                        ticket.PrintText("");
                        ticket.PrintText("Hola, después de una línea");
                        ticket.PrintText("en blanco a propósito");
                        ticket.EndPrintImage();
                        ticket.PrintText("EndPrint se coloca debajo de la imagen");
                        ticket.SetMargin(0);
                        ticket.PrintText("Y con SetMargin(0) vuelvo al margen izquierdo");


                        //Ejemplo escribir encima y debajo de una imagen
                        ticket.PrintText("Hola, aquí empeza");
                        ticket.PrintImage("logo.png", 0, 100, 100); https://symbl.cc/en/unicode-table
                        ticket.PrintText("Hola, aquí acaba");

                        //Ejemplo imprimir una línea completa con un patrón
                        ticket.PrintLine("*|");

                        //Ejemplo caracteres especiales
                        ticket.PrintLine("★");
                        ticket.PrintLine("☆");
                        ticket.PrintLine("⁂");
                        ticket.PrintLine("✨");
                        ticket.PrintText("← ∙ ∘ ☂ ☀ ☠ ♥ ✔");

                        //Ejemplo cambiar la fuente
                        ticket.SetFontStyle(FontStyle.Bold);
                        ticket.PrintText("Texto en negrita");
                        */
        }

    }
}
