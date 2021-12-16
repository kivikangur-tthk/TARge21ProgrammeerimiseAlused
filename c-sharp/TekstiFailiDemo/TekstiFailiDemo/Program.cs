using System;
using System.IO;

namespace TekstiFailiDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			FileStream f = new FileStream("TARge21-inimesed.txt", FileMode.Append, FileAccess.Write);
			StreamWriter writer = new StreamWriter(f);
			string nimi;
			do
			{
				Console.Write("Sisesta nimi, mida salvestada faili: ");
				nimi = Console.ReadLine();
				if(nimi!="")
					writer.WriteLine(nimi);
			} while (nimi!="");
			writer.Close();

			FileStream fr = new FileStream("TARge21-inimesed.txt", FileMode.OpenOrCreate, FileAccess.Read);
			StreamReader reader = new StreamReader(fr);
			string rida = reader.ReadLine();
			while (rida!=null)
			{
				Console.WriteLine(rida);
				rida = reader.ReadLine();
			}
			var nimed = File.ReadAllLines("TARge21-inimesed.txt");
			for (int i = 0; i < nimed.Length; i++)
			{
				Console.WriteLine($"{i+1}. {nimed[i]}");
			}

		}
	}
}
