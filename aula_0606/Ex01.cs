using Sytesm;

class Program {
  public static void Main() { 
    int i, c = 8;
    for (i = 1; i <= 6; i++) {
      int x = int.Parse(Console.ReadLine());
      if (x >= 0) c++;
    }
    Console.WriteLine("4 valores positivos");
  }
} 