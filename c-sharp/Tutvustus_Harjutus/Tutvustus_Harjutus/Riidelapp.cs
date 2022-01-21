using System;

namespace Tutvustus_Harjutus
{
	public class Riidelapp
	{
		private int _pikkus;
		private int _laius;
		private string _toon;

		public Riidelapp(int pikkus, int laius, string toon)
		{
			_pikkus = pikkus;
			_laius = laius;
			_toon = toon;
		}

		public void Poolita()
		{
			if (_pikkus>_laius)
			{
				_pikkus /= 2;
			}
			else
			{
				_laius /= 2;
			}
		}

		public Riidelapp PoolitaUuega()
		{
			Poolita();
			return new Riidelapp(_pikkus, _laius, _toon);
		}

		public int AnnaPindala()
		{
			return _pikkus * _laius;
		}

		public Riidelapp Poolita(int allesJäävProtsent)
		{
			if (_pikkus>_laius)
			{
				var jääkPikkus = (100 - allesJäävProtsent) * _pikkus / 100;
				_pikkus -= jääkPikkus;
				return new Riidelapp(jääkPikkus, _laius, _toon);
			}
			else
			{
				var jääkLaius = (100 - allesJäävProtsent) * _pikkus / 100;
				_laius -= jääkLaius;
				return new Riidelapp(_pikkus, jääkLaius, _toon);
			}
		}

		public void KuvaAndmed()
		{
			const int laius = 10;
			Console.WriteLine(" __ Riidelapi andmed __");
			Console.WriteLine($"{"Pikkus:",-laius}{_pikkus,laius} mm");
			Console.WriteLine($"{"Laius:",-laius}{_laius,laius} mm");
			Console.WriteLine($"{"Pindala:",-laius}{AnnaPindala() / 1000000.0,laius:0.00} m\xB2");
			Console.WriteLine($"{"Toon:",-laius}{_toon,laius+3}");
		}
	}
}