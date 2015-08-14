using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*   */

namespace TP01
{
	/// <summary>
	/// Desarrolle  una  aplicación  que  calcule  y  escriba  por consola  la  suma  de  todos  los 
	/// números primos comprendidos entre 35 y 1977, incluyendo a estos valores.
	/// </summary>
	class EJ09
	{
		public const int LIM_INFERIOR = 35, LIM_SUPERIOR = 1977;

		static void Main(string[] args)
		{
			int suma = 0, con = 0;
			bool compuesto = false;
			int i, j;
			for (i = LIM_INFERIOR; i <= LIM_SUPERIOR; i++)
			{
				j = i - 1;
				compuesto = false;
				while (!compuesto && j > 1)
				{
					if (i % j == 0) compuesto = true;
					j--;
				}
				if (!compuesto)
				{
					con++;
					suma += i;
					Console.WriteLine("El numero primo {0} es: {1}", con.ToString("000"), i);
				}
			}
			Console.WriteLine("Se encontraron {0} numeros primos, siendo {1} la sumatoria de los mismos", con, suma);
			Console.ReadKey();
		}
	}
}
