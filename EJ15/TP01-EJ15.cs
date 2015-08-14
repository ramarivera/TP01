using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP01
{
	/// <summary>
	/// Desarrolle una aplicación que defina un arreglo de 50 números enteros, lo inicialice 
	/// y escriba ordenados ascendentemente por consola todos los números del arreglo que 
	/// estén comprendidos entre dos números definidos a través de constantes.
	/// </summary>
	class EJ15
	{
		/// <summary>
		/// Limite inferior para el filtrado de numeros
		/// </summary>
		private const int limInferior = -300;
		/// <summary>
		/// Limite superior para el filtrado de numeros
		/// </summary>
		private const int limSuperior = 300;
		/// <summary>
		/// Generador de numeros aleatorios STATIC, para evitar valores iguales
		/// </summary>
		private static Random cRandomGenerator = new Random();
		/// <summary>
		/// Inicializa un vector con int aleatorios
		/// </summary>
		/// <param name="vector">vector a inicializar</param>
		private static void InicializarVector(int[] vector)
		{
			int length = vector.Length;
			for (int i = 0; i < length; i++)
			{
				vector[i] = GenerarAleatorio(-1000, 1000);
			}
		}
		/// <summary>
		/// Genera un nuevo int aleatorio entre min y max
		/// </summary>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns>Int aleatorio</returns>
		private static int GenerarAleatorio(int min, int max)
		{
			return cRandomGenerator.Next(min, max);
		}
		/// <summary>
		/// Muestra los elementos de un vector
		/// </summary>
		/// <param name="vector">Vector que se desea mostrar</param>
		private static void MostrarVector(int[] vector)
		{
			int length = vector.Length;
			for (int i = 0; i < length; i++)
			{
				Console.WriteLine("\tElemento {0}:\t {1}", i + 1, vector[i]);
			}
		}
		/// <summary>
		/// Ordena un vector de int ascendentemente
		/// </summary>
		/// <param name="vector">Vector que se desea ordenar</param>
		private static void OrdenarVector(int[] vector)
		{
			int length = vector.Length;
			int aux;
			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < length - 1; j++)
				{
					if (vector[j] > vector[j + 1])
					{
						aux = vector[j];
						vector[j] = vector[j + 1];
						vector[j + 1] = aux;
					}
				}
			}
		}
		/// <summary>
		/// Determina los elementos del vector que estan entre limInferior y limSuperior
		/// </summary>
		/// <param name="vector">Vector que se desea filtrar</param>
		/// <returns>Vector formado con los elementos entre los limites</returns>
		private static int[] FiltrarVector(int[] vector)
		{
			int inicio = Array.FindIndex(vector, x => x >= limInferior);
			int fin = Array.FindLastIndex(vector, x => x <= limSuperior);
			int[] resultado = new int[fin - inicio + 1];
			Array.Copy(vector, inicio, resultado, 0, fin - inicio + 1);
			return resultado;
		}

		static void Main(string[] args)
		{
			int[] vector = new int[50];
			InicializarVector(vector);
			Console.WriteLine("Mostrando vector: ");
			MostrarVector(vector);
			Console.ReadKey();
			OrdenarVector(vector);
			Console.WriteLine("Mostrando vector ordenado: ");
			MostrarVector(vector);
			Console.ReadKey();
			int[] vectorFiltrado = FiltrarVector(vector);
			Console.WriteLine("Mostrando vector filtrado: ");
			MostrarVector(vectorFiltrado);
			Console.ReadKey();
		}
	}
}