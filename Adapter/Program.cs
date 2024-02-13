//Short Description about the Adapter
// when we have two Object and they are doing a same work
// but they are in deffrent interfaces or implementation
// so we using adapter to use them

using Adapter.Adapter;

//simple
IPrinter printer = new FilePrinter();
printer.Print(Console.ReadLine());

var textForPrint = Console.ReadLine();
printer.Print(textForPrint);
//
IPrinter printer1 = new ObjectAdapter();
printer1.Print(Console.ReadLine());
// 
IPrinter printer2 = new InheriteAdapter();
printer1.Print(Console.ReadLine());

