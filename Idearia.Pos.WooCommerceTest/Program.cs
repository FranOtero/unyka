// See https://aka.ms/new-console-template for more information
using Idearia.Pos.TicketPrinter;
string printerName = "POS-80C";



Unyka.SetName(printerName);
//Unyka.WriteText("Caja 1");
//Unyka.WriteText("Caja 1");
//Unyka.WriteText("\n\n\n");
//Unyka.WriteText("Caja 1");
//Unyka.WriteText("Caja 1");
//Unyka.WriteText("Caja 1");

////Unyka.WriteTitle("O BOTICARIO");
////Unyka.WriteCentered("DFDASAFS");
////Unyka.WriteText("Dirección, código postal");
////Unyka.WriteText("CIF");
////Unyka.WriteText("teléfono");
Unyka.WriteText("Caja 1");
RawPrinterHelper.SendStringToPrinter("\n\n\n");
Unyka.WriteText("Caja 2");
RawPrinterHelper.SendStringToPrinter("\n\n\n");
//RawPrinterHelper.SendStringToPrinter(" ");
Unyka.CutPaper();




//Demostracion(printerName);

static void Demostracion(string printerName)
{
    //doble altura de fuente
    //RawPrinterHelper.SendStringToPrinter("POS-80", "\x1B\x21\x16");

    //fuente normal
    //RawPrinterHelper.SendStringToPrinter(printerName, "\x1B\x21\x00");
    ////RawPrinterHelper.SendStringToPrinter(printerName, "Fuente normal que tal estáis 00000ooo111 bien no\n");

    ////RawPrinterHelper.SendStringToPrinter(printerName, "\x1B\x21\x08");
    ////RawPrinterHelper.SendStringToPrinter(printerName, "Fuente enphasized que tal estáis 00000ooo111 bien no\n");

    ////RawPrinterHelper.SendStringToPrinter(printerName, "\x1B\x21\x16");
    ////RawPrinterHelper.SendStringToPrinter(printerName, "Fuente doble height que tal estáis 00000ooo111 bien no\n");

    ////RawPrinterHelper.SendStringToPrinter(printerName, "\x1B\x21\x32");
    ////RawPrinterHelper.SendStringToPrinter(printerName, "Fuente doble width que tal estáis 00000ooo111 bien no\n");

    ////RawPrinterHelper.SendStringToPrinter(printerName, "\x1B\x21\x128");
    ////RawPrinterHelper.SendStringToPrinter(printerName, "Fuente underline que tal estáis 00000ooo111 bien no\n");

    //RawPrinterHelper.SendStringToPrinter(printerName, "\x1B\x61\x01");
    //RawPrinterHelper.SendStringToPrinter(printerName, "Centrado\n");
    //RawPrinterHelper.SendStringToPrinter(printerName, "\x1B\x61\x00");

    ////RawPrinterHelper.SendStringToPrinter(printerName, "\x1D\x21\x70");
    ////RawPrinterHelper.SendStringToPrinter(printerName, "enorme\n");

    ////RawPrinterHelper.SendStringToPrinter(printerName, "\x1D\x42\x01");
    ////RawPrinterHelper.SendStringToPrinter(printerName, "invertido\n");
    ////RawPrinterHelper.SendStringToPrinter(printerName, "\x1D\x42\x00");


    //RawPrinterHelper.SendStringToPrinter(printerName, "\x1B\x44\x28\x01\x00");
    //RawPrinterHelper.SendStringToPrinter(printerName, "Siiiiiiiiiii producto muy largo\x09 132.21€\n");
    //RawPrinterHelper.SendStringToPrinter(printerName, "Nooooooooooo corto \x09  32.21€\n");



    //Printer printer = new Printer(printerName);

    //printer.Print();
    //RawPrinterHelper.SendStringToPrinter(printerName, "\n\n");

    //printer.CutPaper();
}

