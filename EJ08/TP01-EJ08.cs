using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace TP01
{
	/// <summary>
	/// Desarrolle una aplicación que escriba por consola los primeros 50 elementos de la 
	/// serie de Fibonacci.
	/// </summary>
	class EJ08
	{
		public const int LIM_SUPERIOR = 50;

		static void Main(string[] args)
		{
			long fb0 = 0, fb1 = 1, aux;
			Console.WriteLine("El termino 00 de la sucesion de Fibonacci es: \t 0");
			for (int i = 0; i < LIM_SUPERIOR; i++)
			{
				Console.WriteLine("El termino {0} de la sucesion de Fibonacci es: \t {1}", i.ToString("00"), fb1);
				aux = fb1;
				fb1 += fb0;
				fb0 = aux;
			}
			Console.ReadKey();
		}
	}
}
