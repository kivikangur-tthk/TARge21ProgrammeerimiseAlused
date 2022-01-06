using System;

namespace JuhuarvDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Random r = new Random();
			Console.WriteLine("0"+"-"+(int.MaxValue-1));
			Console.WriteLine(r.Next());
			Console.WriteLine(r.Next(10));
			Console.WriteLine(r.Next(10, 100));
			Console.WriteLine(r.NextDouble());
			Console.WriteLine(r.Next(10)+r.NextDouble());
		}
	}
}
