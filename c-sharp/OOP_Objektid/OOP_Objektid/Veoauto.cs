using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Objektid
{
	class Veoauto : Auto
	{
		protected uint _koormaMass;
		protected uint _kandevõime;
		public Veoauto(string mark, string värv, uint kandeVõime, int istekohti=2, string keretüüp = "kastikas") : base(mark, värv, istekohti, keretüüp)
		{
			_koormaMass = 0;
			_kandevõime = kandeVõime;
		}
		/// <summary>
		/// Suurendab auto koormat parameetrina antud väärtuse võrra
		/// </summary>
		/// <param name="koormaMass">lisatud koorma mass</param>
		/// <exception cref="ArgumentOutOfRangeException">Kui koorem ületab kandevõimet</exception>
		public void LaeKoorem(uint koormaMass)
		{
			var vabaMass = _kandevõime - _koormaMass;
			if (koormaMass > vabaMass)
			{
				throw new ArgumentOutOfRangeException(nameof(koormaMass), $"Lisatava koorma mass ({koormaMass}) ületab allesjäänud kandevõimet ({vabaMass})");
			}
			_koormaMass += koormaMass;
		}
		public override string ToString()
		{
			return base.ToString()+$"\nKandevõime: {_kandevõime}\nKoorma mass: {_koormaMass}";
		}
		public override void TuuniMootorit()
		{
			Console.WriteLine("Veoauto mootorit ei näpi!");
		}
	}
}
