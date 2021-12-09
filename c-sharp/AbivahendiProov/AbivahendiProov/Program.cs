using System;

namespace AbivahendiProov
{
	class Program
	{
		static void Main(string[] args)
		{
			int summa = Abivahendid.Liida(5, 6);
			int korrutis = Abivahendid.Korruta(5, 6);
			//	* Lisa käsklus täisarvude astendamiseks tsükli abil.Katseta
			int astendus = Abivahendid.Astenda(5, 6);
			// * Lisa kolmas fail paari tärnidest kujundeid joonistava funktsiooniga.Katseta peaprogrammis mõlema abifaili funktsioonide väljakutseid.
			Joonistaja.TeeRuut();
			Joonistaja.TeeJoon();

			Console.WriteLine(summa);
			Console.WriteLine(korrutis);
			

		}
	}
}
