Console.WriteLine("Collections!");

//Queue - FIFO
// Queue<int> queue = new Queue<int>();

// queue.Enqueue(2);
// queue.Enqueue(5);
// queue.Enqueue(7);
// queue.Enqueue(4);

// foreach (int item in queue)
// {
//     Console.WriteLine(item);
// }

// queue.Dequeue(); //remove first element
// queue.Enqueue(21);

//     Console.WriteLine("--------------");

// foreach (int item in queue)
// {
//     Console.WriteLine(item);
// }

//Stack - LIFO
// Stack<int> stack = new Stack<int>();
// stack.Push(1);
// stack.Push(2);
// stack.Push(3);
// stack.Push(4);
//  foreach (int item in stack)
//  {
//      Console.WriteLine(item);
//  }

// Console.WriteLine("-------");
// stack.Pop();
// stack.Push(5);
// Console.WriteLine("-------");
//  foreach (int item in stack)
//  {
//      Console.WriteLine(item);
//  }

Dictionary<string,int> dictionary = new Dictionary<string,int>();

dictionary.Add("Cimento", 12);
dictionary.Add("Brita", 14);
dictionary.Add("Ferro", 9);

foreach (var item in dictionary)
{
    Console.WriteLine(item);
}
Console.WriteLine("--------");

dictionary["Brita"] = 20;
foreach (var item in dictionary)
{
    Console.WriteLine(item);
}

bool temBrita =dictionary.ContainsKey("Brita");
