namespace Day6.Lib.Delegate;

internal class Delegate
{
    private readonly User[] _users =
    [
        new("Rizal", Role.Guest),
        new("Dwi", Role.Member),
        new("Anggoro", Role.Vip)
    ];

    internal void Invoke()
    {
        Util.WriteHeader("Delegate");

        var storeRepo = new StoreRepo();
        foreach (var user in _users)
        {
            var randPrice = new Random().Next(1, 10) * 100_000m;
            var discountPrice = storeRepo.GetDiscount(
                randPrice,
                user.Role
            );

            Console.WriteLine(
                $"""
                 - {user.Name} [{user.Role}]
                   normal price  : {randPrice}
                   discount price: {(int)discountPrice}
                 """
            );
        }
    }

    private enum Role
    {
        Guest,
        Member,
        Vip
    }

    private class User(string name, Role role)
    {
        internal readonly string Name = name;
        internal readonly Role Role = role;
    }

    private class StoreRepo
    {
        private decimal CustomerDiscountPrice(decimal normalPrice)
        {
            return normalPrice;
        }

        private decimal MemberDiscountPrice(decimal normalPrice)
        {
            return 0.9m * normalPrice;
        }

        private decimal StudentDiscountPrice(decimal normalPrice)
        {
            return 0.8m * normalPrice;
        }

        internal decimal GetDiscount(decimal price, Role role)
        {
            var transformers1 = new DiscountTransformer[]
            {
                CustomerDiscountPrice,
                MemberDiscountPrice,
                StudentDiscountPrice
            };

            var transformers2 = new[]
            {
                CustomerDiscountPrice,
                MemberDiscountPrice,
                StudentDiscountPrice
            };

            if (new Random().Next() % 2 == 0)
                return transformers1[(int)role](price);

            return transformers2[(int)role](price);
        }

        private void Test()
        {
            DiscountTransformer d1 = CustomerDiscountPrice;
            var d2 = new DiscountTransformer2(d1);
        }

        private delegate decimal DiscountTransformer(decimal price);

        private delegate decimal DiscountTransformer2(decimal price);
    }
}