using System;

class IMC{
  private double peso;
  private double altura;

  public void SetPeso(double p){
    if (p > 0) peso = p;
  }
  public void SetAltura(double a){
    if (a > 0) altura = a;
  }
  public double GetPeso(){
    return peso;
  }
  public double GetAltura(){
    return altura;
  }
  public double CalcIMC(){
    return peso / (altura * altura);
  }
}
 class Program {
   public static void Main(){
     IMC a = new IMC();
     Console.WriteLine("Digite seu peso");
     a.SetPeso(double.Parse(Console.ReadLine()));
     Console.WriteLine("Digite sua altura");
     a.SetAltura(double.Parse(Console.ReadLine()));
     Console.WriteLine(a.GetPeso());
     Console.WriteLine(a.GetAltura());
     Console.WriteLine(a.CalcIMC());
   }
 }
