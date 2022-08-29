using System;

class Compra{
  private double total;
  private int numPrestacoes;

  public void SetTotal(double total){
    if (total > 0) this.total = total; 
      //this acontece quando o atributo e o parâmetro tem o mesmo nome, se refere ao valor privado
  }
  public void SetNumPrestacoes(int numPrestacoes){
    if (numPrestacoes > 0) this.numPrestacoes = numPrestacoes;
  }
  public double GetValorPrestacoes(){
    return total / numPrestacoes; 
  }
  public double GetValorDesconto(){
    return total - total * 0.15;
  }
}
class Program {
  public static void Main(){
    Compra b = new Compra();
    Console.WriteLine("Digite o total");
    b.SetTotal(double.Parse(Console.ReadLine()));
    Console.WriteLine("Digite sua prestação");
    b.SetNumPrestacoes(int.Parse(Console.ReadLine()));
    Console.WriteLine(b.GetValorPrestacoes());
    Console.WriteLine(b.GetValorDesconto());
  }
}