
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

//Implicity and Explicity Convertion

int convertToInt = Convert.ToInt32("99"); // null -> 0
Console.WriteLine(convertToInt);
int parseToInt = int.Parse("5"); // null -> exception 
Console.WriteLine(parseToInt);

double toInt = 9.0;
int fromDouble = (int)toInt;
Console.WriteLine(fromDouble);
