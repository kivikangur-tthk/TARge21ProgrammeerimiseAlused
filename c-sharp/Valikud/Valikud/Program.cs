using System;

namespace Valikud
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Palun nimi:");
			string eesnimi = Console.ReadLine();
			if (eesnimi.ToLower() == "mari")
			{
				Console.WriteLine("Tule homme minu juurde!");
			}
			else
			{
				Console.WriteLine("Mind pole homme kodus.");
			}
			Console.Write("Sisesta oma vanus: ");
			int vanus = int.Parse(Console.ReadLine());
			if (vanus > 6 && vanus <= 14) // 7-14
			{
				Console.WriteLine("Sinu jaoks on lapsepilet"); 
			}
			if (vanus < 7 || vanus > 14)	// mitte 7-14
			{
				Console.WriteLine("Sulle lapsepilet ei sobi");
			}

			decimal pirnihind = 1.7M;
			Console.WriteLine("Mitu pirni ostad?");
			decimal kogus = decimal.Parse(Console.ReadLine());
			decimal summa = kogus * pirnihind;
			Console.WriteLine("Kas kilekotti ka soovid? [jah/EI]");
			if (Console.ReadLine().ToLower() == "jah")
			{
				summa += 0.7m;
			}
			Console.WriteLine($"Kogusumma: {summa}");
		}
	}
}
