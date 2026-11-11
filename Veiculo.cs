namespace Lista_de_Exercicios
{
    public abstract class Veiculo
    {
       public string? Marca { get; set; } 

       public string? Modelo { get; set; }
    

    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
    }
    }
}