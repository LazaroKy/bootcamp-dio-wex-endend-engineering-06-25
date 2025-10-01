using Tupla.Models;
Console.WriteLine("Tupla");

/*
//você define os tipos e os valores recebidos devem obdecer os tipos
//Dessa forma é possível nomear, mas se não declarar um nome
//Os itens aparecem de acordo com a ordem dos tipos que você definiu

//Melhor forma por permitir mais controle
(int Id, string Nome, string Vendedor, decimal Valor) tupla = (2, "Item_A", "Jota",22.43M);

Console.WriteLine("Id: " + tupla.Id);
Console.WriteLine("Nome: " + tupla.Nome);
Console.WriteLine("Vendedor: " + tupla.Vendedor);
Console.WriteLine("Valor: " + tupla.Valor);

Console.WriteLine("\n--------------------------\n");

ValueTuple<int, string, bool> tuplaCarro = (2015, "GTR", true);
Console.WriteLine("Ano:" + tuplaCarro.Item1);
Console.WriteLine("Modelo:" + tuplaCarro.Item2);
Console.WriteLine("Modificado:" + tuplaCarro.Item3);

Console.WriteLine("\n--------------------------\n");

var tuplaCreateSapato = Tuple.Create(42, "Nike", false);
Console.WriteLine("Tamanho:" + tuplaCreateSapato.Item1);
Console.WriteLine("Marca:" + tuplaCreateSapato.Item2);
Console.WriteLine("Edição limitada:" + tuplaCreateSapato.Item3);
*/

LeituraArquivo file = new LeituraArquivo();
//Pode ser declarado os tipos dos retornos ou usar var (facilita usar var)
//var resultado = file.LerArquivo("./README.md");
//Console.WriteLine("Processou? " + resultado.Sucesso);
//Console.WriteLine("Conteúdo:\n " + resultado.Linhas);
//Console.WriteLine("Total de linhas: " + resultado.NumeroDeLinhas);

// Usar o _ no lugar do nome do retorno ele traz a informação, mas explicíta o não uso
/*
var (sucesso, linhas_arquivo, _) = file.LerArquivo("./README.md");
if (sucesso)
{
    //Console.WriteLine("Quantidade de linhas do arquivo: " + _);
    foreach (string linha in linhas_arquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}
*/
Objeto obj = new Objeto(1, "lazaro");

(int id, string nome) = obj;

Console.WriteLine(id + " " + nome);