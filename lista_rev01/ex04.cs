using System;

public class Program {
  public static void Main() {
    Console.WriteLine("Digite três números inteiros:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int soma = 0;
    if (a < b && a < c) soma = b + c;
    if (b < a && b < c) soma = a + c;
    if (c < a && c < b) soma = a + b;
    Console.WriteLine($"Soma dos dois maiores = {soma}");
  }
}