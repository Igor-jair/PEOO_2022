using System;

class Ingresso {
  public string dia = "domingo";
  public int hora = 14;
}

class Program {
  public static void Main() {
    Ingresso x = new Ingresso;
    Console.WriteLine(x);
    Console.WriteLine(x.dia);
    Console.WriteLine(x.hora);
    Console.WriteLine("Informe o dia da sessão");
    Console.WriteLine("(dom, seg, ter, quar, quin, sex, sab)");
    x.dia = Console.ReadLine();
    Console.WriteLine("Informe o horário da sessão");
    
  }
}