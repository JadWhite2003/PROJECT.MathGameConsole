
using MathGameConsole.Models;
using static System.Formats.Asn1.AsnWriter;

var menu = new Menu();

var date = DateTime.UtcNow;

string name = Helper.GetName();

menu.ShowMenu(name, date);

