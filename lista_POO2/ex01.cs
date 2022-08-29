using System;

class Circulo{
  private double raio;
  public void SetRaio (double v){
    if (v > 0) raio = v;
  } 
  public double GetRaio (){
    return raio;
  }
  public double CalcArea(){
    double area = 3.14 * raio * raio;  //double area = Math.PI() * Math.Pow(raio, 2);
    return area;
  }
  public double CalcCircuferencia(){
    double circuferencia = 2 * 3.14 * raio;
    return circuferencia;
  }
}
class Program {
  private static void Main(){
    Console.WriteLine("Digite o raio galeido");
  Circulo circ = new Circulo();
  circ.SetRaio(double.Parse(Console.ReadLine()));
  Console.WriteLine(circ.GetRaio());
  Console.WriteLine(circ.CalcArea());
  Console.WriteLine(circ.CalcCircuferencia()); 
 }
}