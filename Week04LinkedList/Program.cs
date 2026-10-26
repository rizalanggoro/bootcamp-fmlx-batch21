using Week04LinkedList;

var myList = new MyLinkedList();
myList.Append(5);
myList.Append(2);
myList.Append(8);

myList.SetSorting((a, b) => a.CompareTo(b));
myList.AddFilter(value => value % 2 == 0);

Console.WriteLine(myList.Print());
