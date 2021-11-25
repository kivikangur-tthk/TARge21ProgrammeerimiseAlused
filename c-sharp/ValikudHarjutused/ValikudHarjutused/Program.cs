using System;

namespace ValikudHarjutused
{
	class Program
	{
		static void Main(string[] args)
		{
			//			*Küsi temperatuur ning teata, kas see on üle kaheksateistkümne kraadi(soovitav toasoojus talvel).
			/*			Console.WriteLine("Sisesta toa temperatuur:");
						int temperatuur = int.Parse(Console.ReadLine());
						if (temperatuur>18)
						{
							Console.WriteLine("talve korral on piisavalt soe");
						}
						else
						{
							Console.WriteLine("hakka kütma.");
						}*/
			//*Küsi inimese pikkus ning teata, kas ta on lühike, keskmine või pikk(piirid pane ise paika)
			/*			int lühikePiir = 150;
						int pikkPiir = 180;
						Console.WriteLine("Sisesta oma pikkus sentimeetrites:");
						int pikkus = int.Parse(Console.ReadLine());
						if (pikkus<lühikePiir)
						{
							Console.WriteLine("Oled lühikest kasvu");
						}
						else if (pikkus>pikkPiir)
						{
							Console.WriteLine("Oled pikka kasvu");
						}
						else
						{
							Console.WriteLine("Oled keskmist kasvu");
						}*/
			//* Küsi inimeselt pikkus ja sugu ning teata, kas ta on lühike, keskmine või pikk(mitu tingimusplokki võib olla üksteise sees).
			int mees_lühikePiir = 160;
			int mees_pikkPiir = 190;
			int naine_lühikePiir = 150;
			int naine_pikkPiir = 170;
			Console.WriteLine("Sisesta oma pikkus sentimeetrites:");
			int sooga_pikkus = int.Parse(Console.ReadLine());
			Console.WriteLine("Kas oled mees? [jah/Ei]");
			string suguMees = Console.ReadLine().ToLower();
			if (sooga_pikkus < mees_lühikePiir && suguMees == "jah" ||
							sooga_pikkus < naine_lühikePiir && suguMees != "jah")
			{
				Console.WriteLine("Oled lühikest kasvu");
			}
			else if (sooga_pikkus > mees_pikkPiir && suguMees == "jah" ||
												sooga_pikkus > naine_pikkPiir && suguMees != "jah")
			{
				Console.WriteLine("Oled pikka kasvu");
			}
			else
			{
				Console.WriteLine("Oled keskmist kasvu");
			}
			//* Küsi inimeselt poes eraldi kas ta soovib osta piima, saia, leiba. Löö hinnad kokku ning teata, mis kõik ostetud kraam maksma läheb.
			decimal piimaHind = .45m;
			decimal saiaHind = 1.2m;
			decimal leivaHind = .67m;
			decimal summa = 0;
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine($"Kas soovid piima hinnaga {piimaHind}€ ?");
			if (Console.ReadLine().ToLower() == "jah")
			{
				summa += piimaHind;
			}
			Console.WriteLine($"Kas soovid saia hinnaga {saiaHind}€ ?");
			if (Console.ReadLine().ToLower() == "jah")
			{
				summa += saiaHind;
			}
			Console.WriteLine($"Kas soovid leiba hinnaga {leivaHind}€ ?");
			if (Console.ReadLine().ToLower() == "jah")
			{
				summa += leivaHind;
			}
			Console.WriteLine($"Sinu ostud maksavad kokku {summa}€");
		}
	}
}
