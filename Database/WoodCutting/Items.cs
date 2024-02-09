using MercatorisAdiutor.Database.Farming.Items;

namespace MercatorisAdiutor.Database.WoodCutting.Items
{
    public class WoodCuttingItem : Item
    {
        public string Name => this.GetType().Name;

        public Profession Profession => Profession.WoodCutting;

        public Category Category => Category.Gathering;

        public int Price { get; set; }
    }

    public sealed class SmallLog : WoodCuttingItem
    {
        private static SmallLog? instance = null;
        private static readonly object locker = new object();

        SmallLog() { }

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

    public sealed class DenseLog : WoodCuttingItem
    {
        private static DenseLog? instance = null;
        private static readonly object locker = new object();

        DenseLog() { }

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

    public sealed class HeavyLog : WoodCuttingItem
    {
        private static HeavyLog? instance = null;
        private static readonly object locker = new object();

        HeavyLog() { }

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

        SturdyLog() { }

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

        FineLog() { }

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
