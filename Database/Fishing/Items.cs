namespace MercatorisAdiutor.Database.Fishing.Items
{
    public abstract class FishingItem : Item
    {
        internal string name = string.Empty;
        internal int price = 0;

        public string Name => name;

        public Profession Profession => Profession.Cooking;

        public Category Category => Category.Crafting;

        public int Price 
        {
            get { return price; }
            set { price = value; }
        }
    }

    #region Slices
    public sealed class OrangeScales : FishingItem
    {
        private static OrangeScales? instance = null;
        private static readonly object locker = new object();

        OrangeScales()
        {
            name = "Orange Scales";
        }

        public static OrangeScales Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new OrangeScales();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class FishRoe : FishingItem
    {
        private static FishRoe? instance = null;
        private static readonly object locker = new object();

        FishRoe()
        {
            name = "Fish Roe";
        }

        public static FishRoe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FishRoe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class FishSkin : FishingItem
    {
        private static FishSkin? instance = null;
        private static readonly object locker = new object();

        FishSkin()
        {
            name = "Fish Skin";
        }

        public static FishSkin Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FishSkin();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class YellowFishRoe : FishingItem
    {
        private static YellowFishRoe? instance = null;
        private static readonly object locker = new object();

        YellowFishRoe()
        {
            name = "Yellow Fish Roe";
        }

        public static YellowFishRoe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new YellowFishRoe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class FishEye : FishingItem
    {
        private static FishEye? instance = null;
        private static readonly object locker = new object();

        FishEye()
        {
            name = "Fish Eye";
        }

        public static FishEye Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FishEye();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class RedFishRoe : FishingItem
    {
        private static RedFishRoe? instance = null;
        private static readonly object locker = new object();

        RedFishRoe()
        {
            name = "Red Fish Roe";
        }

        public static RedFishRoe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RedFishRoe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class FishLiver : FishingItem
    {
        private static FishLiver? instance = null;
        private static readonly object locker = new object();

        FishLiver()
        {
            name = "Fish Liver";
        }

        public static FishLiver Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FishLiver();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class FishOil : FishingItem
    {
        private static FishOil? instance = null;
        private static readonly object locker = new object();

        FishOil()
        {
            name = "Fish Oil";
        }

        public static FishOil Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FishOil();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LuminousSack : FishingItem
    {
        private static LuminousSack? instance = null;
        private static readonly object locker = new object();

        LuminousSack()
        {
            name = "Luminous Sack";
        }

        public static LuminousSack Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LuminousSack();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BlackFishRoe : FishingItem
    {
        private static BlackFishRoe? instance = null;
        private static readonly object locker = new object();

        BlackFishRoe()
        {
            name = "Blac kFish Roe";
        }

        public static BlackFishRoe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BlackFishRoe();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Fishes
    public sealed class Shrimp : FishingItem
    {
        private static Shrimp? instance = null;
        private static readonly object locker = new object();

        Shrimp()
        {
            name = "Shrimp";
        }

        public static Shrimp Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Shrimp();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class TangerineFish : FishingItem
    {
        private static TangerineFish? instance = null;
        private static readonly object locker = new object();

        TangerineFish()
        {
            name = "Tangerine Fish";
        }

        public static TangerineFish Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new TangerineFish();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Catfish : FishingItem
    {
        private static Catfish? instance = null;
        private static readonly object locker = new object();

        Catfish()
        {
            name = "Catfish";
        }

        public static Catfish Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Catfish();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Mino : FishingItem
    {
        private static Mino? instance = null;
        private static readonly object locker = new object();

        Mino()
        {
            name = "Mino";
        }

        public static Mino Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Mino();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class OversizedMino : FishingItem
    {
        private static OversizedMino? instance = null;
        private static readonly object locker = new object();

        OversizedMino()
        {
            name = "Oversized Mino";
        }

        public static OversizedMino Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new OversizedMino();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class TenchFish : FishingItem
    {
        private static TenchFish? instance = null;
        private static readonly object locker = new object();

        TenchFish()
        {
            name = "Tench Fish";
        }

        public static TenchFish Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new TenchFish();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class RainbowFish : FishingItem
    {
        private static RainbowFish? instance = null;
        private static readonly object locker = new object();

        RainbowFish()
        {
            name = "Rainbow Fish";
        }

        public static RainbowFish Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RainbowFish();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SandFish : FishingItem
    {
        private static SandFish? instance = null;
        private static readonly object locker = new object();

        SandFish()
        {
            name = "Sand Fish";
        }

        public static SandFish Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SandFish();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ScaleFish : FishingItem
    {
        private static ScaleFish? instance = null;
        private static readonly object locker = new object();

        ScaleFish()
        {
            name = "Scale Fish";
        }

        public static ScaleFish Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ScaleFish();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class JuniperFish : FishingItem
    {
        private static JuniperFish? instance = null;
        private static readonly object locker = new object();

        JuniperFish()
        {
            name = "Juniper Fish";
        }

        public static JuniperFish Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new JuniperFish();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Lobster : FishingItem
    {
        private static Lobster? instance = null;
        private static readonly object locker = new object();

        Lobster()
        {
            name = "Lobster";
        }

        public static Lobster Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Lobster();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class PrincessFish : FishingItem
    {
        private static PrincessFish? instance = null;
        private static readonly object locker = new object();

        PrincessFish()
        {
            name = "Princess Fish";
        }

        public static PrincessFish Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new PrincessFish();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SunFish : FishingItem
    {
        private static SunFish? instance = null;
        private static readonly object locker = new object();

        SunFish()
        {
            name = "Sun Fish";
        }

        public static SunFish Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SunFish();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class AngelFish : FishingItem
    {
        private static AngelFish? instance = null;
        private static readonly object locker = new object();

        AngelFish()
        {
            name = "Angel Fish";
        }

        public static AngelFish Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new AngelFish();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SkyFish : FishingItem
    {
        private static SkyFish? instance = null;
        private static readonly object locker = new object();

        SkyFish()
        {
            name = "Sky Fish";
        }

        public static SkyFish Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SkyFish();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class StarFish : FishingItem
    {
        private static StarFish? instance = null;
        private static readonly object locker = new object();

        StarFish()
        {
            name = "Star Fish";
        }

        public static StarFish Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new StarFish();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BigmouthFlounder : FishingItem
    {
        private static BigmouthFlounder? instance = null;
        private static readonly object locker = new object();

        BigmouthFlounder()
        {
            name = "Bigmouth Flounder";
        }

        public static BigmouthFlounder Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BigmouthFlounder();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class FrostSturgeon : FishingItem
    {
        private static FrostSturgeon? instance = null;
        private static readonly object locker = new object();

        FrostSturgeon()
        {
            name = "Frost Sturgeon";
        }

        public static FrostSturgeon Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FrostSturgeon();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BogProwler : FishingItem
    {
        private static BogProwler? instance = null;
        private static readonly object locker = new object();

        BogProwler()
        {
            name = "Bog Prowler";
        }

        public static BogProwler Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BogProwler();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Gromper : FishingItem
    {
        private static Gromper? instance = null;
        private static readonly object locker = new object();

        Gromper()
        {
            name = "Gromper";
        }

        public static Gromper Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Gromper();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class RainbowFlounder : FishingItem
    {
        private static RainbowFlounder? instance = null;
        private static readonly object locker = new object();

        RainbowFlounder()
        {
            name = "Rainbow Flounder";
        }

        public static RainbowFlounder Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RainbowFlounder();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class TigerShark : FishingItem
    {
        private static TigerShark? instance = null;
        private static readonly object locker = new object();

        TigerShark()
        {
            name = "Tiger Shark";
        }

        public static TigerShark Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new TigerShark();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Stingray : FishingItem
    {
        private static Stingray? instance = null;
        private static readonly object locker = new object();

        Stingray()
        {
            name = "Stingray";
        }

        public static Stingray Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Stingray();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion
}
