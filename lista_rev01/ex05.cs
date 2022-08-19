using System;

public class Program {
  public static void Main() {
    Console.WriteLine("Digite o número de alunos:");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite as notas dos alunos:");
    int soma = 0;
    int i = 0;
    while (i < a) {
      soma += int.Parse(Console.ReadLine());
      i += 1;
    }
    int media = soma / a;
    Console.WriteLine($"Média das notas = {media}");
  }
}