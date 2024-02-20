namespace MercatorisAdiutor.Model
{
    public interface Item
    {
        public string Name { get; }

        public Profession Profession { get; }

        public Category Category { get; }
    }
}
