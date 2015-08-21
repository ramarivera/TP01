using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TP01
{
	/// <summary>
	/// Desarrolle  una  aplicación  que  liste  por  consola  los años  bisiestos  comprendidos 
	/// entre  1900  y  2013,  utilizando  constantes  para  contener  el  valor  de  los  dos  años 
	/// indicados. 
	/// </summary>
	class EJ10
	{
		public const int LIM_INFERIOR = 1900, LIM_SUPERIOR = 2013;

		static void Main(string[] args)
		{
			Console.WriteLine("Listado de Anios Bisiestos entre {0} y {1}", LIM_INFERIOR, LIM_SUPERIOR);
			for (int anio = LIM_INFERIOR; anio <= LIM_SUPERIOR; anio++)
			{
				if (DateTime.IsLeapYear(anio))
				// (anio % 4 == 0 && (anio % 100 != 0 || anio % 400 == 0)) 
				{
					Console.WriteLine(anio);
				}
			}
			Console.ReadKey();
		}
	}
}
