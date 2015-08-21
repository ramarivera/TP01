using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TP01
{
	/// <summary>
	/// Desarrolle una aplicación que calcule aproximadamente el número  π con la fórmula de Lebniz:  
	/// 
	/// Determine el criterio de fin de cálculo, que puede ser la cantidad de términos utilizados. La 
	/// API  de  C#  posee  una  constante  con  el  valor  de  dicho número  (Math.PI),  compare  el 
	/// resultado del cálculo con la constante en términos porcentuales. 
	/// </summary>
	class EJ07
	{
		static void Main(string[] args)
		{
			double sumatoria = 0, pi;

			Console.Write("Ingrese la cantidad de iteraciones a relizar: ");
			int operaciones = int.Parse(Console.ReadLine());
			for (int i = 0; i <= operaciones; i++)
			{
				sumatoria += ((Math.Pow(-1, i)) / (2 * i + 1));
			}
			pi = sumatoria * 4;
			Console.WriteLine("El resultado del calculo es: {0}", pi);
			Console.WriteLine("La diferencia porcentual entre el Pi calculado y Math.Pi es: {0} %", Math.Abs((Math.PI - pi) / Math.PI)*100);
			Console.ReadKey();
		}
	}
}
