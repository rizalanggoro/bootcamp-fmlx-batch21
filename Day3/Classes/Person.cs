namespace Day3.Classes;

public partial class Person
{
    public string LastName { get; init; } = "";
    public string FullName => $"{FirstName} {LastName}";
}
