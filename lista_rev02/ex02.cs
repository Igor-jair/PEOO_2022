using System;

public class Program {
  public static void Main() {
    Console.WriteLine("Digite sua data de nascimento:");
    string data = Console.ReadLine();
    string[] v = data.Split('/');
    int ano = int.Parse(v[2]);
    int idade = 2022 - ano;
    if (idade >= 0 && idade <= 19) Console.WriteLine("Você está na faixa etária: Jovem");
    if (idade >= 20 && idade <= 59) Console.WriteLine("Você está na faixa etária: Adulto");
    if (idade >= 60) Console.WriteLine("Você está na faixa etária: Idoso");
  }
}