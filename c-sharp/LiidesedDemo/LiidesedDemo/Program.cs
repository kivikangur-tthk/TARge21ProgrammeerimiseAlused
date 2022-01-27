using System;

namespace LiidesedDemo
{
	class Program
	{

		static void TuleSynnipaevale(IViisakas v)
		{
			v.KoputaUksele(3);
			v.Tervita("vanaema");
		}
		static void Main(string[] args)
		{
			var inimene = new Inimene(22);
			var laps = new Laps(5);
			var koer = new Koer();
			//TuleSynnipaevale(inimene);
			TuleSynnipaevale(laps);
			TuleSynnipaevale(koer);
		}
	}
}
