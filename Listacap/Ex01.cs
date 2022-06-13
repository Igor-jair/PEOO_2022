using System;

public class Program {

  public static void Main(string[] args) {
    int dia = 6;
    int mes = 6;
    int ano = 2022;
    int hora = 10;
    int min = 06;
    Console.WriteLine(dia);
    Console.WriteLine(mes);
    Console.WriteLine(ano);
    // Convertendo para texto com ToString
    string d = dia.ToString("00");
    string m = mes.ToString("00");
    string a = ano.ToString("0000");
    Console.WriteLine(d);
    Console.WriteLine(m);
    Console.WriteLine(a);
    Console.WriteLine(d + m + a);
    Console.WriteLine(dia + mes + ano);
    Console.WriteLine(d + "/" + m + "/" + a);
    Console.WriteLine($"{dia:00}/{mes:00}/{ano:0000} {hora:00}:{min:00}");
    Console.WriteLine("{dia:00}/{mes:00}/{ano:0000}");
  }
}