using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP01
{
	/// <summary>
	/// Desarrolle  una   aplicación  que  imprima  por  pantalla “UNO”,  “DOS”,  “TRES”... 
	/// “NUEVE”,  “OTROS”  si  la  variable  numero es  igual  a  1,  2,  3  …  9  ó  mayor 
	/// respectivamente. Utilice la estructura if-else para resolver el ejercicio.
	/// </summary>
	class EJ01
	{
		static void Main(string[] args)
		{
			Console.Write("Ingrese un numero: ");
			int numero = int.Parse(Console.ReadLine());

			if (numero < 1)
			{
				Console.WriteLine("MENOR");
			}
			else
			{
				if (numero == 1)
				{
					Console.WriteLine("UNO");
				}
				else
				{
					if (numero == 2)
					{
						Console.WriteLine("DOS");
					}
					else
					{
						if (numero == 3)
						{
							Console.WriteLine("TRES");
						}
						else
						{
							if (numero == 4)
							{
								Console.WriteLine("CUATRO");
							}
							else
							{
								if (numero == 5)
								{
									Console.WriteLine("CINCO");
								}
								else
								{
									if (numero == 6)
									{
										Console.WriteLine("SEIS");
									}
									else
									{
										if (numero == 7)
										{
											Console.WriteLine("SIETE");
										}
										else
										{
											if (numero == 8)
											{
												Console.WriteLine("OCHO");
											}
											else
											{
												if (numero == 9)
												{
													Console.WriteLine("NUEVE");
												}
												else
												{
													Console.WriteLine("OTRO");
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			Console.ReadKey();
		}
	}
}