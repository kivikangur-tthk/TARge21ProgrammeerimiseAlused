using System;
using System.Linq;

namespace MassiiviHarjutused
{
	class Program
	{
		static void Main(string[] args)
		{
			//* Küsi kasutaja käest viis arvu ning väljasta need tagurpidises järjekorras.
			int[] arvud = new int[5];
			for (int i = 0; i < arvud.Length; i++)
			{
				Console.Write($"Sisesta {i+1}. täisarv:");
				arvud[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("Sisestatud arvud alates viimasest.");
			for (int i = arvud.Length - 1; i >= 0; i--)
			{
				Console.WriteLine(arvud[i]);
			}
			//Loo alamprogramm massiivi väärtuste aritmeetilise keskmise leidmiseks. Katseta
			double keskmine = LeiaKeskmine(arvud);
			Console.WriteLine($"Sisestatud arvude keskmine on {keskmine}");
			Console.WriteLine(arvud.Average());
			// * Loo alamprogramm, mis suurendab kõiki massiivi elemente ühe võrra. Katseta.
			Tryki(arvud); 
			LisaIgaleKaks(arvud);
			Tryki(arvud);
			// * Sorteeri massiiv ning väljasta selle keskmine element.
			Array.Sort(arvud);
			Console.WriteLine($"Sorteeritud massiivi keskel on {arvud[arvud.Length/2]}");
			// * Koosta kahemõõtmeline massiiv ning täida korrutustabeli väärtustega. Küsi massiivist kontrollimiseks väärtusi.
			int[,] korrutusTabel = LooKorrutusTabel(100, 100);
			Console.WriteLine($"100*100={korrutusTabel[100,100]}");
			Tryki(korrutusTabel);
		}
		private static int[,] LooKorrutusTabel(int ridu, int veerge)
		{
			int[,] tulemus = new int[ridu+1, veerge+1];
			for (int rida = 0; rida < tulemus.GetLength(0); rida++)
			{
				for (int veerg = 0; veerg < tulemus.GetLength(1); veerg++)
				{
					tulemus[rida,veerg]	= rida * veerg;
				}
			}
			return tulemus;
		}

		private static void LisaIgaleKaks(int[] arvud)
		{
			for (int i = 0; i < arvud.Length; i++)
			{
				arvud[i] += 2;
			}
		}
		static void Tryki(int[] mas)
		{
			for (int i = 0; i < mas.Length; i++)
			{
				Console.Write(mas[i]+",");
			}
			Console.WriteLine();
		}
		static void Tryki(int[,] mas)
		{
			for (int i = 0; i < mas.GetLength(0); i++)
			{
				for (int j = 0; j < mas.GetLength(1); j++)
				{
					Console.Write($"{mas[i, j],5}");
				}
				Console.WriteLine();
			}
		}

		private static double LeiaKeskmine(int[] massiiv)
		{
			long summa = 0;
			for (int i = 0; i < massiiv.Length; i++)
			{
				summa += massiiv[i];
			}
			return (double)summa / massiiv.Length;
		}
	}
}
