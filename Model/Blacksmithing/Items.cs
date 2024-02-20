namespace MercatorisAdiutor.Model.Blacksmithing.Items
{
    public abstract class BlacksmithingItem : Item
    {
        internal string name = string.Empty;
        internal int price = 0;

        public string Name => name;

        public Profession Profession => Profession.Blacksmithing;

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
    public sealed class Nail : BlacksmithingItem
    {
        private static Nail? instance = null;
        private static readonly object locker = new object();

        Nail()
        {
            name = "Nail";
        }

        public static Nail Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Nail();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CommonPlate : BlacksmithingItem
    {
        private static CommonPlate? instance = null;
        private static readonly object locker = new object();

        CommonPlate()
        {
            name = "Common Plate";
        }

        public static CommonPlate Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CommonPlate();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ReinforcedPlate : BlacksmithingItem
    {
        private static ReinforcedPlate? instance = null;
        private static readonly object locker = new object();

        ReinforcedPlate()
        {
            name = "Reinforced Plate";
        }

        public static ReinforcedPlate Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ReinforcedPlate();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class IronBar : BlacksmithingItem
    {
        private static IronBar? instance = null;
        private static readonly object locker = new object();

        IronBar()
        {
            name = "Iron Bar";
        }

        public static IronBar Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new IronBar();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Bolt : BlacksmithingItem
    {
        private static Bolt? instance = null;
        private static readonly object locker = new object();

        Bolt()
        {
            name = "Bolt";
        }

        public static Bolt Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Bolt();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SteelBar : BlacksmithingItem
    {
        private static SteelBar? instance = null;
        private static readonly object locker = new object();

        SteelBar()
        {
            name = "Steel Bar";
        }

        public static SteelBar Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SteelBar();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Moa Equipment
    #endregion

    #region Ship Module
    #endregion
}
