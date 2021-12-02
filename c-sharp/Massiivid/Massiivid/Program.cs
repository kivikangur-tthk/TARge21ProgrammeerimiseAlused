using System;
class Massiiv1
{
	public static void Main(string[] arg)
	{
		int[] m = new int[3];
		m[0] = 40;
		m[1] = 48;
		m[2] = 33;
		KuvaSummaTehe(m);
		int[] arvud = { 1, 2, 3, 7, 8, 9, 4, 5, 6, 0, 2, 3, 7 };
		KuvaSummaTehe(arvud);
		Array.Sort(arvud);
		KuvaSummaTehe(arvud);


	}

	private static void KuvaSummaTehe(int[] m)
	{
		int summa = 0;
		for (int i = 0; i < m.Length; i++)
		{
			Console.Write(m[i]);
			if (i < m.Length - 1)
			{
				Console.Write("+");
			}
			summa += m[i];
		}
		Console.WriteLine("=" + summa);
	}
}
