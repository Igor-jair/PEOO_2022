using System;

public class Program {
  public static void Main() {
    Console.WriteLine("Digite dois valores inteiros");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int maior, menor;
    if (a > b) {
      maior = a;
      menor = b;
    }
    else{
      maior = b;
      menor = a;
    }
    int x = 10;
    while (x >= 1){
      Console.WriteLine(x);
      x --;
    }
  }
}