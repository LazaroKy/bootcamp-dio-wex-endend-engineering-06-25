Console.WriteLine("Arrays and Lists");

int[] arrayDeInteiros = new int[3];
//Inicializar usando já os valores {1,2,3,4,5,..}

arrayDeInteiros[0] = 72;
arrayDeInteiros[1] = 32;
arrayDeInteiros[2] = 30;

//arrayDeInteiros[3] = 1;  Erro IndexOutOfRangeException
// Console.WriteLine("Using for loop");
// for (int contador = 0; contador < arrayDeInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição nº {contador} - {arrayDeInteiros[contador]}");
// }

Console.WriteLine("Using foreach ");
foreach (int valor in arrayDeInteiros)
{
    Console.WriteLine(valor);
}