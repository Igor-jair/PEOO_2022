using System;

public class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase");
    string s = Console.ReadLine();
    string[] v = s.Split();
    //foreach(string p in v)  Console.WriteLine(p);
    int k = 0;
    while (k < v.Length) {
      string p = v[k];
      Console.WriteLine(p[0]);
      int c = 0;
      while (c < k) {
        Console.Write(p[0]);
        c++;
      }
      k++;
      
    }
  }
}