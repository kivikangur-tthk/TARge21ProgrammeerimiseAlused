using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiidesedDemo
{
	class Laps : Inimene, IViisakas
	{
		public Laps(int vanus) : base(vanus)
		{
		}

		public void KoputaUksele(int korda)
		{
			for (int i = 0; i < korda; i++)
			{
				Console.Write("KOP ");
			}
			Console.WriteLine();
		}
	}
}
