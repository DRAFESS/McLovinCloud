
using SoundSharp.Modelos;

namespace SoundSharp.Menus;

internal class MenuExibirDetalhes : Menu
{

    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Detalhes da banda");
        Console.Write("Digite o nome da banda que deseja pesquisar : ");
        string BandaDet = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(BandaDet))
        {
            Banda banda = bandasRegistradas[BandaDet];
            Console.WriteLine(banda.Resumo);
            Console.WriteLine($"\n a média da banda {BandaDet} é {banda.Media}");
            Console.WriteLine("\nDiscografia : ");

            foreach (Album album in banda.Albuns)
            {
                Console.WriteLine($"{album.Nome} -> {album.Media}");
            }

            Console.WriteLine($"\n Digite qualquer tecla para voltar para o menu principal");
            Console.ReadKey();
            Console.Clear();

        }
        else
        {
            Console.WriteLine($"\nA banda {BandaDet} não foi encontrada");
            Console.WriteLine("Digite uma tecla para voltar para o menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
 }
