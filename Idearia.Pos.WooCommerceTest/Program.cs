// See https://aka.ms/new-console-template for more information
using Idearia.Pos.TicketPrinter;

Printer printer = new Printer("POS-80");
printer.Print();
printer.CutPaper();

