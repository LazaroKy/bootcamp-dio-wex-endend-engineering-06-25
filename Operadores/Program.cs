
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

int produtosEmEstoque = 10;
int produtosComprados = 4;
bool possivelComprar = produtosComprados <= produtosEmEstoque;

if (possivelComprar)
{
    Console.WriteLine("Venda realizada!");
}
else
{
    Console.WriteLine("Desculpe, estoque insuficiente.");
}
