using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("digite a primeira nota");
    int nota1 = int.Parse(Console.ReadLine());
    Console.WriteLine("digite a primeira nota");
    int nota2 = int.Parse(Console.ReadLine());
    int media = (nota1 * 2 + nota2 * 3)/5;
    Console.WriteLine("media = " + media);
    
  }
}