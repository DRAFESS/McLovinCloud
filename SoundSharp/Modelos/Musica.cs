namespace SoundSharp.Modelos;

internal class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome {  get; }
    public Banda Artista { get;  }
    public int Duracao { get; set; }
    public bool Disponivel {  get; set; }
    public string DescricaoResumida =>
        $"a musica {Nome} pertence a banda {Artista}";
 





    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome : {Nome}");
        Console.WriteLine($"Artista : {Artista.Nome}");
        Console.WriteLine($"Duração : {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel para o plano");
        }
        else 
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}
