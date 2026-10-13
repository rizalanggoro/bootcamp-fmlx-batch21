using Week03Queue;

var myQueue = new MyQueue();

Console.WriteLine(myQueue.Enqueue("A", 1));
Console.WriteLine(myQueue.Enqueue("B", 5));
Console.WriteLine(myQueue.Enqueue("C", 5));
Console.WriteLine(myQueue.Process());
Console.WriteLine(myQueue.Process());
