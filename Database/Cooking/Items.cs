namespace MercatorisAdiutor.Database.Cooking.Items
{
    public abstract class CookingItem : Item
    {
        internal string name = string.Empty;
        internal int price = 0;

        public string Name => name;

        public Profession Profession => Profession.Cooking;

        public Category Category => Category.Crafting;

        public int Price 
        {
            get { return price; }
            set { price = value; }
        }
    }

    #region Ingredients
    public sealed class Oil : CookingItem
    {
        private static Oil? instance = null;
        private static readonly object locker = new object();

        Oil() 
        {
            name = "Oil";
        }

        public static Oil Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Oil();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion
}
