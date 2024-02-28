namespace MercatorisAdiutor.Model.Cooking.Items
{
    public abstract class CookingItem : Item
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

    #region Baked Goods
    public sealed class BakedPotatoes : CookingItem
    {
        private static BakedPotatoes? instance = null;
        private static readonly object locker = new object();

        BakedPotatoes()
        {
            id = 42105;
            name = "Baked Potatoes";
            icon = "42105.png";
        }

        public static BakedPotatoes Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BakedPotatoes();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CornOnACob : CookingItem
    {
        private static CornOnACob? instance = null;
        private static readonly object locker = new object();

        CornOnACob()
        {
            id = 42110;
            name = "Corn On A Cob";
            icon = "42110.png";
        }

        public static CornOnACob Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CornOnACob();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class PotatoBread : CookingItem
    {
        private static PotatoBread? instance = null;
        private static readonly object locker = new object();

        PotatoBread()
        {
            id = 42117;
            name = "Potato Bread";
            icon = "42117.png";
        }

        public static PotatoBread Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new PotatoBread();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SajechoHardtack : CookingItem
    {
        private static SajechoHardtack? instance = null;
        private static readonly object locker = new object();

        SajechoHardtack()
        {
            id = 42121;
            name = "Sajecho Hardtack";
            icon = "42121.png";
        }

        public static SajechoHardtack Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SajechoHardtack();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class RohnaCrackers : CookingItem
    {
        private static RohnaCrackers? instance = null;
        private static readonly object locker = new object();

        RohnaCrackers()
        {
            id = 42119;
            name = "Rohna Crackers";
            icon = "42119.png";
        }

        public static RohnaCrackers Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RohnaCrackers();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class GlademireCrackers : CookingItem
    {
        private static GlademireCrackers? instance = null;
        private static readonly object locker = new object();

        GlademireCrackers()
        {
            id = 42748;
            name = "Glademire Crackers";
            icon = "42748.png";
        }

        public static GlademireCrackers Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new GlademireCrackers();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Bun : CookingItem
    {
        private static Bun? instance = null;
        private static readonly object locker = new object();

        Bun()
        {
            id = 28754;
            name = "Bun";
            icon = "28754.png";
        }

        public static Bun Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Bun();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LoafBread : CookingItem
    {
        private static LoafBread? instance = null;
        private static readonly object locker = new object();

        LoafBread()
        {
            id = 42113;
            name = "Loaf Bread";
            icon = "42113.png";
        }

        public static LoafBread Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LoafBread();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Cookies : CookingItem
    {
        private static Cookies? instance = null;
        private static readonly object locker = new object();

        Cookies()
        {
            id = 28766;
            name = "Cookies";
            icon = "28766.png";
        }

        public static Cookies Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Cookies();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Scone : CookingItem
    {
        private static Scone? instance = null;
        private static readonly object locker = new object();

        Scone()
        {
            id = 28759;
            name = "Scone";
            icon = "28759.png";
        }

        public static Scone Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Scone();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Cornbread : CookingItem
    {
        private static Cornbread? instance = null;
        private static readonly object locker = new object();

        Cornbread()
        {
            id = 42111;
            name = "Cornbread";
            icon = "42111.png";
        }

        public static Cornbread Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Cornbread();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class DeluxeCookies : CookingItem
    {
        private static DeluxeCookies? instance = null;
        private static readonly object locker = new object();

        DeluxeCookies()
        {
            id = 28764;
            name = "Deluxe Cookies";
            icon = "28764.png";
        }

        public static DeluxeCookies Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new DeluxeCookies();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Muffin : CookingItem
    {
        private static Muffin? instance = null;
        private static readonly object locker = new object();

        Muffin()
        {
            id = 28765;
            name = "Muffin";
            icon = "28765.png";
        }

        public static Muffin Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Muffin();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Bagel : CookingItem
    {
        private static Bagel? instance = null;
        private static readonly object locker = new object();

        Bagel()
        {
            id = 42104;
            name = "Bagel";
            icon = "42104.png";
        }

        public static Bagel Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Bagel();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Cake : CookingItem
    {
        private static Cake? instance = null;
        private static readonly object locker = new object();

        Cake()
        {
            id = 28755;
            name = "Cake";
            icon = "28755.png";
        }

        public static Cake Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Cake();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Croissant : CookingItem
    {
        private static Croissant? instance = null;
        private static readonly object locker = new object();

        Croissant()
        {
            id = 28756;
            name = "Croissant";
            icon = "28756.png";
        }

        public static Croissant Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Croissant();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SourdoughtBagel : CookingItem
    {
        private static SourdoughtBagel? instance = null;
        private static readonly object locker = new object();

        SourdoughtBagel()
        {
            id = 42125;
            name = "Sourdought Bagel";
            icon = "42125.png";
        }

        public static SourdoughtBagel Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SourdoughtBagel();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class DeluxeCake : CookingItem
    {
        private static DeluxeCake? instance = null;
        private static readonly object locker = new object();

        DeluxeCake()
        {
            id = 28758;
            name = "Deluxe Cake";
            icon = "28758.png";
        }

        public static DeluxeCake Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new DeluxeCake();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Danish : CookingItem
    {
        private static Danish? instance = null;
        private static readonly object locker = new object();

        Danish()
        {
            id = 28757;
            name = "Danish";
            icon = "28757.png";
        }

        public static Danish Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Danish();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class RyeBread : CookingItem
    {
        private static RyeBread? instance = null;
        private static readonly object locker = new object();

        RyeBread()
        {
            id = 42120;
            name = "Rye Bread";
            icon = "42120.png";
        }

        public static RyeBread Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RyeBread();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Pie : CookingItem
    {
        private static Pie? instance = null;
        private static readonly object locker = new object();

        Pie()
        {
            id = 28753;
            name = "Pie";
            icon = "28753.png";
        }

        public static Pie Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Pie();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Drinks
    public sealed class Vodka : CookingItem
    {
        private static Vodka? instance = null;
        private static readonly object locker = new object();

        Vodka()
        {
            id = 28767;
            name = "Vodka";
            icon = "28767.png";
        }

        public static Vodka Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Vodka();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Beer : CookingItem
    {
        private static Beer? instance = null;
        private static readonly object locker = new object();

        Beer()
        {
            id = 28760;
            name = "Beer";
            icon = "28760.png";
        }

        public static Beer Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Beer();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LandingBrandy : CookingItem
    {
        private static LandingBrandy? instance = null;
        private static readonly object locker = new object();

        LandingBrandy()
        {
            id = 42724;
            name = "Landing Brandy";
            icon = "42724.png";
        }

        public static LandingBrandy Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LandingBrandy();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class AppleCider : CookingItem
    {
        private static AppleCider? instance = null;
        private static readonly object locker = new object();

        AppleCider()
        {
            id = 35397;
            name = "Apple Cider";
            icon = "35397.png";
        }

        public static AppleCider Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new AppleCider();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Wine : CookingItem
    {
        private static Wine? instance = null;
        private static readonly object locker = new object();

        Wine()
        {
            id = 35400;
            name = "Wine";
            icon = "35400.png";
        }

        public static Wine Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Wine();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Whiskey : CookingItem
    {
        private static Whiskey? instance = null;
        private static readonly object locker = new object();

        Whiskey()
        {
            id = 35399;
            name = "Whiskey";
            icon = "35399.png";
        }

        public static Whiskey Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Whiskey();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class OrangeLiqueur : CookingItem
    {
        private static OrangeLiqueur? instance = null;
        private static readonly object locker = new object();

        OrangeLiqueur()
        {
            id = 42721;
            name = "Orange Liqueur";
            icon = "42721.png";
        }

        public static OrangeLiqueur Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new OrangeLiqueur();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Rum : CookingItem
    {
        private static Rum? instance = null;
        private static readonly object locker = new object();

        Rum()
        {
            id = 28883;
            name = "Rum";
            icon = "28883.png";
        }

        public static Rum Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Rum();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BlueberryWine : CookingItem
    {
        private static BlueberryWine? instance = null;
        private static readonly object locker = new object();

        BlueberryWine()
        {
            id = 35400;
            name = "Blueberry Wine";
            icon = "35400.png";
        }

        public static BlueberryWine Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BlueberryWine();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Boozemelon : CookingItem
    {
        private static Boozemelon? instance = null;
        private static readonly object locker = new object();

        Boozemelon()
        {
            id = 42722;
            name = "Boozemelon";
            icon = "42722.png";
        }

        public static Boozemelon Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Boozemelon();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SpicedRum : CookingItem
    {
        private static SpicedRum? instance = null;
        private static readonly object locker = new object();

        SpicedRum()
        {
            id = 35401;
            name = "Spiced Rum";
            icon = "35401.png";
        }

        public static SpicedRum Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SpicedRum();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BananaVodka : CookingItem
    {
        private static BananaVodka? instance = null;
        private static readonly object locker = new object();

        BananaVodka()
        {
            id = 35398;
            name = "Banana Vodka";
            icon = "35398.png";
        }

        public static BananaVodka Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BananaVodka();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Eclipse : CookingItem
    {
        private static Eclipse? instance = null;
        private static readonly object locker = new object();

        Eclipse()
        {
            id = 42723;
            name = "Eclipse";
            icon = "42723.png";
        }

        public static Eclipse Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Eclipse();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class StrawberryWhiskey : CookingItem
    {
        private static StrawberryWhiskey? instance = null;
        private static readonly object locker = new object();

        StrawberryWhiskey()
        {
            id = 35399;
            name = "Strawberry Whiskey";
            icon = "35399.png";
        }

        public static StrawberryWhiskey Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new StrawberryWhiskey();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Meals
    public sealed class CornChowder : CookingItem
    {
        private static CornChowder? instance = null;
        private static readonly object locker = new object();

        CornChowder()
        {
            id = 42109;
            name = "Corn Chowder";
            icon = "42109.png";
        }

        public static CornChowder Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CornChowder();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CornSalada : CookingItem
    {
        private static CornSalada? instance = null;
        private static readonly object locker = new object();

        CornSalada()
        {
            id = 42128;
            name = "Corn Salad";
            icon = "42128.png";
        }

        public static CornSalada Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CornSalada();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ScrambledEggs : CookingItem
    {
        private static ScrambledEggs? instance = null;
        private static readonly object locker = new object();

        ScrambledEggs()
        {
            id = 42122;
            name = "Scrambled Eggs";
            icon = "42122.png";
        }

        public static ScrambledEggs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ScrambledEggs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ApplePuree : CookingItem
    {
        private static ApplePuree? instance = null;
        private static readonly object locker = new object();

        ApplePuree()
        {
            id = 42103;
            name = "Apple Puree";
            icon = "42103.png";
        }

        public static ApplePuree Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ApplePuree();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MashedPotatoes : CookingItem
    {
        private static MashedPotatoes? instance = null;
        private static readonly object locker = new object();

        MashedPotatoes()
        {
            id = 42115;
            name = "Mashed Potatoes";
            icon = "42115.png";
        }

        public static MashedPotatoes Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MashedPotatoes();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CarrotSoup : CookingItem
    {
        private static CarrotSoup? instance = null;
        private static readonly object locker = new object();

        CarrotSoup()
        {
            id = 42108;
            name = "Carrot Soup";
            icon = "42108.png";
        }

        public static CarrotSoup Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CarrotSoup();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LyderianFries : CookingItem
    {
        private static LyderianFries? instance = null;
        private static readonly object locker = new object();

        LyderianFries()
        {
            id = 42114;
            name = "Lyderian Fries";
            icon = "42114.png";
        }

        public static LyderianFries Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LyderianFries();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Omelet : CookingItem
    {
        private static Omelet? instance = null;
        private static readonly object locker = new object();

        Omelet()
        {
            id = 42116;
            name = "Omelet";
            icon = "42116.png";
        }

        public static Omelet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Omelet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SilkyScrambledEggs : CookingItem
    {
        private static SilkyScrambledEggs? instance = null;
        private static readonly object locker = new object();

        SilkyScrambledEggs()
        {
            id = 42124;
            name = "Silky Scrambled Eggs";
            icon = "42124.png";
        }

        public static SilkyScrambledEggs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SilkyScrambledEggs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SteamedCarrots : CookingItem
    {
        private static SteamedCarrots? instance = null;
        private static readonly object locker = new object();

        SteamedCarrots()
        {
            id = 42127;
            name = "Steamed Carrots";
            icon = "42127.png";
        }

        public static SteamedCarrots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SteamedCarrots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class FruitPancakes : CookingItem
    {
        private static FruitPancakes? instance = null;
        private static readonly object locker = new object();

        FruitPancakes()
        {
            id = 34855;
            name = "Fruit Pancakes";
            icon = "34855.png";
        }

        public static FruitPancakes Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FruitPancakes();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SmokedSausage : CookingItem
    {
        private static SmokedSausage? instance = null;
        private static readonly object locker = new object();

        SmokedSausage()
        {
            id = 34869;
            name = "Smoked Sausage";
            icon = "34869.png";
        }

        public static SmokedSausage Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmokedSausage();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CharredMeatKebab : CookingItem
    {
        private static CharredMeatKebab? instance = null;
        private static readonly object locker = new object();

        CharredMeatKebab()
        {
            id = 34849;
            name = "Charred Meat Kebab";
            icon = "34849.png";
        }

        public static CharredMeatKebab Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CharredMeatKebab();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class RoastedChickenAndVeggies : CookingItem
    {
        private static RoastedChickenAndVeggies? instance = null;
        private static readonly object locker = new object();

        RoastedChickenAndVeggies()
        {
            id = 34861;
            name = "Roasted Chicken And Veggies";
            icon = "34861.png";
        }

        public static RoastedChickenAndVeggies Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RoastedChickenAndVeggies();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class RavendawnianPorridge : CookingItem
    {
        private static RavendawnianPorridge? instance = null;
        private static readonly object locker = new object();

        RavendawnianPorridge()
        {
            id = 34860;
            name = "Ravendawnian Porridge";
            icon = "34860.png";
        }

        public static RavendawnianPorridge Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RavendawnianPorridge();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class RumDownslider : CookingItem
    {
        private static RumDownslider? instance = null;
        private static readonly object locker = new object();

        RumDownslider()
        {
            id = 34864;
            name = "Rum Downslider";
            icon = "34864.png";
        }

        public static RumDownslider Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RumDownslider();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ShakedFruitmilk : CookingItem
    {
        private static ShakedFruitmilk? instance = null;
        private static readonly object locker = new object();

        ShakedFruitmilk()
        {
            id = 34868;
            name = "Shaked Fruitmilk";
            icon = "34868.png";
        }

        public static ShakedFruitmilk Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ShakedFruitmilk();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SettlerStew : CookingItem
    {
        private static SettlerStew? instance = null;
        private static readonly object locker = new object();

        SettlerStew()
        {
            id = 34866;
            name = "Settler's Stew";
            icon = "34866.png";
        }

        public static SettlerStew Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SettlerStew();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class DwarvenPurpleShank : CookingItem
    {
        private static DwarvenPurpleShank? instance = null;
        private static readonly object locker = new object();

        DwarvenPurpleShank()
        {
            id = 34851;
            name = "Dwarven Purple Shank";
            icon = "34851.png";
        }

        public static DwarvenPurpleShank Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new DwarvenPurpleShank();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class FilletLucien : CookingItem
    {
        private static FilletLucien? instance = null;
        private static readonly object locker = new object();

        FilletLucien()
        {
            id = 34852;
            name = "Fillet Lucien";
            icon = "34852.png";
        }

        public static FilletLucien Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FilletLucien();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BlueberryPie : CookingItem
    {
        private static BlueberryPie? instance = null;
        private static readonly object locker = new object();

        BlueberryPie()
        {
            id = 42725;
            name = "Blueberry Pie";
            icon = "42725.png";
        }

        public static BlueberryPie Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BlueberryPie();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class FrozenSweetBerries : CookingItem
    {
        private static FrozenSweetBerries? instance = null;
        private static readonly object locker = new object();

        FrozenSweetBerries()
        {
            id = 34854;
            name = "Frozen Sweet Berries";
            icon = "34854.png";
        }

        public static FrozenSweetBerries Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FrozenSweetBerries();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LucienWaffles : CookingItem
    {
        private static LucienWaffles? instance = null;
        private static readonly object locker = new object();

        LucienWaffles()
        {
            id = 34858;
            name = "Lucien's Waffles";
            icon = "34858.png";
        }

        public static LucienWaffles Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LucienWaffles();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class AcorncharSausage : CookingItem
    {
        private static AcorncharSausage? instance = null;
        private static readonly object locker = new object();

        AcorncharSausage()
        {
            id = 34847;
            name = "Acornchar Sausage";
            icon = "34847.png";
        }

        public static AcorncharSausage Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new AcorncharSausage();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class FreshfishRoll : CookingItem
    {
        private static FreshfishRoll? instance = null;
        private static readonly object locker = new object();

        FreshfishRoll()
        {
            id = 34853;
            name = "Freshfish Roll";
            icon = "34853.png";
        }

        public static FreshfishRoll Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FreshfishRoll();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SweetenedBeans : CookingItem
    {
        private static SweetenedBeans? instance = null;
        private static readonly object locker = new object();

        SweetenedBeans()
        {
            id = 34870;
            name = "Sweetened Beans";
            icon = "34870.png";
        }

        public static SweetenedBeans Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SweetenedBeans();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class FireredChickenKebab : CookingItem
    {
        private static FireredChickenKebab? instance = null;
        private static readonly object locker = new object();

        FireredChickenKebab()
        {
            id = 34857;
            name = "Firered Chicken Kebab";
            icon = "34857.png";
        }

        public static FireredChickenKebab Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FireredChickenKebab();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LyderianChoppedTenderloin : CookingItem
    {
        private static LyderianChoppedTenderloin? instance = null;
        private static readonly object locker = new object();

        LyderianChoppedTenderloin()
        {
            id = 34859;
            name = "Lyderian Chopped Tenderloin";
            icon = "34859.png";
        }

        public static LyderianChoppedTenderloin Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LyderianChoppedTenderloin();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class RohnaRoastedHam : CookingItem
    {
        private static RohnaRoastedHam? instance = null;
        private static readonly object locker = new object();

        RohnaRoastedHam()
        {
            id = 34862;
            name = "Rohna Roasted Ham";
            icon = "34862.png";
        }

        public static RohnaRoastedHam Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RohnaRoastedHam();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SailorSeastew : CookingItem
    {
        private static SailorSeastew? instance = null;
        private static readonly object locker = new object();

        SailorSeastew()
        {
            id = 34865;
            name = "Sailor's Seastew";
            icon = "34865.png";
        }

        public static SailorSeastew Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SailorSeastew();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BittersweetRoast : CookingItem
    {
        private static BittersweetRoast? instance = null;
        private static readonly object locker = new object();

        BittersweetRoast()
        {
            id = 34848;
            name = "Bittersweet Roast";
            icon = "34848.png";
        }

        public static BittersweetRoast Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BittersweetRoast();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ShanksNMash : CookingItem
    {
        private static ShanksNMash? instance = null;
        private static readonly object locker = new object();

        ShanksNMash()
        {
            id = 35402;
            name = "Shanks N' Mash";
            icon = "35402.png";
        }

        public static ShanksNMash Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ShanksNMash();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class IcedFruitmilk : CookingItem
    {
        private static IcedFruitmilk? instance = null;
        private static readonly object locker = new object();

        IcedFruitmilk()
        {
            id = 34856;
            name = "Iced Fruitmilk";
            icon = "34856.png";
        }

        public static IcedFruitmilk Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new IcedFruitmilk();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Ingredients
    public sealed class Oil : CookingItem
    {
        private static Oil? instance = null;
        private static readonly object locker = new object();

        Oil()
        {
            id = 34899;
            name = "Oil";
            icon = "34899.png";
        }

        public static Oil Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Oil();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BasicSeasoning : CookingItem
    {
        private static BasicSeasoning? instance = null;
        private static readonly object locker = new object();

        BasicSeasoning()
        {
            id = 42106;
            name = "Basic Seasoning";
            icon = "42106.png";
        }

        public static BasicSeasoning Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BasicSeasoning();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SeafoodSeasoning : CookingItem
    {
        private static SeafoodSeasoning? instance = null;
        private static readonly object locker = new object();

        SeafoodSeasoning()
        {
            id = 42123;
            name = "Seafood Seasoning";
            icon = "42123.png";
        }

        public static SeafoodSeasoning Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SeafoodSeasoning();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class GroundFlour : CookingItem
    {
        private static GroundFlour? instance = null;
        private static readonly object locker = new object();

        GroundFlour()
        {
            id = 33553;
            name = "Ground Flour";
            icon = "33553.png";
        }

        public static GroundFlour Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new GroundFlour();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Butter : CookingItem
    {
        private static Butter? instance = null;
        private static readonly object locker = new object();

        Butter()
        {
            id = 42749;
            name = "Butter";
            icon = "42749.png";
        }

        public static Butter Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Butter();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BrewerYeast : CookingItem
    {
        private static BrewerYeast? instance = null;
        private static readonly object locker = new object();

        BrewerYeast()
        {
            id = 42107;
            name = "Brewer Yeast";
            icon = "42107.png";
        }

        public static BrewerYeast Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BrewerYeast();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class GourmetSeasoning : CookingItem
    {
        private static GourmetSeasoning? instance = null;
        private static readonly object locker = new object();

        GourmetSeasoning()
        {
            id = 42112;
            name = "Gourmet Seasoning";
            icon = "42112.png";
        }

        public static GourmetSeasoning Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new GourmetSeasoning();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class RichFlour : CookingItem
    {
        private static RichFlour? instance = null;
        private static readonly object locker = new object();

        RichFlour()
        {
            id = 42118;
            name = "Rich Flour";
            icon = "42118.png";
        }

        public static RichFlour Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RichFlour();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SpicedOil : CookingItem
    {
        private static SpicedOil? instance = null;
        private static readonly object locker = new object();

        SpicedOil()
        {
            id = 34900;
            name = "Spiced Oil";
            icon = "34900.png";
        }

        public static SpicedOil Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SpicedOil();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SpicySeasoning : CookingItem
    {
        private static SpicySeasoning? instance = null;
        private static readonly object locker = new object();

        SpicySeasoning()
        {
            id = 42126;
            name = "Spicy Seasoning";
            icon = "42126.png";
        }

        public static SpicySeasoning Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SpicySeasoning();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Misc
    public sealed class BasicAnimalFeed : CookingItem
    {
        private static BasicAnimalFeed? instance = null;
        private static readonly object locker = new object();

        BasicAnimalFeed()
        {
            id = 34896;
            name = "Basic Animal Feed";
            icon = "34896.png";
        }

        public static BasicAnimalFeed Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BasicAnimalFeed();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MoaRation : CookingItem
    {
        private static MoaRation? instance = null;
        private static readonly object locker = new object();

        MoaRation()
        {
            id = 38161;
            name = "Moa Ration";
            icon = "38161.png";
        }

        public static MoaRation Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MoaRation();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SuperiorRation : CookingItem
    {
        private static SuperiorRation? instance = null;
        private static readonly object locker = new object();

        SuperiorRation()
        {
            id = 43649;
            name = "Superior Ration";
            icon = "43649.png";
        }

        public static SuperiorRation Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SuperiorRation();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ComplexAnimalFeed : CookingItem
    {
        private static ComplexAnimalFeed? instance = null;
        private static readonly object locker = new object();

        ComplexAnimalFeed()
        {
            id = 34897;
            name = "Complex Animal Feed";
            icon = "34897.png";
        }

        public static ComplexAnimalFeed Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ComplexAnimalFeed();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class GourmetRation : CookingItem
    {
        private static GourmetRation? instance = null;
        private static readonly object locker = new object();

        GourmetRation()
        {
            id = 43640;
            name = "Gourmet Ration";
            icon = "43640.png";
        }

        public static GourmetRation Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new GourmetRation();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SeafoodExtravaganza : CookingItem
    {
        private static SeafoodExtravaganza? instance = null;
        private static readonly object locker = new object();

        SeafoodExtravaganza()
        {
            id = 43646;
            name = "Seafood Extravaganza";
            icon = "43646.png";
        }

        public static SeafoodExtravaganza Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SeafoodExtravaganza();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class UncannyRation : CookingItem
    {
        private static UncannyRation? instance = null;
        private static readonly object locker = new object();

        UncannyRation()
        {
            id = 43642;
            name = "Uncanny Ration";
            icon = "43642.png";
        }

        public static UncannyRation Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new UncannyRation();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MoaDelight : CookingItem
    {
        private static MoaDelight? instance = null;
        private static readonly object locker = new object();

        MoaDelight()
        {
            id = 43643;
            name = "Moa's Delight";
            icon = "43643.png";
        }

        public static MoaDelight Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MoaDelight();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion
}
