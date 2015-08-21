using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP01
{
	/// <summary>
	///  Desarrolle  una  aplicación  que  calcule  el  factorial  de  un  número  ingresado  por 
	///  teclado y lo escriba en la consola. 
	/// </summary>
	class EJ12
	{
		/// <summary>
		///	Calcula el factorial
		/// </summary>
		/// <param name="n">Numero para el cual calcular el factorial</param>
		/// <returns>El factorial de n</returns>
		static UInt64 CalcularFactorial(UInt64 n)
		{
			if (n == 0)
			{
				return 1;
			}
			else
			{
				return n * CalcularFactorial(n - 1);
			}
		}

		static void Main(string[] args)
		{
			Console.Write("Ingrese un numero: ");
			int numero = int.Parse(Console.ReadLine());
			Console.WriteLine("El factorial de {0} es: {1}", numero, CalcularFactorial((UInt64) numero));
			Console.ReadKey();
		}
	}
}
