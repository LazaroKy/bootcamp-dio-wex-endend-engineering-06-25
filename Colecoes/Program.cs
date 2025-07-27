Console.WriteLine("Collections!");

//Queue - FIFO
Queue<int> queue = new Queue<int>();

queue.Enqueue(2);
queue.Enqueue(5);
queue.Enqueue(7);
queue.Enqueue(4);

foreach (int item in queue)
{
    Console.WriteLine(item);
}

queue.Dequeue(); //remove first element
queue.Enqueue(21);

    Console.WriteLine("--------------");

foreach (int item in queue)
{
    Console.WriteLine(item);
}