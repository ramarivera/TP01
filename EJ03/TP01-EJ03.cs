using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* */

namespace TP01
{
	/// <summary>
	/// Desarrolle  una  aplicación  que  imprima  por  pantalla  la  suma  de  la  números  de  un 
	/// límite  inferior  (por  ej  5)  hasta  el  límite  superior (ej  100).  Muestre  por  pantalla  el 
	/// promedio  de  los  números  ingresados.  Los  límites  deben  ser  constantes.  Utilice  la 
	/// sentencia for.
	/// </summary>
	class EJ03
	{
		public const int LIM_INFERIOR = 5, LIM_SUPERIOR = 100;

		static void Main(string[] args)
		{
			int suma = 0, con = 0;
			for (int i = LIM_INFERIOR; i < LIM_SUPERIOR; i++)
			{
				con++;
				suma += i;
			}
			Console.WriteLine("La suma es: {0}", suma);
			Console.WriteLine("El total de numeros sumados es: {0}", con);
			Console.WriteLine("El promedio es: {0}", suma / con);
			Console.ReadKey();
		}
	}
}
