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

        public int Experience { get; }

        public int Labor { get; }

        public int Time { get; }

        public int Cost { get; }

        public Production[] Production { get; }
    }

    public struct Production
    {
        public Item Item { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }
    }
}
