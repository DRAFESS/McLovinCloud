
using SoundSharp.Modelos;

namespace SoundSharp.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);

        ExibirTituloDaOpcao("Avaliar álbum");
        Console.Write("Digite o nome da banda que deseja avaliar : ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine("Agora digite o título do álbum : ");
            string tituloAlbum = Console.ReadLine()!;
            if (banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                Console.Write($"Qual a nota que o álbum {tituloAlbum} merece ? : ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                album.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o álbum {tituloAlbum}");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"O álbum {nomeDaBanda} não foi encontrado");
                Console.WriteLine("Digite uma tecla para voltar para o menu");
                Console.ReadKey();
                Console.Clear();
            }


        }
        else
        {
            Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
            Console.WriteLine("Digite uma tecla para voltar para o menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
