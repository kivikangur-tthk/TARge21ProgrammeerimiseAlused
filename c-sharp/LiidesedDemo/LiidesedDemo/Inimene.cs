using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiidesedDemo
{
	class Inimene
	{
		protected int _vanus;
		public Inimene(int vanus)
		{
			_vanus = vanus;
		}
		public virtual void ÜtleVanus() { Console.WriteLine($"Minu vanus on {_vanus} aastat."); }

		//* Lisa Inimesele käsklus "KutsuEttekandja", katseta seda eksemplari juures.
		public virtual void KutsuEttekandja() { Console.WriteLine("Ettekandja. Siia!"); }

		public override string ToString()
		{
			return $"{GetType().Name}:\n\tVanus: {_vanus}";
		}

		public void Tervita(string keda)
		{
			Console.WriteLine("Tere, "+keda);
		}
	}
}
