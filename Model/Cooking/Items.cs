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
            id = 0;
            name = "Baked Potatoes";
            icon = "generic.png";
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
            id = 0;
            name = "Corn On A Cob";
            icon = "generic.png";
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
            id = 0;
            name = "Potato Bread";
            icon = "generic.png";
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

    public sealed class SajechoHardtrack : CookingItem
    {
        private static SajechoHardtrack? instance = null;
        private static readonly object locker = new object();

        SajechoHardtrack()
        {
            id = 0;
            name = "Sajecho Hardtrack";
            icon = "generic.png";
        }

        public static SajechoHardtrack Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SajechoHardtrack();
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
            id = 0;
            name = "Rohna Crackers";
            icon = "generic.png";
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
            id = 0;
            name = "Glademire Crackers";
            icon = "generic.png";
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
            id = 0;
            name = "Bun";
            icon = "generic.png";
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
            id = 0;
            name = "Loaf Bread";
            icon = "generic.png";
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
            id = 0;
            name = "Cookies";
            icon = "generic.png";
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

    public sealed class Scane : CookingItem
    {
        private static Scane? instance = null;
        private static readonly object locker = new object();

        Scane()
        {
            id = 0;
            name = "Scane";
            icon = "generic.png";
        }

        public static Scane Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Scane();
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
            id = 0;
            name = "Cornbread";
            icon = "generic.png";
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
            id = 0;
            name = "Deluxe Cookies";
            icon = "generic.png";
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
            id = 0;
            name = "Muffin";
            icon = "generic.png";
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
            id = 0;
            name = "Bagel";
            icon = "generic.png";
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
            id = 0;
            name = "Cake";
            icon = "generic.png";
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
            id = 0;
            name = "Croissant";
            icon = "generic.png";
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
            id = 0;
            name = "Sourdought Bagel";
            icon = "generic.png";
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
            id = 0;
            name = "Deluxe Cake";
            icon = "generic.png";
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
            id = 0;
            name = "Danish";
            icon = "generic.png";
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
            id = 0;
            name = "Rye Bread";
            icon = "generic.png";
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
            id = 0;
            name = "Pie";
            icon = "generic.png";
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
            id = 0;
            name = "Vodka";
            icon = "generic.png";
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
            id = 0;
            name = "Beer";
            icon = "generic.png";
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
            id = 0;
            name = "Landing Brandy";
            icon = "generic.png";
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
            id = 0;
            name = "Apple Cider";
            icon = "generic.png";
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
            id = 0;
            name = "Wine";
            icon = "generic.png";
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
            id = 0;
            name = "Whiskey";
            icon = "generic.png";
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
            id = 0;
            name = "Orange Liqueur";
            icon = "generic.png";
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
            id = 0;
            name = "Rum";
            icon = "generic.png";
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
            id = 0;
            name = "Blueberry Wine";
            icon = "generic.png";
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
            id = 0;
            name = "Boozemelon";
            icon = "generic.png";
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
            id = 0;
            name = "Spiced Rum";
            icon = "generic.png";
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
            id = 0;
            name = "Banana Vodka";
            icon = "generic.png";
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
            id = 0;
            name = "Eclipse";
            icon = "generic.png";
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
            id = 0;
            name = "Strawberry Whiskey";
            icon = "generic.png";
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
            id = 0;
            name = "Corn Chowder";
            icon = "generic.png";
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
            id = 0;
            name = "Corn Salad";
            icon = "generic.png";
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
            id = 0;
            name = "Scrambled Eggs";
            icon = "generic.png";
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
            id = 0;
            name = "Apple Puree";
            icon = "generic.png";
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
            id = 0;
            name = "Mashed Potatoes";
            icon = "generic.png";
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
            id = 0;
            name = "Carrot Soup";
            icon = "generic.png";
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
            id = 0;
            name = "Lyderian Fries";
            icon = "generic.png";
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
            id = 0;
            name = "Omelet";
            icon = "generic.png";
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
            id = 0;
            name = "Silky Scrambled Eggs";
            icon = "generic.png";
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
            id = 0;
            name = "Steamed Carrots";
            icon = "generic.png";
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
            id = 0;
            name = "Fruit Pancakes";
            icon = "generic.png";
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
            id = 0;
            name = "Smoked Sausage";
            icon = "generic.png";
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
            id = 0;
            name = "Charred Meat Kebab";
            icon = "generic.png";
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
            id = 0;
            name = "Roasted Chicken And Veggies";
            icon = "generic.png";
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
            id = 0;
            name = "Ravendawnian Porridge";
            icon = "generic.png";
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
            id = 0;
            name = "Rum Downslider";
            icon = "generic.png";
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
            id = 0;
            name = "Shaked Fruitmilk";
            icon = "generic.png";
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
            id = 0;
            name = "Settler's Stew";
            icon = "generic.png";
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
            id = 0;
            name = "Dwarven Purple Shank";
            icon = "generic.png";
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
            id = 0;
            name = "Fillet Lucien";
            icon = "generic.png";
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
            id = 0;
            name = "Blueberry Pie";
            icon = "generic.png";
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
            id = 0;
            name = "Frozen Sweet Berries";
            icon = "generic.png";
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
            id = 0;
            name = "Lucien's Waffles";
            icon = "generic.png";
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
            id = 0;
            name = "Acornchar Sausage";
            icon = "generic.png";
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
            id = 0;
            name = "Freshfish Roll";
            icon = "generic.png";
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
            id = 0;
            name = "Sweetened Beans";
            icon = "generic.png";
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
            id = 0;
            name = "Firered Chicken Kebab";
            icon = "generic.png";
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
            id = 0;
            name = "Lyderian Chopped Tenderloin";
            icon = "generic.png";
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
            id = 0;
            name = "Rohna Roasted Ham";
            icon = "generic.png";
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
            id = 0;
            name = "Sailor's Seastew";
            icon = "generic.png";
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
            id = 0;
            name = "Bittersweet Roast";
            icon = "generic.png";
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
            id = 0;
            name = "Shanks N' Mash";
            icon = "generic.png";
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
            id = 0;
            name = "Iced Fruitmilk";
            icon = "generic.png";
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
            name = "Oil";
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
            id = 0;
            name = "Basic Seasoning";
            icon = "generic.png";
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
            id = 0;
            name = "Seafood Seasoning";
            icon = "generic.png";
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
            id = 0;
            name = "GroundFlour";
            icon = "generic.png";
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
            id = 0;
            name = "Butter";
            icon = "generic.png";
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
            id = 0;
            name = "Brewer Yeast";
            icon = "generic.png";
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
            id = 0;
            name = "Gourmet Seasoning";
            icon = "generic.png";
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
            id = 0;
            name = "Rich Flour";
            icon = "generic.png";
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
            id = 0;
            name = "Spiced Oil";
            icon = "generic.png";
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
            id = 0;
            name = "Spicy Seasoning";
            icon = "generic.png";
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
            id = 0;
            name = "Basic Animal Feed";
            icon = "generic.png";
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
            id = 0;
            name = "Moa Ration";
            icon = "generic.png";
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
            id = 0;
            name = "Superior Ration";
            icon = "generic.png";
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
            id = 0;
            name = "Complex Animal Feed";
            icon = "generic.png";
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
            id = 0;
            name = "Gourmet Ration";
            icon = "generic.png";
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

    public sealed class SafoodExtravaganza : CookingItem
    {
        private static SafoodExtravaganza? instance = null;
        private static readonly object locker = new object();

        SafoodExtravaganza()
        {
            id = 0;
            name = "Safood Extravaganza";
            icon = "generic.png";
        }

        public static SafoodExtravaganza Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SafoodExtravaganza();
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
            id = 0;
            name = "Uncanny Ration";
            icon = "generic.png";
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
            id = 0;
            name = "Moa's Delight";
            icon = "generic.png";
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
