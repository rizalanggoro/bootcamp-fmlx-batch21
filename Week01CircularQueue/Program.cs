// See https://aka.ms/new-console-template for more information

using Week01CircularQueue;

{
    Console.WriteLine("---------- Circular Queue ----------");
    var myCircularQueue = new MyCircularQueue();

    myCircularQueue.Log(1);
    myCircularQueue.Log(2);
    myCircularQueue.Log(3);
    myCircularQueue.Print();

    myCircularQueue.Log(4);
    myCircularQueue.Print();

    myCircularQueue.Read();
    myCircularQueue.Print();

    myCircularQueue.Log(5);
    myCircularQueue.Print();

    myCircularQueue.Read();
    myCircularQueue.Print();
}

{
    Console.WriteLine("---------- Circular Queue List ----------");
    var myCircularQueue = new MyCircularQueueList();

    myCircularQueue.Log(1);
    myCircularQueue.Log(2);
    myCircularQueue.Log(3);
    myCircularQueue.Print();

    myCircularQueue.Log(4);
    myCircularQueue.Print();

    myCircularQueue.Read();
    myCircularQueue.Print();

    myCircularQueue.Log(5);
    myCircularQueue.Print();

    myCircularQueue.Read();
    myCircularQueue.Print();
}