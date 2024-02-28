using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercatorisAdiutor.Model.Husbandry.Items
{
    public abstract class HusbandryItem : Item
    {
        internal int id = -1;
        internal string name = string.Empty;
        internal string icon = string.Empty;
        internal int price = 0;

        public int Id => id;

        public string Name => name;

        public string Icon => icon;

        public Profession Profession => Profession.Husbandry;

        public Category Category => Category.Gathering;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }

    #region SubProducts
    public sealed class Fertilizer : HusbandryItem
    {
        private static Fertilizer? instance = null;
        private static readonly object locker = new object();

        Fertilizer()
        {
            id = 34369;
            name = "Fertilizer";
            icon = "34369.png";
        }

        public static Fertilizer Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Fertilizer();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Products
    public sealed class Shank : HusbandryItem
    {
        private static Shank? instance = null;
        private static readonly object locker = new object();

        Shank()
        {
            id = 28932;
            name = "Shank";
            icon = "28932.png";
        }

        public static Shank Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Shank();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Hide : HusbandryItem
    {
        private static Hide? instance = null;
        private static readonly object locker = new object();

        Hide()
        {
            id = 35353;
            name = "Hide";
            icon = "35353.png";
        }

        public static Hide Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Hide();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SpoolOfHair : HusbandryItem
    {
        private static SpoolOfHair? instance = null;
        private static readonly object locker = new object();

        SpoolOfHair()
        {
            id = 34475;
            name = "Spool Of Hair";
            icon = "34475.png";
        }

        public static SpoolOfHair Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SpoolOfHair();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Chicken : HusbandryItem
    {
        private static Chicken? instance = null;
        private static readonly object locker = new object();

        Chicken()
        {
            id = 28750;
            name = "Chicken";
            icon = "28750.png";
        }

        public static Chicken Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Chicken();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Egg : HusbandryItem
    {
        private static Egg? instance = null;
        private static readonly object locker = new object();

        Egg()
        {
            id = 28928;
            name = "Egg";
            icon = "28928.png";
        }

        public static Egg Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Egg();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Milk : HusbandryItem
    {
        private static Milk? instance = null;
        private static readonly object locker = new object();

        Milk()
        {
            id = 28929;
            name = "Milk";
            icon = "28929.png";
        }

        public static Milk Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Milk();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Wool : HusbandryItem
    {
        private static Wool? instance = null;
        private static readonly object locker = new object();

        Wool()
        {
            id = 28425;
            name = "Wool";
            icon = "28425.png";
        }

        public static Wool Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Wool();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Feather : HusbandryItem
    {
        private static Feather? instance = null;
        private static readonly object locker = new object();

        Feather()
        {
            id = 35354;
            name = "Feather";
            icon = "35354.png";
        }

        public static Feather Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Feather();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Cheese : HusbandryItem
    {
        private static Cheese? instance = null;
        private static readonly object locker = new object();

        Cheese()
        {
            id = 28927;
            name = "Cheese";
            icon = "28927.png";
        }

        public static Cheese Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Cheese();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Honey : HusbandryItem
    {
        private static Honey? instance = null;
        private static readonly object locker = new object();

        Honey()
        {
            id = 44381;
            name = "Honey";
            icon = "44381.png";
        }

        public static Honey Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Honey();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Beef : HusbandryItem
    {
        private static Beef? instance = null;
        private static readonly object locker = new object();

        Beef()
        {
            id = 28931;
            name = "Beef";
            icon = "28931.png";
        }

        public static Beef Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Beef();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion
}
