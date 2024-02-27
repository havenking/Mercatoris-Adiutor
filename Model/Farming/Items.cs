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
            id = 0;
            name = "Three-Leaf Clover";
            icon = "generic.png";
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
            id = 0;
            name = "Potato";
            icon = "generic.png";
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
            name = "Potato";
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
            id = 0;
            name = "Corn";
            icon = "generic.png";
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
            id = 0;
            name = "Wheat";
            icon = "generic.png";
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
            id = 0;
            name = "Apple";
            icon = "generic.png";
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
            id = 0;
            name = "Carrot";
            icon = "generic.png";
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
            id = 0;
            name = "Grape";
            icon = "generic.png";
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
            id = 0;
            name = "Blueberry";
            icon = "generic.png";
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
            id = 0;
            name = "Cabbage";
            icon = "generic.png";
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
            id = 0;
            name = "Pepper";
            icon = "generic.png";
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
            id = 0;
            name = "Cherry";
            icon = "generic.png";
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
            id = 0;
            name = "Orange";
            icon = "generic.png";
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
            id = 0;
            name = "Onion";
            icon = "generic.png";
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
            id = 0;
            name = "Strawberry";
            icon = "generic.png";
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
            id = 0;
            name = "Bean";
            icon = "generic.png";
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
            id = 0;
            name = "Banana";
            icon = "generic.png";
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
            id = 0;
            name = "Pumpkin";
            icon = "generic.png";
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
            id = 0;
            name = "Watermelon";
            icon = "generic.png";
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
            id = 0;
            name = "Pea";
            icon = "generic.png";
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
            id = 0;
            name = "Moonberry";
            icon = "generic.png";
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
            id = 0;
            name = "Garlic";
            icon = "generic.png";
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
            id = 0;
            name = "Acorn";
            icon = "generic.png";
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
            id = 0;
            name = "Brocolli";
            icon = "generic.png";
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
            id = 0;
            name = "Sunberry";
            icon = "generic.png";
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
