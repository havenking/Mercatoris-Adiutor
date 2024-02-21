namespace MercatorisAdiutor.Model.Monster.Items
{
    public abstract class MonsterItem : Item
    {
        internal int id = -1;
        internal string name = string.Empty;
        internal string icon = string.Empty;
        internal int price = 0;

        public int Id => id;

        public string Name => name;

        public string Icon => icon;

        public Profession Profession => Profession.Weaving;

        public Category Category => Category.Crafting;

        public int Price 
        {
            get { return price; }
            set { price = value; }
        }
    }

    #region Trolls
    public sealed class TrollFang : MonsterItem
    {
        private static TrollFang? instance = null;
        private static readonly object locker = new object();

        TrollFang()
        {
            name = "Troll Fang";
        }

        public static TrollFang Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new TrollFang();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Pirates
    public sealed class SeaCuredLeather : MonsterItem
    {
        private static SeaCuredLeather? instance = null;
        private static readonly object locker = new object();

        SeaCuredLeather()
        {
            name = "Sea Cured Leather";
        }

        public static SeaCuredLeather Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SeaCuredLeather();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion
}
