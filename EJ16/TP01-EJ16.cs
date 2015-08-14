using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP01
{
	/// <summary>
	///   Desarrolle  una  aplicación  que  permita  ingresar  dos  cadenas  de  caracteres  por 
	///   teclado, determine si son anagramas y escriba el resultado de dicha comprobación 
	///   por consola. 
	/// </summary>
	class EJ16
	{
		/// <summary>
		/// Verifica si todos los caracteres de una cadena estan la misma cantidad de veces en la segunda; Verifica si son Anagramas
		/// </summary>
		/// <param name="cad1">Cadena 01 a comparar</param>
		/// <param name="cad2">Cadena 02 a comparar</param>
		/// <returns>True si son anagramas, False otherwise</returns>
		private static bool EvaluarAnagrama(string cad1, string cad2)
		{
			StringBuilder sb1 = new StringBuilder(cad1);
			StringBuilder sb2 = new StringBuilder(cad2);
			for (int i = 0; i < sb1.Length; i++)
			{
				for (int j = 0; j < sb2.Length; j++)
				{
					if (sb1[i] == sb2[j])
					{
						sb2.Remove(j, 1);
						break;
					}
				}
			}
			return (sb2.Length == 0);
		}

		static void Main(string[] args)
		{
			string cadena1, cadena2;
			Console.Write("Ingrese la primer cadena: ");
			cadena1 = Console.ReadLine();
			Console.Write("Ingrese la segunda cadena: ");
			cadena2 = Console.ReadLine();
			Console.Write(EvaluarAnagrama(cadena1, cadena2) ? "Las cadenas son Anagramas" : "Las cadenas no son Anagramas");
			Console.ReadKey();
		}
	}
}
