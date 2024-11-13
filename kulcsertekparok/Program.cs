using Generikusok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kulcsertekparok
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Entry<string, int> e1 = new Entry<string, int>("Tamas", 195);
			Entry<string, int> e2 = new Entry<string, int>("Istvan", 167);
			Entry<string, int> e3 = new Entry<string, int>("Bence", 187);
			Entry<string, int> e4 = new Entry<string, int>("Kevin", 156);
			Parok<string, int> lista = new Parok<string, int>();
			lista.Hozzaad(e1);
			lista.Hozzaad(e2);
			lista.Hozzaad(e3);
			lista.Hozzaad(e4);

            Console.WriteLine(lista.ToString());

			Console.WriteLine(lista.Kereses("Bence")+"\n");

			lista.Torol("Bence");
			Console.WriteLine(lista.ToString());
		}
	}
}
