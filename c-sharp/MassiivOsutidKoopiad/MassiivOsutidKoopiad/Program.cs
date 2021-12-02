using System;

namespace MassiivOsutidKoopiad
{
	class Program
	{
		static void Main(string[] args)
		{
			int arv = 55555;
			int arv2 = arv;
			string[] nimed = { "Jaan", "Jaanika", "Juss", "Julia" };
			string[] kohad = nimed;
			Console.WriteLine(kohad[0]);
			Console.WriteLine(nimed[0]);
			kohad = (string[])nimed.Clone();
			kohad[0] = "Teet";
			Console.WriteLine(kohad[0]);
			Console.WriteLine(nimed[0]);
			Array.Clear(kohad,0,kohad.Length);
			 
			foreach (var koht in kohad)
			{
				Console.WriteLine(koht); // koht.Length annab errori, sest sõne default on null
			}
			nimed[0] = "Julia";
			Console.WriteLine($"Julia asub nimed massivis kohal: {Array.IndexOf(nimed,"Julia")}");
			Console.WriteLine($"Julia asub kohad massiivis kohal: {Array.IndexOf(kohad, "Julia")}"); // puuduv element annab tulemuseks -1

			LisaTervitus(nimed);
			KuvaMassiiv(nimed);
		}

		private static void KuvaMassiiv(string[] array)
		{
			foreach (var item in array)
			{
				Console.WriteLine(item);
			}
		}

		private static void LisaTervitus(string[] nimed)
		{
			for (int i = 0; i < nimed.Length; i++)
			{
				nimed[i] = "Tere, " + nimed[i];
			}
		}
	}
}
