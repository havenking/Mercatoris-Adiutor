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
            id = 40832;
            name = "Orange Scales";
            icon = "40832.png";
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
            id = 40825;
            name = "Fish Roe";
            icon = "40825.png";
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
            id = 40830;
            name = "Fish Skin";
            icon = "40830.png";
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
            id = 40834;
            name = "Yellow Fish Roe";
            icon = "40834.png";
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
            id = 40826;
            name = "Fish Eye";
            icon = "40826.png";
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
            id = 40833;
            name = "Red Fish Roe";
            icon = "40833.png";
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
            id = 40827;
            name = "Fish Liver";
            icon = "40827.png";
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
            id = 40828;
            name = "Fish Oil";
            icon = "40828.png";
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
            id = 40831;
            name = "Luminous Sack";
            icon = "40831.png";
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
            id = 40825;
            name = "Black Fish Roe";
            icon = "40825.png";
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
            id = 28906;
            name = "Shrimp";
            icon = "28906.png";
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
            id = 28907;
            name = "Tangerine Fish";
            icon = "28907.png";
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
            id = 28904;
            name = "Catfish";
            icon = "28904.png";
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
            id = 28905;
            name = "Mino";
            icon = "28905.png";
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
            id = 28911;
            name = "Oversized Mino";
            icon = "28911.png";
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
            id = 28908;
            name = "Tench Fish";
            icon = "28908.png";
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
            id = 28917;
            name = "Rainbow Fish";
            icon = "28917.png";
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
            id = 28913;
            name = "Sand Fish";
            icon = "28913.png";
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
            id = 28914;
            name = "Scale Fish";
            icon = "28914.png";
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
            id = 28910;
            name = "Juniper Fish";
            icon = "28910.png";
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
            id = 28916;
            name = "Lobster";
            icon = "28916.png";
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
            id = 28912;
            name = "Princess Fish";
            icon = "28912.png";
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
            id = 28919;
            name = "Sun Fish";
            icon = "28919.png";
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
            id = 28915;
            name = "Angel Fish";
            icon = "28915.png";
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
            id = 28918;
            name = "Sky Fish";
            icon = "28918.png";
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
            id = 28922;
            name = "Star Fish";
            icon = "28922.png";
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
            id = 28920;
            name = "Bigmouth Flounder";
            icon = "28920.png";
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
            id = 38528;
            name = "Frost Sturgeon";
            icon = "38528.png";
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
            id = 39281;
            name = "Bog Prowler";
            icon = "39281.png";
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
            id = 28924;
            name = "Gromper";
            icon = "28924.png";
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
            id = 28921;
            name = "Rainbow Flounder";
            icon = "28921.png";
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
            id = 28926;
            name = "Tiger Shark";
            icon = "28926.png";
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
            id = 28925;
            name = "Stingray";
            icon = "28925.png";
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
