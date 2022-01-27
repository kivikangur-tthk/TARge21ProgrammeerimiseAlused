using System;

namespace OOP_Objektid
{
	class Program
	{
		static void Main(string[] args)
		{
			//var mersu = new Auto("Mercedes-Benz", "Hõbe", 5, "sedaan");
			//Console.WriteLine($"Mersu värv: {mersu.AnnaVärvus()}");
			//mersu.MuudaVärv("Hõbe", true);
			//Console.WriteLine($"Mersu uus värv: {mersu.AnnaVärvus()}");
			//mersu.TuuniMootorit();
			//mersu.KuvaAndmed();
			//mersu.VahetaVeljed(22);
			//mersu.TuuniMootorit();
			//mersu.KuvaAndmed();
			//mersu.MuudaIstekohti(1);
			//mersu.TuuniMootorit();
			//mersu.KuvaAndmed();
			////mersu.VahetaVeljed(-5);
			////mersu.KuvaAndmed();
			////mersu.MuudaIstekohti(-1);
			////mersu.KuvaAndmed();
			//while(mersu.TäiustaSisustust())
			//{
			//	Console.WriteLine("Täiustamine õnnestus. Uued andmed:");
			//	mersu.KuvaAndmed();
			//}
			//Console.WriteLine("Enam paremaks minna ei saa.");

			//var draakon = new Kõrremahl("Laim", "sinine", 1, "Põltsamaa");
			//draakon.LahjendaVeega(2.5);
			//draakon.KuvaAndmed();
			//var draakon2 = draakon.PakendaÜmber();
			//Console.WriteLine("Kaks draakonit:");
			//draakon.KuvaAndmed();
			//draakon2.KuvaAndmed();
			//var laud = new Laud(500, 600, 600,jalgu:7);
			//laud.KuvaAndmed();
			//var masin = new Nõudepesumasin(20);
			//masin.KuvaAndmed();
			//while (masin.Täida(3) == 0);
			//masin.KuvaAndmed();
			//masin.LisaPesutablet();
			//masin.KuvaAndmed();
			//masin.PeseNõud();
			//masin.KuvaAndmed();
			//masin.Tühjenda();
			//masin.KuvaAndmed();
			var reha = new Reha("puit", 10, 160);
			if (reha.RehaOnSobivaPikkusega(200))
			{
				Console.WriteLine("See on sulle paras.");
			}
			else
			{
				Console.WriteLine("Võta pikema varrega reha.");
			}
			Console.WriteLine("Pulki vaja: "+Reha.ArvutaPulkadeArv(1,3,10));
		}
	}
}
