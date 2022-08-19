using System;

public class Program {
  public static void Main() {
    Console.WriteLine("Digite sua data de nascimento:");
    string data = Console.ReadLine();
    string[] v = data.Split('/');
    int ano = int.Parse(v[2]);
    int idade = 2022 - ano;
    Console.WriteLine($"No final de 2022, você terá {idade} anos");
  }
}