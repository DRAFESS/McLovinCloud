
using OpenAI_API;
using SoundSharp.Modelos;

namespace SoundSharp.Menus;


internal class MenuRegistrarBanda : Menu
{
 public  override void Executar(Dictionary<string, Banda> bandasRegistradas)
   {
                    base.Executar(bandasRegistradas);

                    Console.Clear();
                    ExibirTituloDaOpcao("Registro das bandas");
                    Console.Write("Digite o nome da banda que você deseja cadastrar: ");
                    string NomeDaBanda = Console.ReadLine()!;
                    Banda banda = new Banda(NomeDaBanda);
                    bandasRegistradas.Add(NomeDaBanda, banda);

                    var client = new OpenAIAPI("Insira_Sua_Chave_De_Api_Aqui");

                    var chat = client.Chat.CreateConversation();

                    chat.AppendSystemMessage($"Resuma a banda {NomeDaBanda} em 1 paragrafo, adote um estilo infomal");
                    string resposta =  chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
                    banda.Resumo = resposta;

                    Console.WriteLine($"A banda {NomeDaBanda} foi cadastrada com sucesso. ");
                    Console.WriteLine($"\n Digite qualquer tecla para voltar para o menu principal");
                    Console.ReadKey();
                    Console.Clear();
    }
}
