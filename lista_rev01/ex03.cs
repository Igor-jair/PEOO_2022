using System;

public class Program {
  public static void Main() {
    Console.WriteLine("Digite dois números inteiros:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine($"{a} / {b} = {a / b}");
    Console.WriteLine($"{a} % {b} = {a % b}");
  }
}