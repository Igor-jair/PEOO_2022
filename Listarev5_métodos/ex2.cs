using System;

public class Program {
  public static void Main () {
    Console.WriteLine("Digite a área do círculo");
    double raio = double.Parse(Console.ReadLine());
  }
  public static double AreaCirculo (double raio) {
    double area;
    area = 3.1459 * raio * raio;
    return area;
  }
}