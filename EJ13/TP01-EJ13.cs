using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP01
{
	/// <summary>
	/// 13.  Desarrolle  una  aplicación  que  obtenga  cinco  cadenas de  caracteres  de  los
	/// parámetros  de  la  aplicación,  invierta  cada  una  de  ellas  y  escriba  por  consola  las 
	/// cadenas invertidas ordenadas descendentemente. 
	/// Para el desarrollo de la aplicación se deben tener las siguientes consideraciones: 
	///		1.  Se debe indagar el uso del parámetro argsdel método Main de la aplicación. 
	///		2.  Para  ordenar  las  cadenas  de  caracteres  no  deben  utilizarse  otras  herramientas 
	///		que ofrezca el framework más allá de las vistas hasta el momento en la cátedra.
	/// </summary>
	class EJ13
	{
		/// <summary>
		/// Iniverte los elementos de una cadena
		/// </summary>
		/// <param name="cadena"></param>
		/// <returns>Cadena invertida</returns>
		private static string InvertirCadena(string cadena)
		{
			StringBuilder resultado = new StringBuilder("");
			for (int i = cadena.Length - 1; i >=0; i--)
			{
				resultado.Append(cadena[i]);
			}
			return resultado.ToString();
		}

		/// <summary>
		/// Verifica si cadena1>cadena2
		/// </summary>
		/// <param name="cadena1"></param>
		/// <param name="cadena2"></param>
		/// <returns>True si cadena1>cadena2</returns>
		private static bool Menor(string cadena1, string cadena2)
		{
			/* for (int i = 0; i < cadena1.Length; i++)
			{
				if (cadena2.Length - 1 < i)
				{
					break;
				}
				if (cadena1[i] < cadena2[i])
				{
					return true;
				}
			}
			return false; */
			return (String.Compare(cadena1, cadena2, StringComparison.Ordinal)) < 0;
		}
		/// <summary>
		/// Muestra los elementos del vector
		/// </summary>
		/// <param name="vector"></param>
		private static void MostrarVector(string[] vector)
		{
			int length = vector.Length;
			for (int i = 0; i < length; i++)
			{
				Console.WriteLine("\tElemento {0}:\t {1}", i + 1, vector[i]);
			}
		}
		/// <summary>
		/// Revierte cada cadena del vector
		/// </summary>
		/// <param name="vector"></param>
		/// <returns>Vector con las cadenas invertidas</returns>
		private static void ProcesarVector(string[] vector)
		{
			int length = vector.Length;
			for (int i = 0; i < length; i++)
			{
				vector[i] = InvertirCadena(vector[i]);
			}
		}

		/// <summary>
		/// Ordena un vector por orden alfabetico descendente de sus strings
		/// </summary>
		/// <param name="vector"></param>
		/// <returns>Vector ordenado alfabeticamente</returns>
		private static void OrdenarVector(string[] vector)
		{
			int length = vector.Length;
			string aux;
			for (int i = 1; i < length; i++)
			{
				for (int j = 0; j < length - i; j++)
				{
					if (Menor(vector[j], vector[j + 1]))
					{
						aux = vector[j];
						vector[j] = vector[j + 1];
						vector[j + 1] = aux;
					}
				}
			}
		}

		static void Main(string[] args)
		{
			if (args.Length==0)
			{
				args = new string[] { "Ramiro", "RIVERA", "Martin", "ARRÚA", "ROBERTO" , "Ceferino" };
			} // Caso para poder probar el codigo mas rapido
			int length = args.Length;
			Console.WriteLine("El vector contiene {0} elementos: ", length);
			MostrarVector(args);
			ProcesarVector(args);
			Console.WriteLine("Elementos Invertidos: ");
			MostrarVector(args);
			OrdenarVector(args);
			Console.WriteLine("Elementos Invertidos y Ordenados: ");
			MostrarVector(args);
			Console.ReadKey();
		}
	}
}