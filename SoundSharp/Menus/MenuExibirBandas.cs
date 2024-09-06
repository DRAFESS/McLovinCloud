

using SoundSharp.Modelos;

namespace SoundSharp.Menus;


    internal class MenuExibirBandas : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            Console.Clear();
            ExibirTituloDaOpcao("Exibindo as bandas registradas");

            foreach (string i in bandasRegistradas.Keys)
            {
                Console.WriteLine($"Banda : {i}");
            }

            Console.WriteLine("Digite qualquer tecla para voltar para o menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
