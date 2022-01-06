using System;

namespace JuhuarvuHarjutused
{
	class Program
	{
		static void Main(string[] args)
		{
			Random r = new Random();
			int õigeid = 0;
			while (õigeid<10)
			{
				int arv1 = r.Next(20);
				int arv2 = r.Next(20);
				int õige = arv1 * arv2;
				string[] kiitused = { "Tubli", "Väga hea", "Suurepärane" };
				string[] julgustused = { "Proovi veel", "Järgmine kord õnnestub", "Ära anna alla", "Pole hullu" };
				Console.Write($"{arv1} * {arv2} = ");
				int vastus = int.Parse(Console.ReadLine());
				if (vastus == õige)
				{
					Console.WriteLine("Õige. " + kiitused[r.Next(kiitused.Length)]);
					õigeid++;
				}
				else
				{
					Console.WriteLine("Vale. Õige vastus on " + õige + ".\n" + julgustused[r.Next(julgustused.Length)]);
				}
			}
		}
	}
}
