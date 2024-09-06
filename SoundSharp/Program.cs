using SoundSharp.Menus;
using SoundSharp.Modelos;
using System.ComponentModel;


// Antes de aplicar a chave da APi da openAI, realize a instalação da biblioteca atraves do gerênciador de soluções -> em Dependências ( com o botão direito) acesse gerênciar pacote de nuget -> pesquise por openAI e instale a biblioteca
// a aplicação da Inteligencia Artificial se encontra na classe "MenuRegistrarBandas.cs" atraves de uma aplicação de uma chave particular paga, o qual eu não realizei a publicação dela por privacidade, mas assim que você conseguir validar uma chave de API particular da OpenAI, basta apenas inserir a chave no campo direcionado



Banda ira = new Banda("ira");
ira.AdicionarNota(new Avaliacao(10));
ira.AdicionarNota(new Avaliacao(8));
ira.AdicionarNota(new Avaliacao(6));

Banda teste = new Banda("teste");


string mensagemDeBoasVindas = "\r\n████████╗███████╗██████╗░███╗░░░███╗██╗███╗░░██╗░█████╗░██╗░░░░░  ██████╗░░█████╗░\r\n╚══██╔══╝██╔════╝██╔══██╗████╗░████║██║████╗░██║██╔══██╗██║░░░░░  ██╔══██╗██╔══██╗\r\n░░░██║░░░█████╗░░██████╔╝██╔████╔██║██║██╔██╗██║███████║██║░░░░░  ██║░░██║██║░░██║\r\n░░░██║░░░██╔══╝░░██╔══██╗██║╚██╔╝██║██║██║╚████║██╔══██║██║░░░░░  ██║░░██║██║░░██║\r\n░░░██║░░░███████╗██║░░██║██║░╚═╝░██║██║██║░╚███║██║░░██║███████╗  ██████╔╝╚█████╔╝\r\n░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═╝░░░░░╚═╝╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚══════╝  ╚═════╝░░╚════╝░\r\n\r\n███╗░░░███╗░█████╗░██╗░░░░░░█████╗░██╗░░░██╗██╗███╗░░██╗  ░█████╗░██╗░░░░░░█████╗░██╗░░░██╗██████╗░\r\n████╗░████║██╔══██╗██║░░░░░██╔══██╗██║░░░██║██║████╗░██║  ██╔══██╗██║░░░░░██╔══██╗██║░░░██║██╔══██╗\r\n██╔████╔██║██║░░╚═╝██║░░░░░██║░░██║╚██╗░██╔╝██║██╔██╗██║  ██║░░╚═╝██║░░░░░██║░░██║██║░░░██║██║░░██║\r\n██║╚██╔╝██║██║░░██╗██║░░░░░██║░░██║░╚████╔╝░██║██║╚████║  ██║░░██╗██║░░░░░██║░░██║██║░░░██║██║░░██║\r\n██║░╚═╝░██║╚█████╔╝███████╗╚█████╔╝░░╚██╔╝░░██║██║░╚███║  ╚█████╔╝███████╗╚█████╔╝╚██████╔╝██████╔╝\r\n╚═╝░░░░░╚═╝░╚════╝░╚══════╝░╚════╝░░░░╚═╝░░░╚═╝╚═╝░░╚══╝  ░╚════╝░╚══════╝░╚════╝░░╚═════╝░╚═════╝░";

Dictionary<string, Banda> bandasRegistradas = new ();

bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(teste.Nome, teste);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuExibirBandas());
opcoes.Add(4, new MenuAvaliarBanda());
opcoes.Add(5, new MenuAvaliarAlbum());
opcoes.Add(6, new MenuExibirDetalhes());







void ChamarMenu()
{
    Console.WriteLine("**********************************************************************************");
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("***************************************************************************************************");
}

void ExibirOpcoesDoMenu()
{
    ChamarMenu();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda ");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para avaliar um álbum");
    Console.WriteLine("Digite 6 para exibir detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNum))
    {
     Menu menuASerExibido = opcoes[opcaoEscolhidaNum];
        menuASerExibido.Executar(bandasRegistradas);
        if(opcaoEscolhidaNum > 0) ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }

    
}


ExibirOpcoesDoMenu();
