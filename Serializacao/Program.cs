
using Serializacao.Model;
using Newtonsoft.Json;

Console.WriteLine("Serializandoo!");

Venda v1 = new Venda(1, "Pé de cabra", 97M);
//string slzed = JsonConvert.SerializeObject(v1);
//Para melhor visualização você pode usar: 
string slzed = JsonConvert.SerializeObject(v1, Formatting.Indented);
Console.WriteLine(slzed);

//Escrevendo um arquivo - Você informa uma pasta existente e o nome que deseja para o arquivo
File.WriteAllText("Files/venda1.json", slzed);

//Serializando coleções 
Venda v2 = new Venda(2, "Tijolo", 47M);

List<Venda> vendas = new List<Venda>();
vendas.Add(v1);
vendas.Add(v2);

string serializa = JsonConvert.SerializeObject(vendas, Formatting.Indented);

File.WriteAllText("Files/vendas.json", serializa);


