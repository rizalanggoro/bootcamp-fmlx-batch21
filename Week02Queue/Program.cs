using Week02Queue;

var myQueue = new MyQueue();

Console.WriteLine(myQueue.Enqueue("A"));
Console.WriteLine(myQueue.Enqueue("B"));
Console.WriteLine(myQueue.EnqueueVip("C"));

Console.WriteLine(myQueue.Process());
Console.WriteLine(myQueue.Process());
Console.WriteLine(myQueue.Process());
Console.WriteLine(myQueue.Process());