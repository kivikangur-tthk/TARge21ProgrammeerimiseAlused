using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Objektid
{
	class Reha
	{
		private string _varreMaterjal;
		private string _rehaMaterjal;
		private uint _pulkadeArv;
		private uint _varrePikkus;

		// Leia maksimaalne pulkade arv kui nende laius on 1,5cm, pulkade vahe on 1 cm ja nende mahutamiseks on ruumi 53cm (töölaius)
		public static int ArvutaPulkadeArv(double pulgaDiameeter, double pulkadeVahe, double rehaLaius)
		{
			return (int)Math.Floor((rehaLaius-pulgaDiameeter)/(pulgaDiameeter+pulkadeVahe)+1);
		}

		public Reha(string varreMaterjal, uint pulkadeArv, uint varrePikkus, string rehaMaterjal = "metall")
		{
			_varreMaterjal = varreMaterjal;
			_pulkadeArv = pulkadeArv;
			_varrePikkus = varrePikkus;
			_rehaMaterjal = rehaMaterjal;
		}
		public void VahetaVars(string materjal, uint pikkus)
		{
			_varreMaterjal = materjal;
			_varrePikkus = pikkus;
		}
		public void VahetaOts(string materjal, uint pulkadeArv)
		{
			_rehaMaterjal = materjal;
			_pulkadeArv = pulkadeArv;
		}
		public void SaeVarsLühemaks(uint pikkus)
		{
			if (pikkus >= _varrePikkus)
			{
				throw new ArgumentOutOfRangeException("Vart ei saa rohkem lõigata kui on tema pikkus.");
			}
			_varrePikkus -= pikkus;
		}
		public bool RehaOnSobivaPikkusega(uint inimesePikkus)
		{
			return inimesePikkus * 80 / 100 <= _varrePikkus;
		}
	}
}
