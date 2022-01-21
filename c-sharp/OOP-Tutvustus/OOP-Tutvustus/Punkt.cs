using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tutvustus
{
	// 1. Klassi loomine
	class Punkt
	{
		// 2. Väljade loomine
		private int _x;
		private int _y;
		private int _z;
		private int _nr;
		// Klassimuutuja
		private static int _loendur = 0;
		// 3. Konstruktori loomine
		public Punkt(int x, int y, int z)
		{
			// 4. Väljade algväärtustamine
			_x = x;
			_y = y;
			_z = z;
			_nr = ++_loendur;
		}
		// 5. Tee midagi kasulikku
		public int GetX() { return _x; }
		public void SetX(int x) { _x = x; }
		public int GetY() { return _y; }
		public int GetZ() { return _z; }
		public double GetKaugusNullist() { return Math.Sqrt(_x * _x + _y * _y + _z*_z); }
		public static void KuvaPunktideKogus()
		{
			Console.WriteLine($"Programmis on loodud {_loendur} Punkti klassi isendit.");
		}
	}
}
