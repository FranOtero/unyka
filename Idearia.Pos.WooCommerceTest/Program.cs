// See https://aka.ms/new-console-template for more information
using Idearia.Pos.TicketPrinter;
using System.Security.AccessControl;
string printerName = "POS-80C";


string facturasimplificada = "688767867868";
string fecha = "04/12/2024  17:17";
string producto = "Annabis Footcann crema nutritiva pies secos 75ml";
string producto2 = "Annabis BIO Hemp Oil - Aceite de cáñamo certificado ecológico 500ml"; 
string importe = "8.5";
string importe2 = "23.5"; 
string importetotal = "32";
string importeefectivo = "8.5";
string importetarjeta = "23.5";
string vendedor = "Oscar";

Unyka.SetName(printerName);
Unyka.Logo("");
Unyka.WriteTitle("O BOTICARIO");
Unyka.EmptyLines(1);
Unyka.WriteCentered("O Boticario CBD S. Coop. Galega");
Unyka.WriteText("NIF F75401158"); 
Unyka.WriteText("Ctra. de Camposancos, 223, Coruxo, 36330 - Vigo");
Unyka.WriteText("Tfno. 622298710");
Unyka.WriteText("factura simplificada: " + facturasimplificada);
Unyka.WriteText(fecha);
Unyka.WriteLine();
Unyka.WriteText("Descripción", "importe");
Unyka.WriteLine(); 
Unyka.WriteText(producto, importe + "€");
Unyka.WriteText(producto2, importe2 + "€");
Unyka.WriteText("Total: " + importetotal + "€", TextAlign.Right, enphasized);
Unyka.WriteText("Efectivo: " + importeefectivo + "€", TextAlign.Right);
Unyka.WriteText("Tarjeta: " + importetarjeta + "€", TextAlign.Right);
Unyka.EmptyLines(1);
Unyka.WriteTaxLine(2.00 %, 3.50, 0.07, 3.57);
Unyka.EmptyLines(1);
Unyka.WriteText("Atendido por: " + vendedor);
Unyka.WriteCentered("Gracias por su visita.");

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

