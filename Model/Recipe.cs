namespace MercatorisAdiutor.Model
{
    public interface CraftingRecipe
    {
        public string Name { get; }

        public int Tax { get; }

        public int Experience { get; }

        public Material[] Materials { get; }

        public Item CraftedItem { get; }
    }
}
