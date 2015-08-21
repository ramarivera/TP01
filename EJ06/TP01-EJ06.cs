using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace TP01
{
	/// <summary>
	/// Desarrolle una aplicación que imprima por pantalla la suma de los números impares 
	/// de 1 a 100. Imprima el promedio también. 
	/// </summary>
	class EJ06
	{
		static void Main(string[] args)
		{
			int con = 0, suma = 0;

			for (int i = 1; i <= 100; i=+2)
			{
				suma += i;
				con++;
			}
			Console.WriteLine("La suma es: {0}", suma);
			Console.WriteLine("El total de numeros sumados es: {0}", con);
			Console.WriteLine("El promedio es: {0}", suma / (double) con);
			Console.ReadKey();
		}
	}
}
