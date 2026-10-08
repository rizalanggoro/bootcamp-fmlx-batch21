namespace Day6.Lib.OperatorOverloading;

internal class OperatorOverloading
{
    internal void Invoke()
    {
        Util.WriteHeader("Operator Overloading");

        User user1 = new()
        {
            Id = 1,
            Name = "Rizal"
        };
        var user2 = new User
        {
            Id = 1,
            Name = "Rizal"
        };

        Console.WriteLine($"is same? {user1 == user2}");

        Console.WriteLine();
        var a = 10;
        var newUser = (User)a;
        Console.WriteLine(newUser.ToString());
    }

    private class User
    {
        internal int Id { get; init; }
        internal string Name { get; init; }

        public static bool operator ==(User user1, User user2)
        {
            return user1.Id == user2.Id;
        }

        public static bool operator !=(User user1, User user2)
        {
            return user1.Id != user2.Id;
        }

        public static int operator +(User user1, User user2)
        {
            return user1.Id + user2.Id;
        }

        public static string operator -(User user1, User user2)
        {
            return (user1.Id - user2.Id).ToString();
        }

        public static implicit operator int(User user)
        {
            return user.Id;
        }

        public static explicit operator User(int userId)
        {
            return new User { Id = userId, Name = "No Name" };
        }

        public static User operator ++(User user1)
        {
            return new User
            {
                Id = user1.Id + 1,
                Name = user1.Name
            };
        }

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}