using System;

namespace OmaStruktuurHarjutused
{
	struct Riidelapp
	{
		public int Pikkus;
		public int Laius;
		public string Toon;
	}
	class Program
	{
		static void Main(string[] args)
		{
			string[] toonid = { "Sinine", "Punane", "Roheline", "Kollane", "Valge", "Must" };
			Random r = new Random();
			Riidelapp riidelapp1;
			riidelapp1.Pikkus = 10;
			riidelapp1.Laius = 20;
			riidelapp1.Toon = "Sinine";
			Console.WriteLine($"Pikkus: {riidelapp1.Pikkus}\nLaius: {riidelapp1.Laius}\nToon: {riidelapp1.Toon}");
			Riidelapp[] riidelapid = new Riidelapp[100];
			for (int i = 0; i < riidelapid.Length; i++)
			{
				riidelapid[i].Pikkus = r.Next(1,50);
				riidelapid[i].Laius = r.Next(1, 30);
				riidelapid[i].Toon = toonid[r.Next(toonid.Length)];
				if (riidelapid[i].Pikkus >=10 && riidelapid[i].Laius >=10)
				{
					Console.WriteLine($"{i+1} Pikkus: {riidelapid[i].Pikkus} Laius: {riidelapid[i].Laius} Toon: {riidelapid[i].Toon}");
				}
			}
		}
	}
}
