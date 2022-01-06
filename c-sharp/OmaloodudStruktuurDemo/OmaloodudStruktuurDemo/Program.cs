using System;

namespace OmaloodudStruktuurDemo
{
	struct Punkt
	{
		public int x;
		public int y;
		public string nimi;
	}

	class Program
	{
		static void Main(string[] args)
		{
			// a-1,2 b-3,4 c-4,5
			Punkt a;
			a.x = 1;
			a.y = 2;
			a.nimi = "a";
			Punkt b;
			b.x = 3;
			b.y = 4;
			b.nimi = "b";
			Punkt c;
			c.x = 4;
			c.y = 5;
			c.nimi = "c";
			int[] xid = { 1, 3, 4 };
			int[] yid = { 2, 4, 5 };
			Punkt[] punktid = new Punkt[3] { a, b, c };
			Console.WriteLine(a.x+" "+punktid[0].x);
			a.x = 11;
			a.nimi = "null";
			Console.WriteLine(a.x + " " + punktid[0].x);
		}
	}
}
