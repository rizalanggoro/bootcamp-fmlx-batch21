using Week04Queue;

var myQueue = new MyQueue();
myQueue.AddRule("urgent", 10);
myQueue.AddRule("normal", 5);

Console.WriteLine(myQueue.Enqueue("normal"));
Console.WriteLine(myQueue.Enqueue("urgent"));
Console.WriteLine(myQueue.Process());
