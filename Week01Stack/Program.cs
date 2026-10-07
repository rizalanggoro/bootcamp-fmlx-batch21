using Week01Stack.Lib;

{
    Console.WriteLine("---------- Fixed Stack ----------");
    var typingHistory = new FixedTypingHistory();
    typingHistory.Type("foo");
    typingHistory.Type("bar");
    typingHistory.Undo();
    typingHistory.Undo();
    typingHistory.Undo();
}

{
    Console.WriteLine("\n---------- Collection Stack ----------");
    var typingHistory = new CollectionTypingHistory();
    typingHistory.Type("foo");
    typingHistory.Type("bar");
    typingHistory.Undo();
    typingHistory.Undo();
    typingHistory.Undo();
}