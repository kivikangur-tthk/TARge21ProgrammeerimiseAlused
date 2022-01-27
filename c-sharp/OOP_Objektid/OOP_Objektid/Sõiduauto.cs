using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Objektid
{
	class Sõiduauto : Auto
	{
		protected uint _reisijaid;
		public Sõiduauto(string mark, string värv, int istekohti, string keretüüp = "luukpära") : base(mark, värv, istekohti, keretüüp)
		{
			_reisijaid = 0;
		}
		/// <summary>
		/// Laseb autosse reisijaid sisse
		/// </summary>
		/// <param name="reisijateArv">Kui palju reisijad soovib siseneda</param>
		/// <returns>Kui palju reisijaid ei mahtunud autosse</returns>
		public uint Sisene(uint reisijateArv)
		{
			var vabuKohti = _istekohti - _reisijaid;
			if (reisijateArv > vabuKohti)
			{				
				_reisijaid = (uint)_istekohti;
				return (uint)(reisijateArv - vabuKohti);
			}
			_reisijaid += reisijateArv;
			return 0;
		}
	}
}
