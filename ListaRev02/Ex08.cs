using System; 
public class Program {
  public static void Main() {
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());
    int menor = a;
    if (b < menor) menor = b;
    if (c < menor) menor = b;
    if (d < menor) menor = b;
    if (b < menor) menor = b;