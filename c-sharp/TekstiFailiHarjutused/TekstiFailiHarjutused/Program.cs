using System;
using System.IO;
using System.Linq;

namespace TekstiFailiHarjutused
{
	class Program
	{
		static void Main(string[] args)
		{
			// 1. * Tekita programmi abil fail, milles oleksid arvud ja nende ruudud ühest kahekümneni
			var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var ruududFailiNimi = "ruudud.txt";
			FileStream f = new FileStream(Path.Combine(path,ruududFailiNimi), FileMode.Create, FileAccess.Write);
			StreamWriter writer = new StreamWriter(f);
			for (int i = 0; i < 20; i++)
			{
				writer.WriteLine($"{i + 1} {(i + 1)*(i + 1)}");
			}
			writer.Close();

			// 3.* Iga hinna kõrval on ka selle hinnaga müüdud kauba kogus. Korruta igal real hind kogusega ning liida lõpuks summad kokku.

			var hinnadJaKogused = File.ReadAllLines(ruududFailiNimi);
			var summa = 0;
			FileStream file = new FileStream("korrutised.txt", FileMode.Create, FileAccess.Write);
			writer = new StreamWriter(file);
			foreach (var rida in hinnadJaKogused)
			{
				// "1 1" -> 1 * 1
				var hind_kogus = rida.Split();
				var hind = int.Parse(hind_kogus[0]);
				var kogus = int.Parse(hind_kogus[1]);
				summa += hind * kogus;
				writer.WriteLine(hind * kogus);
			}
			writer.Close();
			Console.WriteLine("Failis olevate hindade ja koguste korrutiste summa on "+summa);

			// 4. * Võrreldes eelmise ülesandega kirjuta teise faili igale reale esimese faili vastaval real oleva hinna ja koguse korrutis.

			var korrutised = File.ReadAllLines(ruududFailiNimi)
				.Select(rida=>
					rida.Split()
						.Select(x=>int.Parse(x))
						.Aggregate((result,num)=> result * num)
				).Select(x=>x.ToString());
			File.WriteAllLines("reaKorrutised.txt", korrutised);

			// 2. * Tekstifaili igal real on müüdud kauba hind. Arvuta programmi abil nende hindade summa.
			f = new FileStream("reaKorrutised.txt", FileMode.Open, FileAccess.Read);
			StreamReader reader = new StreamReader(f);
			string line = reader.ReadLine();
			summa = 0;
			while (line!=null)
			{
				summa += int.Parse(line);
				line = reader.ReadLine();
			}
			Console.WriteLine("Failis olevate hindade summa on " + summa);
		}
	}
}
