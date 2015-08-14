using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP01
{
	/// <summary>
	/// Desarrolle una aplicación donde el usuario ingrese por teclado un número real, y a 
	/// partir de éste calcule y escriba por consola el área del círculo y el perímetro de su 
	/// circunferencia, donde el radio es el número ingresado.
	/// </summary>
	class EJ11
	{
		/// <summary>
		/// Calcula el area del circulo
		/// </summary>
		/// <param name="radio">Radio del circulo.</param>
		/// <returns>Area del circulo</returns>
		static double CalcularArea(double radio)
		{
			return Math.PI * Math.Pow(radio, 2);
		}

		/// <summary>
		///	Calcula el perimetro de la circunsferencia
		/// </summary>
		/// <param name="radio">Radio de la circunferencia.</param>
		/// <returns>Perimetro de la Circunsferencia</returns>
		static double CalcularPerimetro(double radio)
		{
			return Math.PI * radio * 2;
		}

		static void Main(string[] args)
		{
			Console.Write("Ingrese el radio: ");
			double radio = double.Parse(Console.ReadLine());
			Console.WriteLine("El area del circulo es: {0}", CalcularArea(radio));
			Console.WriteLine("El perimetro de la circunsferencia es: {0}", CalcularPerimetro(radio));
			Console.ReadKey();
		}
	}
}
