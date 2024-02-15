using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercatorisAdiutor.Database.Husbandry.Items
{
    public abstract class HusbandryItem : Item
    {
        internal string name = string.Empty;
        internal int price = 0;

        public string Name => this.GetType().Name;

        public Profession Profession => Profession.WoodCutting;

        public Category Category => Category.Gathering;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }

    public sealed class Fertilizer : HusbandryItem
    {
        private static Fertilizer? instance = null;
        private static readonly object locker = new object();

        Fertilizer()
        {
            name = "Fertilizer";
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

    public sealed class Shank : HusbandryItem
    {
        private static Shank? instance = null;
        private static readonly object locker = new object();

        Shank()
        {
            name = "Shank";
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
            name = "Hide";
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
            name = "Spool Of Hair";
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
            name = "Chicken";
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
            name = "Egg";
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
            name = "Milk";
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
            name = "Wool";
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
            name = "Feather";
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
            name = "Cheese";
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
            name = "Honey";
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
            name = "Beef";
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
}
