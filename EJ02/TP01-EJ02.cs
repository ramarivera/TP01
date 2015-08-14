using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TP01
{
	/// <summary>
	/// Desarrolle  la  misma  aplicación  del  ejercicio  1  pero utilizando  la  estructura switch.
	/// </summary>
	class EJ02
	{
		static void Main(string[] args)
		{
			Console.Write("Ingrese un numero: ");
			int numero = int.Parse(Console.ReadLine());

			String cadena;
			if (numero < 1)
			{
				cadena = "MENOR";
			}
			else
			{
				switch (numero)
				{
					case 1:
						cadena = "UNO";
						break;
					case 2:
						cadena = "DOS";
						break;
					case 3:
						cadena = "TRES";
						break;
					case 4:
						cadena = "CUATRO";
						break;
					case 5:
						cadena = "CINCO";
						break;
					case 6:
						cadena = "SEIS";
						break;
					case 7:
						cadena = "SIETE";
						break;
					case 8:
						cadena = "OCHO";
						break;
					case 9:
						cadena = "NUEVE";
						break;
					default:
						cadena = "OTRO";
						break;
				}
			}
			Console.WriteLine("La respuesta es: {0}", cadena);
			Console.ReadKey();
		}
	}
}
