Console.WriteLine("Tupla");

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

