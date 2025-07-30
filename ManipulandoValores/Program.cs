using System.Globalization; //Definir moeda fixa

decimal valorMonetario = 1282.40M;

Console.WriteLine($"{valorMonetario:C}");

//representa em texto o valor de um moeda
//Com interpolação de string colocar : na variável significa que quer formatar ela
//No caso do C ->Currency (Moeda), ele coloca o cifrão e a virgula
//Ele identifica a localização do sistema - region no sistema

//Alterar localização para um lugar especifico p todo sistema
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

//Alterar localização da cultura
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
//Pode usar NumberFormat

//Formatação personalizada
Console.WriteLine(valorMonetario.ToString("C3")); //N2, duas casas decimal
//Número de casas decimais

//Usar N ele não utiliza o "tipo" da moeda, ex: R$

//Porcetagem
double porcetagem = .3432;
Console.WriteLine(porcetagem.ToString("P"));

//formatar 
int numero = 41345;
Console.WriteLine(numero.ToString("##-##-##"));


//Formatar data - Cuidado com a hora do servidor
DateTime data = DateTime.Now;

Console.WriteLine(data);
//dd/MM/yyyy hh:mm:ss

Console.WriteLine(data.ToString("dd/mm/yyyy HH:mm")); //estarem maiusculo ou minusculo importa, hh minusculo representa a hora em 12h, sistema de am pm

//somente data/hora

Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());

string dataString = "10/08/2000 18:44";
//DateTime dataParseada = DateTime.Parse(dataString);
//Valide as datas  -- Use tryparse

//Data, formato, Cultura(localização), Estilo (loc tbm) e out data (se conseguir conversão)
DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm",
     CultureInfo.InvariantCulture, DateTimeStyles.None,
      out DateTime dataComTryParse);
//Se a data é inválida ele manda datas do ano 1..
//TryParseExact é do tipo bool, assim podemos fazar validação com if ou outra condição 

//Data formato por extenso 
DateTime dataExtenso = DateTime.Now;
Console.WriteLine(dataExtenso.ToString("D"));

long number = 8009999999;
string fmt = "000-000-0000";
Console.WriteLine(number.ToString(fmt));

List<string> nomes = new List<string>();
char letraFiltro = 'a';
//Comparar strings e Ignorar maiuscula/minusculas
List<string> nomesFiltrados = nomes.FindAll(
    nome => nome.StartsWith(letraFiltro.ToString(), StringComparison.OrdinalIgnoreCase));