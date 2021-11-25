using System;
class Alamprogramm
{
 private static Random random = new Random();
 public static void Main(string[] arg)
 {
  int arv1 = 4;
  int arv2 = 6;
  Console.WriteLine($"{arv1} korda {arv2} on {Korruta(arv1,arv2)}");
  Console.WriteLine(Korruta(3, 5));
  double tulemus = Jaga(arv1, arv2);
		Console.WriteLine($"{arv1}+{arv2}={Liida(arv1,arv2)}");
		Console.WriteLine($"{arv1}/{arv2}={tulemus}");

  TrükiTärnidJuhuarvuga();

  /*
  Koosta programm, mis kutsub seda funktsiooni välja 30 korda juhuslike positiivsete täisarvudega, mis on väiksemad kui 20. Näiteks:

  ************
  *********
  **********************
  *******
  [...]
  Täienda programmi:

  Iga rea ette kirjutatakse arv, mitu sümbolit on reas.
  3 * * *
  5 * * * * *
  [...]
  Funktsiooni kutsutakse välja mitte 30 korda, vaid juhuslik arv kordi vahemikus 20 kuni 40.
  
  Funktsioon saab ette ühe argumendi asemel kaks argumenti: lisaks arvule ka sümboli, mida trükitakse.
  TrykiTärnid(4,"@")

  4 @ @ @ @
   */

 }

	private static void TrükiTärnidJuhuarvuga()
	{
		throw new NotImplementedException();
	}

	public static int Korruta(int arv1, int arv2)
 {
  return arv1 * arv2;
 }
 public static int Liida(int arv1, int arv2)
	{
  return arv1 + arv2;
	}
	private static double Jaga(int arv1, int arv2)
	{
  return (double)arv1 / arv2;
	}
 private static double Jaga(double arv1, int arv2)
 {
  return arv1 / arv2;
 }
 public static double KaheKeskmine(int arv1, int arv2)
	{
  return Jaga((double)Liida(arv1, arv2), 2);
	}
}
