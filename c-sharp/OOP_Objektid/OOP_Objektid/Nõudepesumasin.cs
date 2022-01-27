using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Objektid
{
	class Nõudepesumasin
	{
		private int _taldrikuKohta;
		private int _pestavadTaldrikud;
		private bool _tabletOnSisestatud;
		private Olek _olek;

		public Nõudepesumasin(int taldrikuKohta)
		{
			_taldrikuKohta = taldrikuKohta;
			_olek = Olek.Laadimine;
		}
		/// <summary>
		/// Pane mustad taldrikud masinasse
		/// </summary>
		/// <param name="taldrikuid">mitu taldrikut paned</param>
		/// <returns>taldrikute kogus, mis ei mahtunud</returns>
		public int Täida(int taldrikuid)
		{
			if (taldrikuid > _taldrikuKohta - _pestavadTaldrikud)
			{
				_pestavadTaldrikud = _taldrikuKohta;
				var jääk = taldrikuid - _taldrikuKohta - _pestavadTaldrikud;
				return jääk;
			}
			_pestavadTaldrikud += taldrikuid;
			return 0;
		}
		public void LisaPesutablet()
		{
			_tabletOnSisestatud = true;
		}
		public void PeseNõud()
		{
			if (_olek==Olek.Laadimine && _tabletOnSisestatud)
			{
				_olek = Olek.Pesu;
				Console.WriteLine("vee sissevõtt");
				Console.WriteLine("vee soojendamine");
				Console.WriteLine("aine segatakse veega jne.");
				_tabletOnSisestatud = false;
				_olek = Olek.Kuivatus;
				Console.WriteLine("Nõud pestud. Toimub kuivatamine.");
				_olek = Olek.Lõpp;
			}
			else
			{
				throw new Exception($"Masin on vales olekus või tablet sisestamata. Olek: {_olek}; Tablet sisestatud: {_tabletOnSisestatud}");
			}
		}
		public void Tühjenda()
		{
			if (_olek==Olek.Lõpp)
			{
				_pestavadTaldrikud = 0;
				_olek = Olek.Laadimine;
			}
			else
			{
				throw new Exception($"Masin on vales olekus. Olek: {_olek}");
			}
		}
		public void KuvaAndmed()
		{
			Console.WriteLine(nameof(Nõudepesumasin));
			Console.WriteLine($"Täituvus: {_pestavadTaldrikud}/{_taldrikuKohta}");
			Console.WriteLine($"Olek: {_olek}");
			Console.WriteLine($"Pesutablet: {(_tabletOnSisestatud?"sees":"puudu")}");
		}
	}
}
