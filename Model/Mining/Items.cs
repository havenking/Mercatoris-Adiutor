namespace MercatorisAdiutor.Model.Mining.Items
{
    public abstract class MiningItem : Item
    {
        internal int id = -1;
        internal string name = string.Empty;
        internal string icon = string.Empty;
        internal int price = 0;

        public int Id => id;

        public string Name => name;

        public string Icon => icon;

        public Profession Profession => Profession.Minning;

        public Category Category => Category.Gathering;

        public int Price 
        {
            get { return price; }
            set { price = value; }
        }
    }

    #region SubProducts
    public sealed class Stone : MiningItem
    {
        private static Stone? instance = null;
        private static readonly object locker = new object();

        Stone() 
        {
            name = "Stone";
        }

        public static Stone Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Stone();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Salt : MiningItem
    {
        private static Salt? instance = null;
        private static readonly object locker = new object();

        Salt()
        {
            name = "Salt";
        }

        public static Salt Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Salt();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Coal : MiningItem
    {
        private static Coal? instance = null;
        private static readonly object locker = new object();

        Coal()
        {
            name = "Coal";
        }

        public static Coal Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Coal();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Gems
    public sealed class Amethyst : MiningItem
    {
        private static Amethyst? instance = null;
        private static readonly object locker = new object();

        Amethyst()
        {
            name = "Amethyst";
        }

        public static Amethyst Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Amethyst();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Citrine : MiningItem
    {
        private static Citrine? instance = null;
        private static readonly object locker = new object();

        Citrine()
        {
            name = "Citrine";
        }

        public static Citrine Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Citrine();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Ruby : MiningItem
    {
        private static Ruby? instance = null;
        private static readonly object locker = new object();

        Ruby()
        {
            name = "Ruby";
        }

        public static Ruby Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Ruby();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Sapphire : MiningItem
    {
        private static Sapphire? instance = null;
        private static readonly object locker = new object();

        Sapphire()
        {
            name = "Sapphire";
        }

        public static Sapphire Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Sapphire();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Topaz : MiningItem
    {
        private static Topaz? instance = null;
        private static readonly object locker = new object();

        Topaz()
        {
            name = "Topaz";
        }

        public static Topaz Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Topaz();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Ores
    public sealed class CopperOre : MiningItem
    {
        private static CopperOre? instance = null;
        private static readonly object locker = new object();

        CopperOre()
        {
            name = "Copper Ore";
        }

        public static CopperOre Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CopperOre();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class IronOre : MiningItem
    {
        private static IronOre? instance = null;
        private static readonly object locker = new object();

        IronOre()
        {
            name = "Iron Ore";
        }

        public static IronOre Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new IronOre();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CobaltOre : MiningItem
    {
        private static CobaltOre? instance = null;
        private static readonly object locker = new object();

        CobaltOre()
        {
            name = "Cobalt Ore";
        }

        public static CobaltOre Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CobaltOre();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class TitaniumOre : MiningItem
    {
        private static TitaniumOre? instance = null;
        private static readonly object locker = new object();

        TitaniumOre()
        {
            name = "Titanium Ore";
        }

        public static TitaniumOre Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new TitaniumOre();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion
}
