namespace MercatorisAdiutor.Database.Blacksmithing.Items
{
    public abstract class BlacksmithingItem : Item
    {
        internal string name = string.Empty;
        internal int price = 0;

        public string Name => name;

        public Profession Profession => Profession.Weaving;

        public Category Category => Category.Crafting;

        public int Price 
        {
            get { return price; }
            set { price = value; }
        }
    }

    #region Ingots
    public sealed class CopperIngot : BlacksmithingItem
    {
        private static CopperIngot? instance = null;
        private static readonly object locker = new object();

        CopperIngot()
        {
            name = "Copper Ingot";
        }

        public static CopperIngot Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CopperIngot();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class IronIngot : BlacksmithingItem
    {
        private static IronIngot? instance = null;
        private static readonly object locker = new object();

        IronIngot()
        {
            name = "Iron Ingot";
        }

        public static IronIngot Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new IronIngot();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SteelIngot : BlacksmithingItem
    {
        private static SteelIngot? instance = null;
        private static readonly object locker = new object();

        SteelIngot()
        {
            name = "Steel Ingot";
        }

        public static SteelIngot Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SteelIngot();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CobaltIngot : BlacksmithingItem
    {
        private static CobaltIngot? instance = null;
        private static readonly object locker = new object();

        CobaltIngot()
        {
            name = "Cobalt Ingot";
        }

        public static CobaltIngot Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CobaltIngot();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class TitaniumIngot : BlacksmithingItem
    {
        private static TitaniumIngot? instance = null;
        private static readonly object locker = new object();

        TitaniumIngot()
        {
            name = "Titanium Ingot";
        }

        public static TitaniumIngot Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new TitaniumIngot();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Weapons
    #endregion

    #region Armors
    #endregion

    #region Whetstones
    #endregion

    #region Fishing
    #endregion

    #region Housing Craft
    #endregion

    #region Misc
    #endregion

    #region Moa Equipment
    #endregion

    #region Ship Module
    #endregion
}
