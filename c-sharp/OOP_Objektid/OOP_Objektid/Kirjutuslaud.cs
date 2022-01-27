using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Objektid
{
	class Kirjutuslaud : Laud
	{
		private Sahtel[] _sahtlid;
		public Kirjutuslaud(int pikkus, int laius, int kõrgus, int sahtleid, string materjal = "puit", string vastupidavus = "hea", int jalgu = 4) : base(pikkus, laius, kõrgus, materjal, vastupidavus, jalgu)
		{
			LooSahtlid(sahtleid);
		}
		/// <summary>
		/// Loob laua alla sahtlid, mis asuvad kõrvuti ja jagunevad võrdselt.
		/// Sahtli kõrgus on 1/6 laua kõrgusest.
		/// Üks sahtel on lukustatav ja kõikidest sahtlitest iga 10-s on valepõhjaga
		/// </summary>
		/// <param name="sahtleid">sahtlite kogus</param>
		/// <returns>loodud sahtlitega massiiv</returns>
		private void LooSahtlid(int sahtleid)
		{
			_sahtlid = new Sahtel[sahtleid];
			byte sahtliLaius = (byte)(_laius / sahtleid);
			byte sahtliKõrgus = (byte)(_kõrgus / 6);
			for (int i = 0; i < _sahtlid.Length; i++)
			{
				_sahtlid[i] = new Sahtel((byte)_pikkus, sahtliLaius, sahtliKõrgus, i == 0);
			}
		}
		public override string ToString()
		{
			string result="\n";
			foreach (var sahtel in _sahtlid)
			{
				result += sahtel.ToString() + "\n";
			}
			return base.ToString() + $"Kirjutuslaud: " + result;
		}
	}
}
