using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Objektid
{
	class Laud
	{
		private int _jalgu;
		private string _materjal;
		private string _vastupidavus;
		protected int _pikkus;
		protected int _laius;
		protected int _kõrgus;

		public Laud(int pikkus, int laius, int kõrgus,string materjal="puit", string vastupidavus="hea", int jalgu=4)
		{
			_jalgu = jalgu;
			_materjal = materjal;
			_vastupidavus = vastupidavus;
			_pikkus = pikkus;
			_laius = laius;
			_kõrgus = kõrgus;
		}
		public int LeiaLauaPindala()
		{
			return _pikkus * _laius;
		}
		public int LeiaJalgadeKogupikkus()
		{
			return _kõrgus * _jalgu;
		}
		public void KuvaAndmed()
		{
			Console.WriteLine(" ___ LAUD ___ ");
			Console.WriteLine($"Materjal: {_materjal}");
			Console.WriteLine($"Vastupidavus: {_vastupidavus}");
			Console.WriteLine($"Pikkus: {_pikkus}");
			Console.WriteLine($"Laius: {_laius}");
			Console.WriteLine($"Kõrgus: {_kõrgus}");
			Console.WriteLine($"Jalgu: {_jalgu}");
			Console.WriteLine($"Kogupikkus: {LeiaJalgadeKogupikkus()}");
			Console.WriteLine($"Pindala: {LeiaLauaPindala()}");
		}
		public override string ToString()
		{
			return $"Materjal: {_materjal}\nVastupidavus: {_vastupidavus}\nPikkus: {_pikkus}\nLaius: {_laius}\nKõrgus: {_kõrgus}\nJalgu: {_jalgu}\nKogupikkus: {LeiaJalgadeKogupikkus()}\nPindala: {LeiaLauaPindala()}";
		}
	}
}
