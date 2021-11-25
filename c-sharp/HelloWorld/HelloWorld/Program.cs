using System;

namespace HelloWorld
{
	class Program
	{ 
		static void Main(string[] args)
		{
			// Kommentaar
			Console.WriteLine("Esimene arv:");
			string tekst1 = Console.ReadLine();
			int arv1 = int.Parse(tekst1);
			Console.WriteLine("Teine arv:");
			int arv2 = int.Parse(Console.ReadLine());
			Console.WriteLine($"Arvude {arv1} ja {arv2} korrutis on {arv1 * arv2}");


			Console.WriteLine("Mis on sinu nimi?");
			string nimi = Console.ReadLine();
			Console.WriteLine($"Tere {nimi}!");
			Console.WriteLine("Kui vana sa oled?");
			int vanus = int.Parse(Console.ReadLine());
			Console.WriteLine("Hello World!");
			Console.WriteLine("Hello\n Universe!");

		}
	}
}
