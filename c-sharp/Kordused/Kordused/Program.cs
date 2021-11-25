using System;

namespace Kordused
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("WHILE");
			int loendur = 1;
			while (loendur<=5)
			{
				Console.WriteLine($"Tere {loendur}. matkaja");
				loendur++;
			}
			Console.WriteLine("FOR");
			for (int nr = 0; nr < 5; nr++)
			{
				Console.WriteLine($"Tere {nr+1}. matkaja");
			}
			Console.WriteLine("FOREACH");
			int[] arvud = { 1, 2, 3, 4, 5 };
			foreach (var arv in arvud)
			{
				Console.WriteLine($"Tere {arv}. matkaja");
			}
			Console.WriteLine("DO WHILE");
			int jrkNr = 0;
			do
			{
				Console.WriteLine($"Tere {++jrkNr}. matkaja");
			} while (jrkNr<5);
			Math.Pow(5, 3);
		}
	}
}
