using Excecoes.Models;
Console.WriteLine("Execeções");


// try
// {
//     //Com um path errado, uma exceção é disparada em runtime
//     string[] linhas = File.ReadAllLines("arquivaoLeitura.txt");
//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundExeception ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo, erro:  {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica, erro: {ex.Message}");
// }

new ExemploException().Metodo1();