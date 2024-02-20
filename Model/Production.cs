namespace MercatorisAdiutor.Model
{
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
}
