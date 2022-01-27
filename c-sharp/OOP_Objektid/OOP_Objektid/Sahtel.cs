namespace OOP_Objektid
{
	public class Sahtel
	{
		private bool _onLukustatav;
		private bool _onValePõhi;
		private byte _pikkus;
		private byte _laius;
		private byte _kõrgus;
		private static uint _sahtliteKoguarv = 0;
		public Sahtel(byte pikkus, byte laius, byte kõrgus, bool onLukustatav = false, bool onValepõhi = false)
		{
			_pikkus = pikkus;
			_laius = laius;
			_kõrgus = kõrgus;
			_onLukustatav = onLukustatav;
			_onValePõhi = onValepõhi;
			_onValePõhi = ++_sahtliteKoguarv % 10 == 0;
		}
		public override string ToString()
		{
			return $"Sahtel: {_pikkus}x{_laius}x{_kõrgus} {(_onLukustatav ? "Lukustatav" : "")} {(_onValePõhi ? "Valepõhjaga" : "")}";
		}
	}
}