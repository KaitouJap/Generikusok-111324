using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generikusok
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Verem<int> lifo = new Verem<int>();
			for (int i = 0; i < 10; i++)
			{
				lifo.Push(i);
			}
            Console.WriteLine(lifo.ToString());

            Console.WriteLine(lifo.Peek());
            Console.WriteLine(lifo.ToString());

			Console.WriteLine(lifo.Pop());
			Console.WriteLine(lifo.ToString());

			Console.WriteLine(lifo.Count + " " +lifo.IsEmpty);

			try
			{
				for (int i = 0; i < 101; i++)
				{
					lifo.Pop();
				}
			}
			catch (Exception ex) 
			{
                Console.WriteLine(ex.Message);
            }
			
		}
	}
}
