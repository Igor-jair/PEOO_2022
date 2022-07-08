using System;

public class Program {
  public static void Main () {
    Console.WriteLine("Digite um texto");
    string s = Console.ReadLine();
    //Console.WriteLine(s.Substring(0, 1));
    //Console.WriteLine(s.Substring(1));
    int i = 1;
    while (i <= s.Length){
    s = s.Substring(1) + s.Substring(0, 1);
    Console.WriteLine(s);
  }
}