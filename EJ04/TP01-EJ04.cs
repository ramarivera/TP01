using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace TP01
{
	/// <summary>
	/// Desarrolle la misma aplicación del ejercicio 3 pero utilice la estructura while
	/// </summary>
	class EJ04
	{
		public const int LIM_INFERIOR = 5, LIM_SUPERIOR = 100;

		static void Main(string[] args)
		{
			int i = LIM_INFERIOR;
			int suma = 0, con = 0;

			while (i < LIM_SUPERIOR)
			{
				suma += i;
				con++;
				i++;
			}
			Console.WriteLine("La suma es: {0}", suma);
			Console.WriteLine("El total de numeros sumados es: {0}", con);
			Console.WriteLine("El promedio es: {0}", suma / con);
			Console.ReadKey();
		}
	}
}
