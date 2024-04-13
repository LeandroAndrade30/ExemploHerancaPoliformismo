using System;

// Criação da classe Base Veiculo
public class Veiculo
{
    public virtual void MostrarVelocidadeMaxima()
        {
            Console.WriteLine("Velocidade Máxima não definida");
          
        }
    
}

// Criação da classe Devrivada Moto que herda 
// o método MostrarVelocidadeMaxima da classe Base Veiculo
// que tem seu comportamento alterado ou diferente
// da classe base.
public class Moto : Veiculo
{
    public override void MostrarVelocidadeMaxima()
    {
        Console.WriteLine("Velocidade Máxima 150km/h");
    }
}



// Criação da classe Devrivada Caminhão que herda 
// o método MostrarVelocidadeMaxima da classe Base Veiculo
// onde tem seu comportamento alterado ou diferente
// da classe base.
public class Caminhao : Veiculo
{
    public override void MostrarVelocidadeMaxima()
    {
        Console.WriteLine("Velocidade Máxima 120Km/h");
    }
}


// Criação da classe Devrivada Triciclo que herda 
// o método MostrarVelocidadeMaxima da classe Base Veiculo
// onde tem seu comportamento alterado ou diferente
// da classe base.

public class Triciclo : Veiculo
{
    public override void MostrarVelocidadeMaxima()
    {
        Console.WriteLine("Velocidade máxima 100Km/h");
    }
}


 public class Program
{

  public static void Main(string[] args)
 {
    // Crição de Objetos das Classes Derivadas

    Moto Susuki = new Moto();
    Caminhao Scania = new Caminhao();
    Triciclo triciclo1 = new Triciclo();

    // Chamadas do Métodos  MostrarVelocidadeMaxima de cada objeto"
     
    Susuki.MostrarVelocidadeMaxima();
    Scania.MostrarVelocidadeMaxima();
    triciclo1.MostrarVelocidadeMaxima();
    
 }

}
