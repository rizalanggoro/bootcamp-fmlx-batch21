using Week04Stack;

var history = new MyStack();
history.AddValidationRule(word => !string.IsNullOrWhiteSpace(word));
history.AddValidationRule(word => word.Length <= 10);

Console.WriteLine(history.Type("hello"));
Console.WriteLine(history.Type(""));
Console.WriteLine(history.Undo());
