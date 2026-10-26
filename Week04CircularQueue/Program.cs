using Week04CircularQueue;

var myCircularQueue = new MyCircularQueue();
myCircularQueue.SetCapacity(2);
myCircularQueue.SetOverwritePolicy(false);

Console.WriteLine(myCircularQueue.Log(1));
Console.WriteLine(myCircularQueue.Log(2));
Console.WriteLine(myCircularQueue.Log(3));
Console.WriteLine(myCircularQueue.Read());
