namespace Lista_de_Exercicios
{
    public class Carro : Veiculo // o simbolo ":" indica que a classe Carro herda da classe Veiculo 
    {
        public int NumeroDePortas { get; set; }
    

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Número de Portas: {NumeroDePortas}");
    }
    
    }
}  