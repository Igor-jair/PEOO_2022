using System;

public class Program {
  public static void Main() {
    Console.WriteLine("Digite o nome e a data de nascimento da 1a pessoa:");
    string s = Console.ReadLine();
    while (s != 'fim') {
      s = Console.WriteLine(s);
    }
  }
}