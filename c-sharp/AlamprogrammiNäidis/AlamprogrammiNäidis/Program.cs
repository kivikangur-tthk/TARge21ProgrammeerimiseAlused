using System;
class Alamprogramm
{
 public static int Korruta(int arv1, int arv2)
 {
  return arv1 * arv2;
 }
 public static int Liida(int arv1, int arv2)
	{
  return arv1 + arv2;
	}
 public static void Main(string[] arg)
 {
  int arv1 = 4;
  int arv2 = 6;
  Console.WriteLine($"{arv1} korda {arv2} on {Korruta(arv1,arv2)}");
  Console.WriteLine(Korruta(3, 5));
  double tulemus = Jaga(arv1, arv2);
		Console.WriteLine($"{arv1}+{arv2}={Liida(arv1,arv2)}");
		Console.WriteLine($"{arv1}/{arv2}={tulemus}");
 }

	private static double Jaga(int arv1, int arv2)
	{
  return (double)arv1 / arv2;
	}
}
