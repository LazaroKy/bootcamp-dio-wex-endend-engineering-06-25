Console.WriteLine("Estrutura de Repetição");

//Loop For
//int numero = 5;
// for (int count = 0; count <= 10; count++)
// {
//     Console.WriteLine($"{count} x {numero} = {count * numero}");
// }

//While loop
// while (numero != 0)
// {
//     Console.WriteLine(numero--);
//     Console.WriteLine("Break");
//     break;
// }

//Do while
// do
// {
//     numero--;
//     Console.WriteLine($"Loop acaba no 0, agora o valor é {numero}");
// } while (numero != 0);

bool exibirMenu = true;
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite o número de acordo com a opção que deseja executar:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    string opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastrar cliente");
            break;

        case "2":
            Console.WriteLine("Buscar cliente");
            break;

        case "3":
            Console.WriteLine("Apagar cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            //Environment.Exit(0); Sai totalmente do programa
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}
Console.WriteLine("Programa encerrado");