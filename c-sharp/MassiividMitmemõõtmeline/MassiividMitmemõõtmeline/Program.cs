using System;

namespace MassiividMitmemõõtmeline
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] tabel = new int[3, 6];
			tabel[2, 2] = 17;
			KuvaMassiiv(tabel);
			int[,] ruut =
			{
				{1,2,3},
				{4,5,6},
				{7,8,9}
			};
			KuvaMassiiv(ruut);
			int[][] massiivideMassiiv =
			{
				new int[]{1,2,3},
				new int[]{1,2,3,4,5,6,76,8},
			};
		}

		private static void KuvaMassiiv(int[,] tabel)
		{
			for (int i = 0; i < tabel.GetLength(0); i++)
			{
				for (int j = 0; j < tabel.GetLength(1); j++)
				{
					Console.Write($"{tabel[i, j],5}");
				}					
				Console.WriteLine();
			}
		}
	}
}
