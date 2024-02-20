namespace MercatorisAdiutor.Model
{
    public struct Material
    {
        public Item Item { get; set; }

        public int Quantity { get; set; }

        public bool Compare(Production b)
        {
            return Item.Equals(b.Item);
        }

        public static Material operator +(Material a, Material b) => new() { Item = a.Item, Quantity = a.Quantity + b.Quantity };
    }
}
