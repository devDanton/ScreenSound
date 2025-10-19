string mensagemDeBoasVindas = @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░";

// List<string> listaDasBandas = new List<string> { "U2", "Coldplay", "Imagine Dragons" };
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>(); //Matriz (lista multidimensional)
bandasRegistradas.Add("Linkin Park", new List<int>{10, 8, 6});
bandasRegistradas.Add("The Beatles", new List<int>());

void ExibirLogoApp(string input) //Funções com parâmetro
{
    Console.WriteLine(input); //Printar no console pulando linha ao final
}

void ExibirOpcoesDoMenu()
{
    ExibirLogoApp("Screen Sound");
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para listar todas as banda cadastradas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a sua opção: "); //Printar no console
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica) //Estrutura condicional Switch case
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            MostrarMediaDaBanda();
            break;
        case 0:
            Console.WriteLine("Tchau Tchau :) " + opcaoEscolhidaNumerica);
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void ExibirTitulo(string cabecalho)
{
    int quantidadeDeLetras = cabecalho.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine($"{asteriscos}");
    Console.WriteLine(cabecalho);
    Console.WriteLine($"{asteriscos}\n");
 }

void RegistrarBanda()
{
    Console.Clear();
    ExibirTitulo("Registro de Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>()); //Adiciona chave ao dicionário com uma lista vazia
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!"); //Interpolação de string
    Thread.Sleep(2000); //Delay de 2 segundos
    Console.Clear(); //Limpar o console
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas(){
    Console.Clear();
    ExibirTitulo("Lista de Bandas Registradas");
    
    // for (int i = 0; i < listaDasBandas.Count; i++) //For
    // {
    //     Console.WriteLine($"Banda: {listaDasBandas[i]}");
    // }

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
    Thread.Sleep(1000);
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTitulo("Avaliar Bandas");
    bandasRegistradas.Keys.ToList().ForEach(banda => Console.WriteLine(banda.ToString()));
    Console.Write("\nDigite o nome da banda para avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a sua nota para a banda {nomeDaBanda}? (0 a 10): ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}!");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A {nomeDaBanda} banda digitada não foi encontrada.");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal...");
        Console.ReadKey();
        ExibirOpcoesDoMenu();
    }
}

void MostrarMediaDaBanda()
{
    throw new NotImplementedException();
}

ExibirOpcoesDoMenu();



