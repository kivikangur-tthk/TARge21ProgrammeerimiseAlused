using System;
using System.Collections.Generic;
using System.Linq;

namespace Kontrolltöö_Harjutused
{
	class Program
	{
		static void Main(string[] args)
		{
			//P1_Tuttavad();
			//P2_Arvud();
			//P3_Vanused();
			//P4_Pikkused();
			P5_Sugu();

		}
		/// <summary>
		/// a.	Loo kaks listi mehed ja naised
		/// b. Mõlemasse küsi kasutajalt vanuseid kuni tühja sisestuseni
		/// c. Loo alamprogramm, milles arvutatakse keskmine vanus
		/// d. Kirjuta ekraanile kummad on keskmiselt vanemad ja kui suur on erinevus
		/// </summary>
		private static void P5_Sugu()
		{
			List<int> mehed = new();
			List<int> naised = new();
			Console.WriteLine("Sisesta vanuseid. Lõpetamiseks tee tühi sisestus - vajuta enter.");
			string input;
			bool onMees = true;
			do
			{
				input = KüsiTäisarv(onMees?mehed:naised,$"Sisesta {(onMees?"mehe":"naise")} vanus: ");
				onMees = !onMees;
			} while (input != string.Empty);
			double mehedKeskmine = ArvutaKeskmine(mehed);
			double naisedKeskmine = ArvutaKeskmine(naised);
			if (mehedKeskmine>naisedKeskmine)
			{
				Console.WriteLine($"Keskmiselt on mehed vanemad {mehedKeskmine-naisedKeskmine} aastat.");
			}
			else if (naisedKeskmine > mehedKeskmine)
			{
				Console.WriteLine($"Keskmiselt on naised vanemad {naisedKeskmine- mehedKeskmine} aastat.");
			} else
			{
				Console.WriteLine("Keskmine vanus on võrdne.");
			}
		}

		private static double ArvutaKeskmine(List<int> numbrid)
		{
			double summa = 0;
			foreach (var arv in numbrid)
			{
				summa += arv;
			}
			return summa / numbrid.Count;
			//return numbrid.Average();
		}

		private static string KüsiTäisarv(List<int> list,string küsimus)
		{
			string input;
			Console.Write(küsimus);
			input = Console.ReadLine();
			if (input != string.Empty)
			{
				list.Add(int.Parse(input));
			}
			return input;
		}

		/// <summary>
		/// a.	Loo massiiv 5 võrdselt jaotatud pikkusega
		/// b. Küsi kasutajalt 10 inimese pikkused
		/// c. Alamprogrammis leia millises pikkuse vahemikus on enim sisestusi
		/// d. Kuva tulemus ekraanile
		/// </summary>
		private static void P4_Pikkused()
		{
			int[] pikkusePiirid = { 100, 125, 150, 175, 200 };
			int[] pikkused = new int[10];
			for (int i = 0; i < pikkused.Length; i++)
			{
				Console.Write($"Sisesta {i + 1}. pikkus: ");
				pikkused[i] = int.Parse(Console.ReadLine());
			}
			int enamusÜlemIndex = LeiaEnamusPikkus(pikkused, pikkusePiirid);
			if (enamusÜlemIndex==0)
			{
				Console.WriteLine($"Enamus pikkused on kuni {pikkusePiirid[enamusÜlemIndex]}");
			}
			else if (enamusÜlemIndex == -1)
			{
				Console.WriteLine($"Enamus pikkusi on üle {pikkusePiirid[pikkusePiirid.Length-1]}");
			}
			else
			{
			Console.WriteLine($"Enamus pikkuseid jäi vahemikku {pikkusePiirid[enamusÜlemIndex-1]}-{pikkusePiirid[enamusÜlemIndex]}");
			}

		}

		private static int LeiaEnamusPikkus(int[] pikkused, int[] pikkusePiirid)
		{
			Array.Sort(pikkusePiirid);
			int[] kogused = new int[pikkusePiirid.Length];
			foreach (var pikkus in pikkused)
			{
				for (int i = 0; i < pikkusePiirid.Length; i++)
				{
					if (pikkus<=pikkusePiirid[i])
					{
						kogused[i]++;
						break;
					}
				}
			}
			var enim = kogused.Max();
			var ülePiiri = pikkused.Length - kogused.Sum();
			if (ülePiiri>enim)
			{
				return -1;
			}
			return Array.IndexOf(kogused, enim);
		}



		/// <summary>
		/// a.	Küsi kasutajalt 5 inimese nimed ja vanused salvesta need eraldi massiividesse
		/// b. Alamprogrammis leia vanima inimese nimi ja vanus
		/// c. Kuva tulemus ekraanile
		/// </summary>
		private static void P3_Vanused()
		{
			string[] nimed = new string[5];
			int[] vanused = new int[nimed.Length];
			for (int i = 0; i < nimed.Length; i++)
			{
				Console.Write($"Sisesta {i + 1}. nimi: ");
				var nimi = Console.ReadLine();
				Console.Write($"Sisesta {nimi} vanus: ");
				var vanus = int.Parse(Console.ReadLine());
				nimed[i] = nimi;
				vanused[i] = vanus;
			}
			(string vanimaNimi, int vanimaVanus) = LeiaVanim(nimed, vanused);
			Console.WriteLine($"Kõige vanem on {vanimaNimi}, ta on {vanimaVanus} aastane.");
		}

		private static (string vanimaNimi, int vanimaVanus) LeiaVanim(string[] nimed, int[] vanused)
		{
			var vanimNimi = "";
			var vanimVanus = 0;
			for (int i = 0; i < vanused.Length; i++)
			{
				if (vanused[i] > vanimVanus)
				{
					vanimVanus = vanused[i];
					vanimNimi = nimed[i];
				}
			}
			return (vanimNimi, vanimVanus);
		}

		/// <summary>
		/// a.	Küsi kasutajalt üks arv vahemikus 5-10, ära jätka enne, kui arv on antud vahemikus
		/// b. Loo arvu suurune massiiv
		/// c. Alamprogrammis – täida massiiv teadetega mitu korda kasutaja vale arvu sisestas
		/// d. Kuva massiivi andmed ekraanile
		/// </summary>
		private static void P2_Arvud()
		{
			int arv;
			int valeSisestusi = -1;
			do
			{
				valeSisestusi++;
				Console.Write("Sisesta arv vahemikus 5-10: ");
				arv = int.Parse(Console.ReadLine());
			} while (arv < 5 || arv > 10);
			string[] teated = new string[arv];
			TäidaTeadetega(teated, valeSisestusi);
			foreach (var teade in teated)
			{
				Console.WriteLine(teade);
			}
		}

		private static void TäidaTeadetega(string[] teated, int valeSisestusi)
		{
			string teade = $"Sisestasid arvu valesti {valeSisestusi} korda.";
			Array.Fill(teated, teade);
		}

		/// <summary>
		/// a.	Loo massiiv 3 nimega
		/// b. Küsi kasutajalt iga nime kohta kas ta tunneb teda, kui ei tunne lase uus nimi sisestada
		/// c. Alamprogrammiga asenda massiivis tundmatu nimi sisestatuga
		/// d.	Kirjuta ekraanile kõik nimed eraldi reale
		/// </summary>
		private static void P1_Tuttavad()
		{
			string[] nimed = { "Juku", "Mari", "Jüri" };
			for (int i = 0; i < nimed.Length; i++)
			{
				Console.Write($"Kas tunned {nimed[i]} (jah/ei)? ");
				var vastus = Console.ReadLine();
				if (vastus == "ei")
				{
					Console.Write("Sisesta oma tuttava nimi: ");
					var uusNimi = Console.ReadLine();
					AsendaNimi(nimed, i, uusNimi);
				}
			}
			Console.WriteLine("Sinu tuttavad:");
			foreach (var nimi in nimed)
			{
				Console.WriteLine($"{nimi}");
			}
		}

		private static void AsendaNimi(string[] nimed, int i, string uusNimi)
		{
			nimed[i] = uusNimi;
		}
	}
}
