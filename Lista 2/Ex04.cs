using System; 

public class Program {

  public static void Main(string[] args) {
    double b, h, a;
    Console.WriteLine("Digite a base do retângulo");
    b = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a altura do retângulo");
    h = double.Parse(Console.ReadLine());
    a = b * h;
    Console.WriteLine("a = " + a );
    
  }
}