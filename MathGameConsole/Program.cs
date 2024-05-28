
using MathGameConsole;
using static System.Formats.Asn1.AsnWriter;

var menu = new Menu();

var date = DateTime.UtcNow;

string name = GetName();

menu.ShowMenu(name, date);
string GetName()
{
    Console.WriteLine("Please enter your name:");
    var name = Console.ReadLine();
    return name;
}

