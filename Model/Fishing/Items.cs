namespace MercatorisAdiutor.Model.Fishing.Items
{
    public abstract class FishingItem : Item
    {
        internal int id = -1;
        internal string name = string.Empty;
        internal string icon = string.Empty;
        internal int price = 0;

        public int Id => id;

        public string Name => name;

        public string Icon => icon;

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
            id = 0;
            name = "Orange Scales";
            icon = "generic.png";
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
            id = 0;
            name = "Fish Roe";
            icon = "generic.png";
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
            id = 0;
            name = "Fish Skin";
            icon = "generic.png";
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
            id = 0;
            name = "Yellow Fish Roe";
            icon = "generic.png";
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
            id = 0;
            name = "Fish Eye";
            icon = "generic.png";
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
            id = 0;
            name = "Red Fish Roe";
            icon = "generic.png";
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
            id = 0;
            name = "Fish Liver";
            icon = "generic.png";
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
            id = 0;
            name = "Fish Oil";
            icon = "generic.png";
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
            id = 0;
            name = "Luminous Sack";
            icon = "generic.png";
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
            id = 0;
            name = "Blac kFish Roe";
            icon = "generic.png";
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
            id = 0;
            name = "Shrimp";
            icon = "generic.png";
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
            id = 0;
            name = "Tangerine Fish";
            icon = "generic.png";
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
            id = 0;
            name = "Catfish";
            icon = "generic.png";
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
            id = 0;
            name = "Mino";
            icon = "generic.png";
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
            id = 0;
            name = "Oversized Mino";
            icon = "generic.png";
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
            id = 0;
            name = "Tench Fish";
            icon = "generic.png";
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
            id = 0;
            name = "Rainbow Fish";
            icon = "generic.png";
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
            id = 0;
            name = "Sand Fish";
            icon = "generic.png";
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
            id = 0;
            name = "Scale Fish";
            icon = "generic.png";
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
            id = 0;
            name = "Juniper Fish";
            icon = "generic.png";
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
            id = 0;
            name = "Lobster";
            icon = "generic.png";
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
            id = 0;
            name = "Princess Fish";
            icon = "generic.png";
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
            id = 0;
            name = "Sun Fish";
            icon = "generic.png";
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
            id = 0;
            name = "Angel Fish";
            icon = "generic.png";
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
            id = 0;
            name = "Sky Fish";
            icon = "generic.png";
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
            id = 0;
            name = "Star Fish";
            icon = "generic.png";
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
            id = 0;
            name = "Bigmouth Flounder";
            icon = "generic.png";
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
            id = 0;
            name = "Frost Sturgeon";
            icon = "generic.png";
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
            id = 0;
            name = "Bog Prowler";
            icon = "generic.png";
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
            id = 0;
            name = "Gromper";
            icon = "generic.png";
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
            id = 0;
            name = "Rainbow Flounder";
            icon = "generic.png";
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
            id = 0;
            name = "Tiger Shark";
            icon = "generic.png";
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
            id = 0;
            name = "Stingray";
            icon = "generic.png";
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
