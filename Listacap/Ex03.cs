using System;

public class Program {
  
  public static void Main(string[] args) {
    double raio, vol;
    Console.WriteLine("Digite a raio da esfera");
    raio = double.Parse(Console.ReadLine());
    vol = 4.0/3 * 3.14159 * raio * raio * raio;
    Console.WriteLine($"VOLUME = {vol:0.000}");
  }
}