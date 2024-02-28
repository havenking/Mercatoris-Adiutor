namespace MercatorisAdiutor.Model.Farming.Items
{
    public abstract class FarmingItem : Item
    {
        internal int id = -1;
        internal string name = string.Empty;
        internal string icon = string.Empty;
        internal int price = 0;

        public int Id => id;

        public string Name => name;

        public string Icon => icon;

        public Profession Profession => Profession.Farming;

        public Category Category => Category.Gathering;

        public int Price 
        {
            get { return price; }
            set { price = value; }
        }
    }

    #region SubProducts
    public sealed class ThreeLeafClover : FarmingItem
    {
        private static ThreeLeafClover? instance = null;
        private static readonly object locker = new object();

        ThreeLeafClover()
        {
            id = 34370;
            name = "Three-Leaf Clover";
            icon = "34370.png";
        }

        public static ThreeLeafClover Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ThreeLeafClover();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Products
    public sealed class Potato : FarmingItem
    {
        private static Potato? instance = null;
        private static readonly object locker = new object();

        Potato()
        {
            id = 28874;
            name = "Potato";
            icon = "28874.png";
        }

        public static Potato Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Potato();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Cotton : FarmingItem
    {
        private static Cotton? instance = null;
        private static readonly object locker = new object();

        Cotton() 
        {
            id = 28879;
            name = "Cotton";
            icon = "28879.png";
        }

        public static Cotton Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Cotton();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Corn : FarmingItem
    {
        private static Corn? instance = null;
        private static readonly object locker = new object();

        Corn()
        {
            id = 28866;
            name = "Corn";
            icon = "28866.png";
        }

        public static Corn Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Corn();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Wheat : FarmingItem
    {
        private static Wheat? instance = null;
        private static readonly object locker = new object();

        Wheat()
        {
            id = 28881;
            name = "Wheat";
            icon = "28881.png";
        }

        public static Wheat Instance
        {
            get
       {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Wheat();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Apple : FarmingItem
    {
        private static Apple? instance = null;
        private static readonly object locker = new object();

        Apple()
        {
            id = 28822;
            name = "Apple";
            icon = "28822.png";
        }

        public static Apple Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Apple();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Carrot : FarmingItem
    {
        private static Carrot? instance = null;
        private static readonly object locker = new object();

        Carrot()
        {
            id = 28865;
            name = "Carrot";
            icon = "28865.png";
        }

        public static Carrot Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Carrot();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Grape : FarmingItem
    {
        private static Grape? instance = null;
        private static readonly object locker = new object();

        Grape()
        {
            id = 28831;
            name = "Grape";
            icon = "28831.png";
        }

        public static Grape Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Grape();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Blueberry : FarmingItem
    {
        private static Blueberry? instance = null;
        private static readonly object locker = new object();

        Blueberry()
        {
            id = 28825;
            name = "Blueberry";
            icon = "28825.png";
        }

        public static Blueberry Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Blueberry();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Cabbage : FarmingItem
    {
        private static Cabbage? instance = null;
        private static readonly object locker = new object();

        Cabbage()
        {
            id = 28864;
            name = "Cabbage";
            icon = "28864.png";
        }

        public static Cabbage Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Cabbage();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Pepper : FarmingItem
    {
        private static Pepper? instance = null;
        private static readonly object locker = new object();

        Pepper()
        {
            id = 28872;
            name = "Pepper";
            icon = "28872.png";
        }

        public static Pepper Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Pepper();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Cherry : FarmingItem
    {
        private static Cherry? instance = null;
        private static readonly object locker = new object();

        Cherry()
        {
            id = 28830;
            name = "Cherry";
            icon = "28830.png";
        }

        public static Cherry Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Cherry();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Orange : FarmingItem
    {
        private static Orange? instance = null;
        private static readonly object locker = new object();

        Orange()
        {
            id = 28832;
            name = "Orange";
            icon = "28832.png";
        }

        public static Orange Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Orange();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Onion : FarmingItem
    {
        private static Onion? instance = null;
        private static readonly object locker = new object();

        Onion()
        {
            id = 28870;
            name = "Onion";
            icon = "28870.png";
        }

        public static Onion Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Onion();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Strawberry : FarmingItem
    {
        private static Strawberry? instance = null;
        private static readonly object locker = new object();

        Strawberry()
        {
            id = 28827;
            name = "Strawberry";
            icon = "28827.png";
        }

        public static Strawberry Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Strawberry();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Bean : FarmingItem
    {
        private static Bean? instance = null;
        private static readonly object locker = new object();

        Bean()
        {
            id = 28878;
            name = "Bean";
            icon = "28878.png";
        }

        public static Bean Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Bean();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Banana : FarmingItem
    {
        private static Banana? instance = null;
        private static readonly object locker = new object();

        Banana()
        {
            id = 28823;
            name = "Banana";
            icon = "28823.png";
        }

        public static Banana Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Banana();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Pumpkin : FarmingItem
    {
        private static Pumpkin? instance = null;
        private static readonly object locker = new object();

        Pumpkin()
        {
            id = 28875;
            name = "Pumpkin";
            icon = "28875.png";
        }

        public static Pumpkin Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Pumpkin();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Watermelon : FarmingItem
    {
        private static Watermelon? instance = null;
        private static readonly object locker = new object();

        Watermelon()
        {
            id = 28828;
            name = "Watermelon";
            icon = "28828.png";
        }

        public static Watermelon Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Watermelon();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Pea : FarmingItem
    {
        private static Pea? instance = null;
        private static readonly object locker = new object();

        Pea()
        {
            id = 28871;
            name = "Pea";
            icon = "28871.png";
        }

        public static Pea Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Pea();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Moonberry : FarmingItem
    {
        private static Moonberry? instance = null;
        private static readonly object locker = new object();

        Moonberry()
        {
            id = 28826;
            name = "Moonberry";
            icon = "28826.png";
        }

        public static Moonberry Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Moonberry();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Garlic : FarmingItem
    {
        private static Garlic? instance = null;
        private static readonly object locker = new object();

        Garlic()
        {
            id = 28869;
            name = "Garlic";
            icon = "28869.png";
        }

        public static Garlic Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Garlic();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Acorn : FarmingItem
    {
        private static Acorn? instance = null;
        private static readonly object locker = new object();

        Acorn()
        {
            id = 28829;
            name = "Acorn";
            icon = "28829.png";
        }

        public static Acorn Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Acorn();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Brocolli : FarmingItem
    {
        private static Brocolli? instance = null;
        private static readonly object locker = new object();

        Brocolli()
        {
            id = 28863;
            name = "Brocolli";
            icon = "28863.png";
        }

        public static Brocolli Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Brocolli();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Sunberry : FarmingItem
    {
        private static Sunberry? instance = null;
        private static readonly object locker = new object();

        Sunberry()
        {
            id = 28824;
            name = "Sunberry";
            icon = "28824.png";
        }

        public static Sunberry Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Sunberry();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion
}
