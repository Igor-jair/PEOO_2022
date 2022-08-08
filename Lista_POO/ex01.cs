using System;

class Circulo{
  public double raio;
  public double Area() {
    return Math.PI * raio * raio;
  }
  public double Circuferencia() {
    return 2 * Math.PI * raio;
  } 
}

class Program {
  public static void Main() {
    Circulo a = new Circulo();
    Circulo b = new Circulo();
    Circulo c = new Circulo();
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine(a.raio);
    Console.WriteLine(b.raio);
    Console.WriteLine(c.raio);
    Console.WriteLine("Digite o raio do 1ª círculo");
    a.raio = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o raio do 2ª círculo");
    b.raio = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o raio do 3ª círculo");
    c.raio = double.Parse(Console.ReadLine());
    
  }
}