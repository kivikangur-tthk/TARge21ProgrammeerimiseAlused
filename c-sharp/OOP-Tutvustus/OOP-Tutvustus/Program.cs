using System;

namespace OOP_Tutvustus
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			var arv1 = 11;
			var arv2 = arv1; // var arv2=11;

			var arvud = new[] { 1, 2, 3 };
			var numbrid = arvud;
			numbrid[0] = 11;
			Console.WriteLine(arvud[0]);
			Punkt.KuvaPunktideKogus();
			var p1 = new Punkt(3, 4, 5);
			Punkt p2 = p1;
			Console.WriteLine(p1.GetX());
			Console.WriteLine(p2.GetX());
			p2.SetX(5);
			Console.WriteLine(p1.GetX());
			Console.WriteLine(p2.GetX());
			Console.WriteLine(p1.GetKaugusNullist());
			Punkt.KuvaPunktideKogus();
			Punkt[] punktid = new Punkt[50];
			Random random = new Random();
			Console.WriteLine(punktid[5]);
			for (int i = 0; i < punktid.Length; i++)
			{
				punktid[i] = new Punkt(random.Next(), random.Next(), random.Next());
				Punkt.KuvaPunktideKogus();
			}
			Console.WriteLine(punktid[5]);


		}
	}
}
