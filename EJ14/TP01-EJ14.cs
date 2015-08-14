using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP01
{
	/// <summary>
	///  Desarrolle  una  aplicación  que  defina  un  arreglo  de  30  números  reales  de  doble 
	/// precisión,  lo  inicialice  con  valores  aleatorios  y  calcule  e  imprima  en  pantalla  el 
	/// mínimo, el máximo, la suma y el promedio de los elementos del arreglo. 
	/// </summary>
	class EJ14
	{
		/// <summary>
		/// Generador de numeros aleatorios STATIC, para evitar valores iguales
		/// </summary>
		private static Random cRandomGenerator = new Random();

		/// <summary>
		/// Carga en el vector numeros aleatorios de doble presicion
		/// </summary>
		/// <param name="vector">Vector que se desea inicializar</param>
		private static void InicializarVector(double[] vector)
		{
			int length = vector.Length;
			for (int i = 0; i < length; i++)
			{
				vector[i] = GenerarAleatorio(0, 1000);
			}
		}

		/// <summary>
		/// Genera un nuevo doble aleatorio entre min y max
		/// </summary>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns>Doble aleatorio</returns>
		private static double GenerarAleatorio(double min, double max)
		{
			return min + cRandomGenerator.NextDouble() * (max - min);
		}

		/// <summary>
		/// Muestra los elementos de un vector
		/// </summary>
		/// <param name="vector">Vector que se desea mostrar</param>
		private static void MostrarVector(double[] vector)
		{
			int length = vector.Length;
			for (int i = 0; i < length; i++)
			{
				Console.WriteLine("\tElemento {0}:\t {1}", i + 1, vector[i]);
			}
		}

		/// <summary>
		/// Obtiene el maximo doble de un vector de dobles
		/// </summary>
		/// <param name="vector">vector a calcular maximo</param>
		/// <returns>maximo doble</returns>
		private static double ObtenerMaximo(double[] vector)
		{
			int length = vector.Length;
			double max = vector[0];
			for (int i = 1; i < length; i++)
			{
				if (vector[i] > max)
				{
					max = vector[i];
				}
			}
			return max;
		}

		/// <summary>
		/// Obtiene el minimo doble de un vector de dobles
		/// </summary>
		/// <param name="vector">vector que se desea calcular el minimo</param>
		/// <returns>Minimo doble</returns>
		private static double ObtenerMinimo(double[] vector)
		{
			int length = vector.Length;
			double min = vector[0];
			for (int i = 1; i < length; i++)
			{
				if (vector[i] < min)
				{
					min = vector[i];
				}
			}
			return min;
		}

		/// <summary>
		/// Realiza la sumatoria de los elementos de un vector de dobles
		/// </summary>
		/// <param name="vector">vector a sumar</param>
		/// <returns>Sumatoria de los dobles</returns>
		private static double SumatoriaVector(double[] vector)
		{
			int length = vector.Length;
			double acu = 0;
			for (int i = 0; i < length; i++)
			{
				acu += vector[i];
			}
			return acu;
		}


		static void Main(string[] args)
		{
			double[] vector = new double[30];
			InicializarVector(vector);
			Console.WriteLine("Mostrando vector: ");
			MostrarVector(vector);
			double sumatoria = SumatoriaVector(vector);
			Console.WriteLine("El valor maximo es: {0}", ObtenerMaximo(vector));
			Console.WriteLine("El valor minimo es: {0}", ObtenerMinimo(vector));
			Console.WriteLine("La sumatoria de los elementos es: {0}", sumatoria);
			Console.WriteLine("El promedio es: {0}", sumatoria / vector.Length);
			Console.ReadKey();
		}
	}
}
