using MercatorisAdiutor.Model.Farming.Items;

namespace MercatorisAdiutor.Model.WoodCutting.Items
{
    public abstract class WoodCuttingItem : Item
    {
        internal int id = -1;
        internal string name = string.Empty;
        internal string icon = string.Empty;
        internal int price = 0;

        public int Id => id;

        public string Name => name;

        public string Icon => icon;

        public Profession Profession => Profession.WoodCutting;

        public Category Category => Category.Gathering;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }

    public sealed class DenseLog : WoodCuttingItem
    {
        private static DenseLog? instance = null;
        private static readonly object locker = new object();

        DenseLog()
        {
            id = 34371;
            name = "Dense Log";
            icon = "34371_DenseLog.png";
        }

        public static DenseLog Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new DenseLog();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SmallLog : WoodCuttingItem
    {
        private static SmallLog? instance = null;
        private static readonly object locker = new object();

        SmallLog()
        {
            id = 28977;
            name = "Small Log";
            icon = "28977_SmallLog.png";
        }

        public static SmallLog Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallLog();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class HeavyLog : WoodCuttingItem
    {
        private static HeavyLog? instance = null;
        private static readonly object locker = new object();

        HeavyLog()
        {
            id = 45504;
            name = "Heavy Log";
            icon = "generic.png";
        }

        public static HeavyLog Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new HeavyLog();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SturdyLog : WoodCuttingItem
    {
        private static SturdyLog? instance = null;
        private static readonly object locker = new object();

        SturdyLog()
        {
            id = 45505;
            name = "Sturdy Log";
            icon = "generic.png";
        }

        public static SturdyLog Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SturdyLog();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class FineLog : WoodCuttingItem
    {
        private static FineLog? instance = null;
        private static readonly object locker = new object();

        FineLog()
        {
            id = 45502;
            name = "Fine Log";
            icon = "generic.png";
        }

        public static FineLog Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FineLog();
                    }

                    return instance;
                }
            }
        }
    }
}
