using System;

namespace Tutvustus_Harjutus
{
	class Program
	{
		static void Main(string[] args)
		{
			var lapp1 = new Riidelapp(1500, 2000, "Sinine");
			lapp1.KuvaAndmed();
			int pindala = lapp1.AnnaPindala();
			lapp1.Poolita();
			lapp1.KuvaAndmed(); // Pikkus: 1500 Laius: 1000
			lapp1.Poolita();
			lapp1.KuvaAndmed(); // Pikkus: 750 Laius: 1000
			Riidelapp lapp2 = lapp1.PoolitaUuega();
			Console.WriteLine("Uuega poolitamine");
			lapp1.KuvaAndmed();
			lapp2.KuvaAndmed();
			Riidelapp lapp3 = lapp1.Poolita(25);
			Console.WriteLine("Protsendiga poolitamine");
			lapp1.KuvaAndmed();
			lapp3.KuvaAndmed();
		}
	}
}
