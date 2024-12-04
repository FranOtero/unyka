// See https://aka.ms/new-console-template for more information
using Idearia.Pos.TicketPrinter;


//doble altura de fuente
//RawPrinterHelper.SendStringToPrinter("POS-80", "\x1B\x21\x16");

//fuente normal
RawPrinterHelper.SendStringToPrinter("POS-80", "\x1B\x21\x00");
//RawPrinterHelper.SendStringToPrinter("POS-80", "Fuente normal que tal estáis 00000ooo111 bien no\n");

//RawPrinterHelper.SendStringToPrinter("POS-80", "\x1B\x21\x08");
//RawPrinterHelper.SendStringToPrinter("POS-80", "Fuente enphasized que tal estáis 00000ooo111 bien no\n");

//RawPrinterHelper.SendStringToPrinter("POS-80", "\x1B\x21\x16");
//RawPrinterHelper.SendStringToPrinter("POS-80", "Fuente doble height que tal estáis 00000ooo111 bien no\n");

//RawPrinterHelper.SendStringToPrinter("POS-80", "\x1B\x21\x32");
//RawPrinterHelper.SendStringToPrinter("POS-80", "Fuente doble width que tal estáis 00000ooo111 bien no\n");

//RawPrinterHelper.SendStringToPrinter("POS-80", "\x1B\x21\x128");
//RawPrinterHelper.SendStringToPrinter("POS-80", "Fuente underline que tal estáis 00000ooo111 bien no\n");

//RawPrinterHelper.SendStringToPrinter("POS-80", "\x1B\x61\x01");
//RawPrinterHelper.SendStringToPrinter("POS-80", "Centrado\n");
RawPrinterHelper.SendStringToPrinter("POS-80", "\x1B\x61\x00");

//RawPrinterHelper.SendStringToPrinter("POS-80", "\x1D\x21\x70");
//RawPrinterHelper.SendStringToPrinter("POS-80", "enorme\n");

//RawPrinterHelper.SendStringToPrinter("POS-80", "\x1D\x42\x01");
//RawPrinterHelper.SendStringToPrinter("POS-80", "invertido\n");
RawPrinterHelper.SendStringToPrinter("POS-80", "\x1D\x42\x00");


RawPrinterHelper.SendStringToPrinter("POS-80", "\x1B\x44\x28\x01\x00");
RawPrinterHelper.SendStringToPrinter("POS-80", "Siiiiiiiiiii producto muy largo\x09 132.21€\n");
RawPrinterHelper.SendStringToPrinter("POS-80", "Nooooooooooo corto \x09  32.21€\n");



Printer printer = new Printer("POS-80");

printer.Print();
RawPrinterHelper.SendStringToPrinter("POS-80", "\n\n");

printer.CutPaper();

