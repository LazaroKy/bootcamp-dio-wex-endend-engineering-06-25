
// int a = 10;
// int b = 20;
// int c = a + b;

// Console.WriteLine(c);

// c += 5; // c = c + 5;
// Console.WriteLine(c);
// c -= 10; //c = c -10;
// Console.WriteLine(c);
// c /= 5;//c = c /5;
// Console.WriteLine(c);
// c *= 4; //c = c *4;
// Console.WriteLine(c);

// int convertToInt = Convert.ToInt32("99"); // null -> 0
// Console.WriteLine(convertToInt);
// int parseToInt = int.Parse("5"); // null -> exception 
// Console.WriteLine(parseToInt);

//Implicit and Explicit Convertion
//Explicit
// double toInt = 9.0;
// int fromDouble = (int)toInt;
// Console.WriteLine(fromDouble);

//implicit
// int inteiro = 9;
// long longFromInt = inteiro;

//  Console.WriteLine(longFromInt);

// int inteiro = 10;
// string text = inteiro.ToString();

// Console.WriteLine(text);

// string message = "alo";

// //int value = 0; Define no tryParse

// int.TryParse(message, out int value);

// Console.WriteLine(value);
// Console.WriteLine("Conversão realizada!");

//Operadores condicionais

// int produtosEmEstoque = 10;
// int produtosComprados = 4;
// bool possivelComprar = produtosComprados <= produtosEmEstoque;

// if (possivelComprar)
// {
//     Console.WriteLine("Venda realizada!");
// }
// else
// {
//     Console.WriteLine("Desculpe, estoque insuficiente.");
// }

//Switch case
// Console.WriteLine("Digite uma letra:");
// string inputLetra = Console.ReadLine();

// switch (inputLetra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("VogaAAL!");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal :( \n");
//         break;
// }

//Operadores lógicos

// bool ehMaiorDeIdade = true;
//bool possuiAutorizacaoDoResponsavel = false;

//OR OPERATOR
// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada");
// }
// else
// {
//     Console.WriteLine("Entrada não Liberada");
// }

// bool ehMenorDeIdade = true;
// bool naoPossuiAutorizacaoDoResponsavel = true;
// //AND OPERATOR
// if (ehMenorDeIdade && naoPossuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada não liberada");
// }
// else
// {
//     Console.WriteLine("Entrada Liberada");
// }

//NOT OPERATOR
// bool choveu = false;
// bool estaTarde = false;
// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar amanhã");
// }

using Operadores.model;

Calculadora calcular = new Calculadora();

calcular.Somar(2, 3);
calcular.subtrair(4, 2);
calcular.Multiplicar(2, 3);
calcular.Dividir(3,2);
calcular.IncrementarUm(2);
calcular.DecrementarUm(2);
calcular.RestoDaDivisão(5, 4);

calcular.Seno(30);
calcular.Coseno(45);
calcular.Tangente(60);

calcular.RaizQuadrada(9);