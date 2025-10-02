
using Serializacao.Model;
using Newtonsoft.Json;

Console.WriteLine("Serializandoo!");

Venda v1 = new Venda(1, "Pé de cabra", 97M);

//string slzed = JsonConvert.SerializeObject(v1);

//Para melhor visualização você pode usar: 
string slzed = JsonConvert.SerializeObject(v1, Formatting.Indented);


Console.WriteLine(slzed);
