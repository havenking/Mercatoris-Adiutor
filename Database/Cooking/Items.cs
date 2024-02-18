namespace MercatorisAdiutor.Database.Cooking.Items
{
    public abstract class CookingItem : Item
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

    #region Baked Goods
    public sealed class BakedPotatoes : CookingItem
    {
        private static BakedPotatoes? instance = null;
        private static readonly object locker = new object();

        BakedPotatoes()
        {
            name = "Baked Potatoes";
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
            name = "Corn On A Cob";
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
            name = "Potato Bread";
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
            name = "Sajecho Hardtrack";
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
            name = "Rohna Crackers";
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
            name = "Glademire Crackers";
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
            name = "Bun";
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
            name = "Loaf Bread";
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
            name = "Cookies";
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
            name = "Scane";
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
            name = "Cornbread";
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
            name = "Deluxe Cookies";
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
            name = "Muffin";
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
            name = "Bagel";
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
            name = "Cake";
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
            name = "Croissant";
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
            name = "Sourdought Bagel";
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
            name = "Deluxe Cake";
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
            name = "Danish";
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
            name = "Rye Bread";
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
            name = "Pie";
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
            name = "Vodka";
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
            name = "Beer";
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
            name = "Landing Brandy";
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
            name = "Apple Cider";
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
            name = "Wine";
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
            name = "Whiskey";
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
            name = "Orange Liqueur";
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
            name = "Rum";
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
            name = "Blueberry Wine";
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
            name = "Boozemelon";
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
            name = "Spiced Rum";
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
            name = "Banana Vodka";
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
            name = "Eclipse";
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
            name = "Strawberry Whiskey";
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
            name = "Corn Chowder";
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
            name = "Corn Salad";
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
            name = "Scrambled Eggs";
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
            name = "Apple Puree";
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
            name = "Mashed Potatoes";
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
            name = "Carrot Soup";
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
            name = "Lyderian Fries";
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
            name = "Omelet";
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
            name = "Silky Scrambled Eggs";
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
            name = "Steamed Carrots";
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
            name = "Fruit Pancakes";
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
            name = "Smoked Sausage";
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
            name = "Charred Meat Kebab";
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
            name = "Roasted Chicken And Veggies";
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
            name = "Ravendawnian Porridge";
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
            name = "Rum Downslider";
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
            name = "Shaked Fruitmilk";
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
            name = "Settler's Stew";
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
            name = "Dwarven Purple Shank";
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
            name = "Fillet Lucien";
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
            name = "Blueberry Pie";
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
            name = "Frozen Sweet Berries";
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
            name = "Lucien's Waffles";
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
            name = "Acornchar Sausage";
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
            name = "Freshfish Roll";
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
            name = "Sweetened Beans";
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
            name = "Firered Chicken Kebab";
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
            name = "Lyderian Chopped Tenderloin";
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
            name = "Rohna Roasted Ham";
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
            name = "Sailor's Seastew";
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
            name = "Bittersweet Roast";
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
            name = "Shanks N' Mash";
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
            name = "Iced Fruitmilk";
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
            name = "Basic Seasoning";
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
            name = "Seafood Seasoning";
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
            name = "GroundFlour";
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
            name = "Butter";
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
            name = "Brewer Yeast";
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
            name = "Gourmet Seasoning";
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
            name = "Rich Flour";
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
            name = "Spiced Oil";
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
            name = "Spicy Seasoning";
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
            name = "Basic Animal Feed";
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
            name = "Moa Ration";
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
            name = "Superior Ration";
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
            name = "Complex Animal Feed";
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
            name = "Gourmet Ration";
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
            name = "Safood Extravaganza";
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
            name = "Uncanny Ration";
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
            name = "Moa's Delight";
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
