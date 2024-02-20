using MercatorisAdiutor.Model.Farming.Items;

namespace MercatorisAdiutor.Model.WoodCutting.Items
{
    public abstract class WoodCuttingItem : Item
    {
        internal string name = string.Empty;
        internal int price = 0;

        public string Name => name;

        public Profession Profession => Profession.WoodCutting;

        public Category Category => Category.Gathering;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }

    #region SubProducts
    public sealed class DenseLog : WoodCuttingItem
    {
        private static DenseLog? instance = null;
        private static readonly object locker = new object();

        DenseLog()
        {
            name = "Dense Log";
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
    #endregion

    #region Products
    public sealed class SmallLog : WoodCuttingItem
    {
        private static SmallLog? instance = null;
        private static readonly object locker = new object();

        SmallLog()
        {
            name = "Small Log";
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
            name = "Heavy Log";
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
            name = "Sturdy Log";
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
            name = "Fine Log";
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
    #endregion
}
