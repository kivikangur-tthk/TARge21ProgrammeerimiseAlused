using System;

namespace SõneNäited
{
	class Program
	{
		static void Main(string[] args)
		{
   string s = "Juku tuli tulika kooli";
   Console.WriteLine("Pikkus: " + s.Length);
   Console.WriteLine(s.Substring(5, 4));
   Console.WriteLine("'tuli' kohal " + s.IndexOf("tuli"));
   string s2 = s.Insert(9, " vara");
   Console.WriteLine(s2);
   string s3 = s.Remove(5, 5); //Kuuendast alates viis tähte
   Console.WriteLine(s3);
   if (s.StartsWith("Juku"))
   {
    Console.WriteLine("Algab Jukuga");
   }
   if (s.IndexOf("kala") == -1)
   {
    Console.WriteLine("Siin ei ole kala");
   }
   Console.WriteLine(s.Replace("tuli", "jooksis"));
   string sl = "Tallinn,Tartu,Narva";
   string[] linnad = sl.Split(new char[] { ',' });
   foreach (string linn in linnad)
   {
    Console.WriteLine(linn);
   }
   Console.WriteLine(string.Join("; ", linnad));

   string nimedSõne = "Mia  Mall Mell";
   string[] nimed = nimedSõne.Split(" ",StringSplitOptions.RemoveEmptyEntries);
			foreach (var nimi in nimed)
			{
				Console.WriteLine(nimi);
			}
			Console.WriteLine(string.Join(" ja ",nimed));
  }
 }
}
