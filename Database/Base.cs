namespace MercatorisAdiutor.Database
{
    public interface Item
    {
        public string Name { get; }

        public Profession Profession { get; }

        public Category Category { get; }
    }

    public interface GatheringObject
    {
        public string Name { get; }

        public int Labor { get; }

        public int Cost { get; }

        public int TotalExperience { get; }

        public int TotalTime { get; }

        public Production[] TotalProduction { get; }
    }

    public struct Production
    {
        public Item Item { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }

        public bool Compare(Production b)
        {
            return Item.Equals(b.Item);
        }

        public static Production operator +(Production a, Production b) => new() { Item = a.Item, Min = a.Min + b.Min, Max = a.Max + b.Max };
        public static Production operator *(Production a, int b) => new() {Item = a.Item, Min = a.Min * b, Max = a.Max * b};
    }

    public struct Material
    {
        public Item Item { get; set; }

        public int Quantity { get; set; }

        public bool Compare(Production b)
        {
            return Item.Equals(b.Item);
        }

        public static Material operator +(Material a, Material b) => new() { Item = a.Item, Quantity = a.Quantity + b.Quantity};
    }
}
