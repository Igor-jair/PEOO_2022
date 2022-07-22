using System;

public class Program {
  public static void Main () {
    Console.WriteLine("Digite dois valores");
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine( Menor(a,b) );
  }
  public static double Menor (double x, double y) {
    if (x < y) return x;
    else return y;
    //return x < y ? x : y; --> operador condicional ternário
  }
}
