Console.WriteLine("Arrays and Lists");

// int[] arrayDeInteiros = new int[3];
// //Inicializar usando já os valores {1,2,3,4,5,..}

// arrayDeInteiros[0] = 72;
// arrayDeInteiros[1] = 32;
// arrayDeInteiros[2] = 30;

// //arrayDeInteiros[3] = 1;  Erro IndexOutOfRangeException
// // Console.WriteLine("Using for loop");
// // for (int contador = 0; contador < arrayDeInteiros.Length; contador++)
// // {
// //     Console.WriteLine($"Posição nº {contador} - {arrayDeInteiros[contador]}");
// // }

// // Console.WriteLine("Using foreach ");
// // foreach (int valor in arrayDeInteiros)
// // {
// //     Console.WriteLine(valor);
// // }

// //Cria um cópia do seu array e "surge" com um array com a capacidade que você passar no seu antigo array
// Array.Resize(ref arrayDeInteiros, arrayDeInteiros.Length * 2);

// Console.WriteLine(arrayDeInteiros.Length);

// int[] arrayDeInteirosDobrado = new int[arrayDeInteiros.Length * 2];
// //Copiar elementos do um array e cria um novo array com o elementos do array copiado em suas posições.
// arrayDeInteiros.Copy(arrayDeInteiros, arrayDeInteirosDobrados, arrayDeInteiros.Length);

//Lists -- capacidade não determinada, diferente do array
List<string> listaStrings = new List<string>();

listaStrings.Add("Alga");
listaStrings.Add("Pedra");
listaStrings.Add("Peixe");

for (int contador = 0; contador < listaStrings.Count; contador++)
{
    Console.WriteLine($"Posição nº {contador} - {listaStrings[contador]}");
}

Console.WriteLine(listaStrings.Capacity);
