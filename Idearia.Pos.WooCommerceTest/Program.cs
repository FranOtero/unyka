// See https://aka.ms/new-console-template for more information
using Idearia.Pos.TicketPrinter;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
string printerName = "POS-80C";


string facturasimplificada = "688767867868";
string producto = "Annabis Footcann 75ml";
string producto2 = "Annabis BIO Hemp Oil - Aceite de cáñamo certificado ecológico 500ml";
decimal importe = 2128.52m;
decimal importe2 = 23.5m;
decimal importetotal = 32m;
decimal importeefectivo = 8.5m;
decimal importetarjeta = 23.5m;
string vendedor = "Oscar";

Unyka.SetName(printerName);

Unyka.Logo("LogoB.png", 80);
Unyka.WriteText("O Boticario CBD S. Coop. Galega", TextAlign.Center);
Unyka.WriteText("Ctra. de Camposancos, 223, Coruxo, 36330 - Vigo");
Unyka.WriteText("NIF F75401158");
Unyka.WriteText("Tfno. 622298710");
Unyka.WriteText("info@oboticariocbdvigo.es       " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
Unyka.EmptyLines(1);
Unyka.WriteText("Factura simplificada: " + facturasimplificada, TextAlign.Center);
Unyka.WriteLine();
Unyka.WriteText(producto);
Unyka.WriteText($"            3 x {importe:c2} = {importe:c2}");
Unyka.WriteText(producto2);
Unyka.WriteText($"            3 x {importe2:c2} = {importe2:c2}");
Unyka.EmptyLines(1);

Unyka.WriteText("Total: " + $"{importetotal:c2}", TextAlign.Right);
Unyka.WriteText("Efectivo: " + $"{importeefectivo:c2}", TextAlign.Right);
Unyka.WriteText("Tarjeta: " + $"{importetarjeta:c2}", TextAlign.Right);
Unyka.EmptyLines(1);
Unyka.WriteTaxLine(21m, 123.57m);
Unyka.EmptyLines(1);
Unyka.WriteText("Le atendió " + vendedor);
Unyka.WriteText("Gracias por su visita.\n\n", TextAlign.Center);
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

