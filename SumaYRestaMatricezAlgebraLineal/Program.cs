using System;
using System.Linq;

namespace SumaYRestaMatricezAlgebraLineal
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(new Matriz(25,6));
			Matriz a = new Matriz(4);
			Matriz b = new Matriz(4);
			Console.WriteLine(a+" otra\n"+b);
			Matriz c = a + b;
			Matriz d = a - b;
			Console.WriteLine(c);
			Console.WriteLine(d);
		}
	}
}
