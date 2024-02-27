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
            id = 0;
            name = "Fertilizer";
            icon = "generic.png";
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
            id = 0;
            name = "Shank";
            icon = "generic.png";
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
            id = 0;
            name = "Hide";
            icon = "generic.png";
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
            id = 0;
            name = "Spool Of Hair";
            icon = "generic.png";
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
            id = 0;
            name = "Chicken";
            icon = "generic.png";
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
            id = 0;
            name = "Egg";
            icon = "generic.png";
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
            id = 0;
            name = "Milk";
            icon = "generic.png";
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
            id = 0;
            name = "Wool";
            icon = "generic.png";
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
            id = 0;
            name = "Feather";
            icon = "generic.png";
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
            id = 0;
            name = "Cheese";
            icon = "generic.png";
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
            id = 0;
            name = "Honey";
            icon = "generic.png";
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
            id = 0;
            name = "Beef";
            icon = "generic.png";
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
