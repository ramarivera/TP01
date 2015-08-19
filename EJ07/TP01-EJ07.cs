using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TP01
{
	/// <summary>
	/// Desarrolle una aplicación que calcule aproximadamente el número  πcon la fórmula 
	/// de Lebniz:  
	/// 
	/// Determine el criterio de fin de cálculo, que puede ser la cantidad de términos utilizados. La 
	/// API  de  C#  posee  una  constante  con  el  valor  de  dicho número  (Math.PI),  compare  el 
	/// resultado del cálculo con la constante en términos porcentuales. 
	/// </summary>
	class EJ07
	{
		public const int LIM_SUPERIOR = 1000;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			int n = 0;
			double sumatoria = 0, pi;

			do
			{
				sumatoria += (Math.Pow(-1, n)) / (2 * n + 1);
				n++;
			} while (n < LIM_SUPERIOR);
			pi = sumatoria * 4;
			Console.WriteLine("El resultado del calculo es: {0}", pi);
			Console.WriteLine("La diferencia porcentual entre el Pi calculado y Math.Pi es: {0}", (Math.PI - pi) / Math.PI);
			Console.ReadKey();
		}
	}
}
