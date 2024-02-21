namespace MercatorisAdiutor.Model
{
    public interface Item
    {
        public int Id { get; }

        public string Name { get; }

        public string Icon { get; }

        public Profession Profession { get; }

        public Category Category { get; }
    }
}
