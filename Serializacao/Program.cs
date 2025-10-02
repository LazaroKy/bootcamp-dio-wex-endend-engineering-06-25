
using Serializacao.Model;
using Newtonsoft.Json;

Console.WriteLine("Serializandoo!");

Venda v1 = new Venda(1, "Pé de cabra", 97M, DateTime.Now);
//string slzed = JsonConvert.SerializeObject(v1);
//Para melhor visualização você pode usar: 
string slzed = JsonConvert.SerializeObject(v1, Formatting.Indented);
Console.WriteLine(slzed);

//Escrevendo um arquivo - Você informa uma pasta existente e o nome que deseja para o arquivo
File.WriteAllText("Files/venda1.json", slzed);

//Serializando coleções 
Venda v2 = new Venda(2, "Tijolo", 47M, DateTime.Now);

List<Venda> vendas = new List<Venda>();
vendas.Add(v1);
vendas.Add(v2);

string serializa = JsonConvert.SerializeObject(vendas, Formatting.Indented);

File.WriteAllText("Files/vendas.json", serializa);

//As datas são salvas de acordo com a ISO 8601 
//JSON não segue um formato de data integrado, usam o formato de string de acordo com a ISO
//onde combina data e hora em um formato padrão, como AAAA-MM-DDTHH:MM:SSZ

//Deserializando objetos - vc tem o arquivo e quer criar o objeto

string objeto_deserializado = File.ReadAllText("Files/venda3.json");
//Você deve observar a estrutura do seu json e abstrair no seu objeto
Venda v3 = JsonConvert.DeserializeObject<Venda>(objeto_deserializado);
//É preciso adiconar (sobreescrever na vdd) o ToString da sua classe para que ele imprima de fato o objeto deserializado, e não o namespace e a classe do tipo

Console.WriteLine(v3);