namespace SoundSharp.Modelos;

internal class Album : IAvaliavel
{
    private List<Musica> musicas = new List<Musica>();
    private List<Avaliacao> notas = new ();

    public Album(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; set; }

    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public double Media 
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota); 
    }

    public void ExibirMusicas()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome} : \n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($" Música : {musica.Nome}");
        }
        Console.WriteLine($"Para ouvir esre akbum inteiro você precisa de {DuracaoTotal}");
    }
}
