// See https://aka.ms/new-console-template for more information

using Week01LinkedList;

var myLinkedList = new MyLinkedList();

// empty state
myLinkedList.Print();

var rand = new Random();
for (var i = 0; i < 5; i++)
{
    var num = rand.Next(1, 11);
    myLinkedList.Append(num);
}

myLinkedList.Print();