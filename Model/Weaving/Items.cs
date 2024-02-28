namespace MercatorisAdiutor.Model.Weaving.Items
{
    public abstract class WeavingItem : Item
    {
        internal int id = -1;
        internal string name = string.Empty;
        internal string icon = string.Empty;
        internal int price = 0;

        public int Id => id;

        public string Name => name;

        public string Icon => icon;

        public Profession Profession => Profession.Weaving;

        public Category Category => Category.Crafting;

        public int Price 
        {
            get { return price; }
            set { price = value; }
        }
    }

    #region Cloth
    public sealed class SimpleCloth : WeavingItem
    {
        private static SimpleCloth? instance = null;
        private static readonly object locker = new object();

        SimpleCloth()
        {
            id = 28966;
            name = "Simple Cloth";
            icon = "28966.png";
        }

        public static SimpleCloth Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SimpleCloth();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CraftmanCloth : WeavingItem
    {
        private static CraftmanCloth? instance = null;
        private static readonly object locker = new object();

        CraftmanCloth()
        {
            id = 28963;
            name = "Craftman's Cloth";
            icon = "28963.png";
        }

        public static CraftmanCloth Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CraftmanCloth();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Silk : WeavingItem
    {
        private static Silk? instance = null;
        private static readonly object locker = new object();

        Silk()
        {
            id = 28965;
            name = "Silk";
            icon = "28965.png";
        }

        public static Silk Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Silk();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MerchantCloth : WeavingItem
    {
        private static MerchantCloth? instance = null;
        private static readonly object locker = new object();

        MerchantCloth()
        {
            id = 28964;
            name = "Merchant's Cloth";
            icon = "28964.png";
        }

        public static MerchantCloth Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MerchantCloth();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ArtisanCloth : WeavingItem
    {
        private static ArtisanCloth? instance = null;
        private static readonly object locker = new object();

        ArtisanCloth()
        {
            id = 28962;
            name = "Artisan Cloth";
            icon = "28962.png";
        }

        public static ArtisanCloth Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ArtisanCloth();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Leather
    public sealed class CoarseLeather : WeavingItem
    {
        private static CoarseLeather? instance = null;
        private static readonly object locker = new object();

        CoarseLeather()
        {
            id = 35432;
            name = "Coarse Leather";
            icon = "35432.png";
        }

        public static CoarseLeather Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CoarseLeather();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CraftmanLeather : WeavingItem
    {
        private static CraftmanLeather? instance = null;
        private static readonly object locker = new object();

        CraftmanLeather()
        {
            id = 35433;
            name = "Craftman's Leather";
            icon = "35433.png";
        }

        public static CraftmanLeather Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CraftmanLeather();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class TannedLeather : WeavingItem
    {
        private static TannedLeather? instance = null;
        private static readonly object locker = new object();

        TannedLeather()
        {
            id = 35434;
            name = "Tanned Leather";
            icon = "35434.png";
        }

        public static TannedLeather Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new TannedLeather();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MerchantLeather : WeavingItem
    {
        private static MerchantLeather? instance = null;
        private static readonly object locker = new object();

        MerchantLeather()
        {
            id = 35435;
            name = "Merchant's Leather";
            icon = "35435.png";
        }

        public static MerchantLeather Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MerchantLeather();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ArtisanLeather : WeavingItem
    {
        private static ArtisanLeather? instance = null;
        private static readonly object locker = new object();

        ArtisanLeather()
        {
            id = 35436;
            name = "Artisan Leather";
            icon = "35436.png";
        }

        public static ArtisanLeather Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ArtisanLeather();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Threads
    public sealed class CoarseThread : WeavingItem
    {
        private static CoarseThread? instance = null;
        private static readonly object locker = new object();

        CoarseThread()
        {
            id = 28971;
            name = "Coarse Thread";
            icon = "28971.png";
        }

        public static CoarseThread Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CoarseThread();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CraftmanThread : WeavingItem
    {
        private static CraftmanThread? instance = null;
        private static readonly object locker = new object();

        CraftmanThread()
        {
            id = 28972;
            name = "Craftman's Thread";
            icon = "28972.png";
        }

        public static CraftmanThread Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CraftmanThread();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class FineThread : WeavingItem
    {
        private static FineThread? instance = null;
        private static readonly object locker = new object();

        FineThread()
        {
            id = 28973;
            name = "Fine Thread";
            icon = "28973.png";
        }

        public static FineThread Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FineThread();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MerchantThread : WeavingItem
    {
        private static MerchantThread? instance = null;
        private static readonly object locker = new object();

        MerchantThread()
        {
            id = 28969;
            name = "Merchant's Thread";
            icon = "28969.png";
        }

        public static MerchantThread Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MerchantThread();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ArtisanThread : WeavingItem
    {
        private static ArtisanThread? instance = null;
        private static readonly object locker = new object();

        ArtisanThread()
        {
            id = 28970;
            name = "Artisan Thread";
            icon = "28970.png";
        }

        public static ArtisanThread Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ArtisanThread();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Housing Craft
    public sealed class CheapRug : WeavingItem
    {
        private static CheapRug? instance = null;
        private static readonly object locker = new object();

        CheapRug()
        {
            id = 42780;
            name = "Cheap Rug";
            icon = "42780.png";
        }

        public static CheapRug Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CheapRug();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Carpet : WeavingItem
    {
        private static Carpet? instance = null;
        private static readonly object locker = new object();

        Carpet()
        {
            id = 37225;
            name = "Carpet";
            icon = "37225.png";
        }

        public static Carpet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Carpet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ThreadSpool : WeavingItem
    {
        private static ThreadSpool? instance = null;
        private static readonly object locker = new object();

        ThreadSpool()
        {
            id = 37288;
            name = "Thread Spool";
            icon = "37288.png";
        }

        public static ThreadSpool Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSpool();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ClothRoll : WeavingItem
    {
        private static ClothRoll? instance = null;
        private static readonly object locker = new object();

        ClothRoll()
        {
            id = 37226;
            name = "Cloth Roll";
            icon = "37226.png";
        }

        public static ClothRoll Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ClothRoll();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LuxuryCarpet : WeavingItem
    {
        private static LuxuryCarpet? instance = null;
        private static readonly object locker = new object();

        LuxuryCarpet()
        {
            id = 37246;
            name = "Luxury Carpet";
            icon = "37246.png";
        }

        public static LuxuryCarpet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LuxuryCarpet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LuxuryThreadSpool : WeavingItem
    {
        private static LuxuryThreadSpool? instance = null;
        private static readonly object locker = new object();

        LuxuryThreadSpool()
        {
            id = 37248;
            name = "Luxury Thread Spool";
            icon = "37248.png";
        }

        public static LuxuryThreadSpool Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LuxuryThreadSpool();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class RefinedClothRoll : WeavingItem
    {
        private static RefinedClothRoll? instance = null;
        private static readonly object locker = new object();

        RefinedClothRoll()
        {
            id = 37262;
            name = "Refined Cloth Roll";
            icon = "37262.png";
        }

        public static RefinedClothRoll Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RefinedClothRoll();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LuxuryClothRoll : WeavingItem
    {
        private static LuxuryClothRoll? instance = null;
        private static readonly object locker = new object();

        LuxuryClothRoll()
        {
            id = 37247;
            name = "Luxury Cloth Roll";
            icon = "37247.png";
        }

        public static LuxuryClothRoll Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LuxuryClothRoll();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Moa Equipment
    public sealed class SimpleSaddle : WeavingItem
    {
        private static SimpleSaddle? instance = null;
        private static readonly object locker = new object();

        SimpleSaddle()
        {
            id = 43246;
            name = "Simple Saddle";
            icon = "43246.png";
        }

        public static SimpleSaddle Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SimpleSaddle();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ComposedSaddle : WeavingItem
    {
        private static ComposedSaddle? instance = null;
        private static readonly object locker = new object();

        ComposedSaddle()
        {
            id = 43247;
            name = "Composed Saddle";
            icon = "43247.png";
        }

        public static ComposedSaddle Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ComposedSaddle();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class AdvancedSaddle : WeavingItem
    {
        private static AdvancedSaddle? instance = null;
        private static readonly object locker = new object();

        AdvancedSaddle()
        {
            id = 43248;
            name = "Advanced Saddle";
            icon = "43248.png";
        }

        public static AdvancedSaddle Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new AdvancedSaddle();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ArtisanSaddle : WeavingItem
    {
        private static ArtisanSaddle? instance = null;
        private static readonly object locker = new object();

        ArtisanSaddle()
        {
            id = 43249;
            name = "Artisan Saddle";
            icon = "43249.png";
        }

        public static ArtisanSaddle Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ArtisanSaddle();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SuperiorSaddle : WeavingItem
    {
        private static SuperiorSaddle? instance = null;
        private static readonly object locker = new object();

        SuperiorSaddle()
        {
            id = 43250;
            name = "Superior Saddle";
            icon = "43250.png";
        }

        public static SuperiorSaddle Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SuperiorSaddle();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WarSaddle : WeavingItem
    {
        private static WarSaddle? instance = null;
        private static readonly object locker = new object();

        WarSaddle()
        {
            id = 43251;
            name = "War Saddle";
            icon = "43251.png";
        }

        public static WarSaddle Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WarSaddle();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ProfessionalSaddle : WeavingItem
    {
        private static ProfessionalSaddle? instance = null;
        private static readonly object locker = new object();

        ProfessionalSaddle()
        {
            id = 43253;
            name = "Professional Saddle";
            icon = "generic.png";
        }

        public static ProfessionalSaddle Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ProfessionalSaddle();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ExplorerSaddle : WeavingItem
    {
        private static ExplorerSaddle? instance = null;
        private static readonly object locker = new object();

        ExplorerSaddle()
        {
            id = 43252;
            name = "Explorer Saddle";
            icon = "generic.png";
        }

        public static ExplorerSaddle Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ExplorerSaddle();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Ship Module
    public sealed class SmallSailKit : WeavingItem
    {
        private static SmallSailKit? instance = null;
        private static readonly object locker = new object();

        SmallSailKit()
        {
            id = 37276;
            name = "Small Sail Kit";
            icon = "37276.png";
        }

        public static SmallSailKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallSailKit();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SmallFishingNetsKit : WeavingItem
    {
        private static SmallFishingNetsKit? instance = null;
        private static readonly object locker = new object();

        SmallFishingNetsKit()
        {
            id = 37272;
            name = "Small Fishing Nets Kit";
            icon = "37272.png";
        }

        public static SmallFishingNetsKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallFishingNetsKit();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumSailKit : WeavingItem
    {
        private static MediumSailKit? instance = null;
        private static readonly object locker = new object();

        MediumSailKit()
        {
            id = 37257;
            name = "Medium Sail Kit";
            icon = "37257.png";
        }

        public static MediumSailKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumSailKit();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumFishingNetsKit : WeavingItem
    {
        private static MediumFishingNetsKit? instance = null;
        private static readonly object locker = new object();

        MediumFishingNetsKit()
        {
            id = 37253;
            name = "Medium Fishing Nets Kit";
            icon = "37253.png";
        }

        public static MediumFishingNetsKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumFishingNetsKit();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LargeSailKit : WeavingItem
    {
        private static LargeSailKit? instance = null;
        private static readonly object locker = new object();

        LargeSailKit()
        {
            id = 37242;
            name = "Large Sail Kit";
            icon = "37242.png";
        }

        public static LargeSailKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LargeSailKit();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LargeFishingNetsKit : WeavingItem
    {
        private static LargeFishingNetsKit? instance = null;
        private static readonly object locker = new object();

        LargeFishingNetsKit()
        {
            id = 37238;
            name = "Large Fishing Nets Kit";
            icon = "37238.png";
        }

        public static LargeFishingNetsKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LargeFishingNetsKit();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Armors
    public sealed class HideArmor : WeavingItem
    {
        private static HideArmor? instance = null;
        private static readonly object locker = new object();

        HideArmor()
        {
            id = 28634;
            name = "Hide Armor";
            icon = "28634.png";
        }

        public static HideArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new HideArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ShadeclothArmor : WeavingItem
    {
        private static ShadeclothArmor? instance = null;
        private static readonly object locker = new object();

        ShadeclothArmor()
        {
            id = 28589;
            name = "Shadecloth Armor";
            icon = "28589.png";
        }

        public static ShadeclothArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ShadeclothArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class HideHelmet : WeavingItem
    {
        private static HideHelmet? instance = null;
        private static readonly object locker = new object();

        HideHelmet()
        {
            id = 28640;
            name = "Hide Helmet";
            icon = "28640.png";
        }

        public static HideHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new HideHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ShadeclothHelmet : WeavingItem
    {
        private static ShadeclothHelmet? instance = null;
        private static readonly object locker = new object();

        ShadeclothHelmet()
        {
            id = 28595;
            name = "Shadecloth Helmet";
            icon = "28595.png";
        }

        public static ShadeclothHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ShadeclothHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class HideLegs : WeavingItem
    {
        private static HideLegs? instance = null;
        private static readonly object locker = new object();

        HideLegs()
        {
            id = 28641;
            name = "Hide Legs";
            icon = "28641.png";
        }

        public static HideLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new HideLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ShadeclothLegs : WeavingItem
    {
        private static ShadeclothLegs? instance = null;
        private static readonly object locker = new object();

        ShadeclothLegs()
        {
            id = 28596;
            name = "Shadecloth Legs";
            icon = "28596.png";
        }

        public static ShadeclothLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ShadeclothLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class HideBoots : WeavingItem
    {
        private static HideBoots? instance = null;
        private static readonly object locker = new object();

        HideBoots()
        {
            id = 28637;
            name = "Hide Boots";
            icon = "28637.png";
        }

        public static HideBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new HideBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ShadeclothBoots : WeavingItem
    {
        private static ShadeclothBoots? instance = null;
        private static readonly object locker = new object();

        ShadeclothBoots()
        {
            id = 28592;
            name = "Shadecloth Boots";
            icon = "28592.png";
        }

        public static ShadeclothBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ShadeclothBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class NomadArmor : WeavingItem
    {
        private static NomadArmor? instance = null;
        private static readonly object locker = new object();

        NomadArmor()
        {
            id = 28643;
            name = "Nomad Armor";
            icon = "28643.png";
        }

        public static NomadArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new NomadArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ViperArmor : WeavingItem
    {
        private static ViperArmor? instance = null;
        private static readonly object locker = new object();

        ViperArmor()
        {
            id = 28598;
            name = "Viper's Armor";
            icon = "28598.png";
        }

        public static ViperArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ViperArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class NomadHelmet : WeavingItem
    {
        private static NomadHelmet? instance = null;
        private static readonly object locker = new object();

        NomadHelmet()
        {
            id = 28649;
            name = "Nomad Helmet";
            icon = "28649.png";
        }

        public static NomadHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new NomadHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ViperHelmet : WeavingItem
    {
        private static ViperHelmet? instance = null;
        private static readonly object locker = new object();

        ViperHelmet()
        {
            id = 28604;
            name = "Viper's Helmet";
            icon = "28604.png";
        }

        public static ViperHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ViperHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class NomadLegs : WeavingItem
    {
        private static NomadLegs? instance = null;
        private static readonly object locker = new object();

        NomadLegs()
        {
            id = 28650;
            name = "Nomad Legs";
            icon = "28650.png";
        }

        public static NomadLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new NomadLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ViperLegs : WeavingItem
    {
        private static ViperLegs? instance = null;
        private static readonly object locker = new object();

        ViperLegs()
        {
            id = 28605;
            name = "Viper's Legs";
            icon = "28605.png";
        }

        public static ViperLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ViperLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class NomadBoots : WeavingItem
    {
        private static NomadBoots? instance = null;
        private static readonly object locker = new object();

        NomadBoots()
        {
            id = 28646;
            name = "Nomad Boots";
            icon = "28646.png";
        }

        public static NomadBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new NomadBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ViperBoots : WeavingItem
    {
        private static ViperBoots? instance = null;
        private static readonly object locker = new object();

        ViperBoots()
        {
            id = 28601;
            name = "Viper's Boots";
            icon = "28601.png";
        }

        public static ViperBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ViperBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BruiserArmor : WeavingItem
    {
        private static BruiserArmor? instance = null;
        private static readonly object locker = new object();

        BruiserArmor()
        {
            id = 28652;
            name = "Bruiser's Armor";
            icon = "28652.png";
        }

        public static BruiserArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BruiserArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ProfaneArmor : WeavingItem
    {
        private static ProfaneArmor? instance = null;
        private static readonly object locker = new object();

        ProfaneArmor()
        {
            id = 28607;
            name = "Profane Armor";
            icon = "28607.png";
        }

        public static ProfaneArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ProfaneArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BruiserHelmet : WeavingItem
    {
        private static BruiserHelmet? instance = null;
        private static readonly object locker = new object();

        BruiserHelmet()
        {
            id = 28658;
            name = "Bruiser's Helmet";
            icon = "28658.png";
        }

        public static BruiserHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BruiserHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ProfaneHelmet : WeavingItem
    {
        private static ProfaneHelmet? instance = null;
        private static readonly object locker = new object();

        ProfaneHelmet()
        {
            id = 28613;
            name = "Profane Helmet";
            icon = "28613.png";
        }

        public static ProfaneHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ProfaneHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BruiserLegs : WeavingItem
    {
        private static BruiserLegs? instance = null;
        private static readonly object locker = new object();

        BruiserLegs()
        {
            id = 28659;
            name = "Bruiser's Legs";
            icon = "28659.png";
        }

        public static BruiserLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BruiserLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ProfaneLegs : WeavingItem
    {
        private static ProfaneLegs? instance = null;
        private static readonly object locker = new object();

        ProfaneLegs()
        {
            id = 28614;
            name = "Profane Legs";
            icon = "28614.png";
        }

        public static ProfaneLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ProfaneLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BruiserBoots : WeavingItem
    {
        private static BruiserBoots? instance = null;
        private static readonly object locker = new object();

        BruiserBoots()
        {
            id = 28655;
            name = "Bruiser's Boots";
            icon = "28655.png";
        }

        public static BruiserBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BruiserBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ProfaneBoots : WeavingItem
    {
        private static ProfaneBoots? instance = null;
        private static readonly object locker = new object();

        ProfaneBoots()
        {
            id = 28610;
            name = "Profane Boots";
            icon = "28610.png";
        }

        public static ProfaneBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ProfaneBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class OutlawArmor : WeavingItem
    {
        private static OutlawArmor? instance = null;
        private static readonly object locker = new object();

        OutlawArmor()
        {
            id = 28661;
            name = "Outlaw Armor";
            icon = "28661.png";
        }

        public static OutlawArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new OutlawArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CelestialArmor : WeavingItem
    {
        private static CelestialArmor? instance = null;
        private static readonly object locker = new object();

        CelestialArmor()
        {
            id = 28616;
            name = "Celestial Armor";
            icon = "28616.png";
        }

        public static CelestialArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CelestialArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class OutlawHelmet : WeavingItem
    {
        private static OutlawHelmet? instance = null;
        private static readonly object locker = new object();

        OutlawHelmet()
        {
            id = 28667;
            name = "Outlaw Helmet";
            icon = "28667.png";
        }

        public static OutlawHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new OutlawHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CelestialHelmet : WeavingItem
    {
        private static CelestialHelmet? instance = null;
        private static readonly object locker = new object();

        CelestialHelmet()
        {
            id = 28622;
            name = "Celestial Helmet";
            icon = "28622.png";
        }

        public static CelestialHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CelestialHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class OutlawLegs : WeavingItem
    {
        private static OutlawLegs? instance = null;
        private static readonly object locker = new object();

        OutlawLegs()
        {
            id = 28668;
            name = "Outlaw Legs";
            icon = "28668.png";
        }

        public static OutlawLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new OutlawLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CelestialLegs : WeavingItem
    {
        private static CelestialLegs? instance = null;
        private static readonly object locker = new object();

        CelestialLegs()
        {
            id = 28623;
            name = "Celestial Legs";
            icon = "28623.png";
        }

        public static CelestialLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CelestialLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class OutlawBoots : WeavingItem
    {
        private static OutlawBoots? instance = null;
        private static readonly object locker = new object();

        OutlawBoots()
        {
            id = 28664;
            name = "Outlaw Boots";
            icon = "28664.png";
        }

        public static OutlawBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new OutlawBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CelestialBoots : WeavingItem
    {
        private static CelestialBoots? instance = null;
        private static readonly object locker = new object();

        CelestialBoots()
        {
            id = 28619;
            name = "Celestial Boots";
            icon = "28619.png";
        }

        public static CelestialBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CelestialBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class StuddedArmor : WeavingItem
    {
        private static StuddedArmor? instance = null;
        private static readonly object locker = new object();

        StuddedArmor()
        {
            id = 28670;
            name = "Studded Armor";
            icon = "28670.png";
        }

        public static StuddedArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new StuddedArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MysticArmor : WeavingItem
    {
        private static MysticArmor? instance = null;
        private static readonly object locker = new object();

        MysticArmor()
        {
            id = 28632;
            name = "Mystic Armor";
            icon = "28632.png";
        }

        public static MysticArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MysticArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class StuddedHelmet : WeavingItem
    {
        private static StuddedHelmet? instance = null;
        private static readonly object locker = new object();

        StuddedHelmet()
        {
            id = 28677;
            name = "Studded Helmet";
            icon = "28677.png";
        }

        public static StuddedHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new StuddedHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MysticHelmet : WeavingItem
    {
        private static MysticHelmet? instance = null;
        private static readonly object locker = new object();

        MysticHelmet()
        {
            id = 28633;
            name = "Mystic Helmet";
            icon = "28633.png";
        }

        public static MysticHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MysticHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class StuddedLegs : WeavingItem
    {
        private static StuddedLegs? instance = null;
        private static readonly object locker = new object();

        StuddedLegs()
        {
            id = 28675;
            name = "Studded Legs";
            icon = "28675.png";
        }

        public static StuddedLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new StuddedLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MysticLegs : WeavingItem
    {
        private static MysticLegs? instance = null;
        private static readonly object locker = new object();

        MysticLegs()
        {
            id = 28631;
            name = "Mystic Legs";
            icon = "28631.png";
        }

        public static MysticLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MysticLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class StuddedBoots : WeavingItem
    {
        private static StuddedBoots? instance = null;
        private static readonly object locker = new object();

        StuddedBoots()
        {
            id = 28672;
            name = "Studded Boots";
            icon = "28672.png";
        }

        public static StuddedBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new StuddedBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MysticBoots : WeavingItem
    {
        private static MysticBoots? instance = null;
        private static readonly object locker = new object();

        MysticBoots()
        {
            id = 28625;
            name = "Mystic Boots";
            icon = "28625.png";
        }

        public static MysticBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MysticBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class GuerrilaArmor : WeavingItem
    {
        private static GuerrilaArmor? instance = null;
        private static readonly object locker = new object();

        GuerrilaArmor()
        {
            id = 37139;
            name = "Guerrila Armor";
            icon = "37139.png";
        }

        public static GuerrilaArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new GuerrilaArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WarlockArmor : WeavingItem
    {
        private static WarlockArmor? instance = null;
        private static readonly object locker = new object();

        WarlockArmor()
        {
            id = 37126;
            name = "Warlock Armor";
            icon = "37126.png";
        }

        public static WarlockArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WarlockArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class GuerrilaHelmet : WeavingItem
    {
        private static GuerrilaHelmet? instance = null;
        private static readonly object locker = new object();

        GuerrilaHelmet()
        {
            id = 37141;
            name = "Guerrila Helmet";
            icon = "37141.png";
        }

        public static GuerrilaHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new GuerrilaHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WarlockHelmet : WeavingItem
    {
        private static WarlockHelmet? instance = null;
        private static readonly object locker = new object();

        WarlockHelmet()
        {
            id = 37132;
            name = "Warlock Helmet";
            icon = "37132.png";
        }

        public static WarlockHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WarlockHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class GuerrilaLegs : WeavingItem
    {
        private static GuerrilaLegs? instance = null;
        private static readonly object locker = new object();

        GuerrilaLegs()
        {
            id = 37142;
            name = "Guerrila Legs";
            icon = "37142.png";
        }

        public static GuerrilaLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new GuerrilaLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WarlockLegs : WeavingItem
    {
        private static WarlockLegs? instance = null;
        private static readonly object locker = new object();

        WarlockLegs()
        {
            id = 37133;
            name = "Warlock Legs";
            icon = "37133.png";
        }

        public static WarlockLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WarlockLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class GuerrilaBoots : WeavingItem
    {
        private static GuerrilaBoots? instance = null;
        private static readonly object locker = new object();

        GuerrilaBoots()
        {
            id = 37140;
            name = "Guerrila Boots";
            icon = "37140.png";
        }

        public static GuerrilaBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new GuerrilaBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WarlockBoots : WeavingItem
    {
        private static WarlockBoots? instance = null;
        private static readonly object locker = new object();

        WarlockBoots()
        {
            id = 37147;
            name = "Warlock Boots";
            icon = "37147.png";
        }

        public static WarlockBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WarlockBoots();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Crafting
    public sealed class FryCookBoots : WeavingItem
    {
        private static FryCookBoots? instance = null;
        private static readonly object locker = new object();

        FryCookBoots()
        {
            id = 35187;
            name = "Fry Cook Boots";
            icon = "35187.png";
        }

        public static FryCookBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FryCookBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LoomApprenticeBoots : WeavingItem
    {
        private static LoomApprenticeBoots? instance = null;
        private static readonly object locker = new object();

        LoomApprenticeBoots()
        {
            id = 35202;
            name = "Loom Apprentice Boots";
            icon = "35202.png";
        }

        public static LoomApprenticeBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LoomApprenticeBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WorkshopAssistantBoots : WeavingItem
    {
        private static WorkshopAssistantBoots? instance = null;
        private static readonly object locker = new object();

        WorkshopAssistantBoots()
        {
            id = 35172;
            name = "Workshop Assistant Boots";
            icon = "35172.png";
        }

        public static WorkshopAssistantBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WorkshopAssistantBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ApprenticeAnvilBoots : WeavingItem
    {
        private static ApprenticeAnvilBoots? instance = null;
        private static readonly object locker = new object();

        ApprenticeAnvilBoots()
        {
            id = 35157;
            name = "Apprentice Anvil Boots";
            icon = "35157.png";
        }

        public static ApprenticeAnvilBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ApprenticeAnvilBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class FryCookLegs : WeavingItem
    {
        private static FryCookLegs? instance = null;
        private static readonly object locker = new object();

        FryCookLegs()
        {
            id = 35190;
            name = "Fry Cook Legs";
            icon = "35190.png";
        }

        public static FryCookLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FryCookLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LoomApprenticeLegs : WeavingItem
    {
        private static LoomApprenticeLegs? instance = null;
        private static readonly object locker = new object();

        LoomApprenticeLegs()
        {
            id = 35205;
            name = "Loom Apprentice Legs";
            icon = "35205.png";
        }

        public static LoomApprenticeLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LoomApprenticeLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WorkshopAssistantLegs : WeavingItem
    {
        private static WorkshopAssistantLegs? instance = null;
        private static readonly object locker = new object();

        WorkshopAssistantLegs()
        {
            id = 35175;
            name = "Workshop Assistant Legs";
            icon = "35175.png";
        }

        public static WorkshopAssistantLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WorkshopAssistantLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ApprenticeAnvilLegs : WeavingItem
    {
        private static ApprenticeAnvilLegs? instance = null;
        private static readonly object locker = new object();

        ApprenticeAnvilLegs()
        {
            id = 35160;
            name = "Apprentice Anvil Legs";
            icon = "35160.png";
        }

        public static ApprenticeAnvilLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ApprenticeAnvilLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class FryCookArmor : WeavingItem
    {
        private static FryCookArmor? instance = null;
        private static readonly object locker = new object();

        FryCookArmor()
        {
            id = 35186;
            name = "Fry Cook Armor";
            icon = "35186.png";
        }

        public static FryCookArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FryCookArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LoomApprenticeArmor : WeavingItem
    {
        private static LoomApprenticeArmor? instance = null;
        private static readonly object locker = new object();

        LoomApprenticeArmor()
        {
            id = 35201;
            name = "Loom Apprentice Armor";
            icon = "35201.png";
        }

        public static LoomApprenticeArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LoomApprenticeArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WorkshopAssistantArmor : WeavingItem
    {
        private static WorkshopAssistantArmor? instance = null;
        private static readonly object locker = new object();

        WorkshopAssistantArmor()
        {
            id = 35171;
            name = "Workshop Assistant Armor";
            icon = "35171.png";
        }

        public static WorkshopAssistantArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WorkshopAssistantArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ApprenticeAnvilArmor : WeavingItem
    {
        private static ApprenticeAnvilArmor? instance = null;
        private static readonly object locker = new object();

        ApprenticeAnvilArmor()
        {
            id = 35156;
            name = "Apprentice Anvil Armor";
            icon = "35156.png";
        }

        public static ApprenticeAnvilArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ApprenticeAnvilArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class FryCookHelmet : WeavingItem
    {
        private static FryCookHelmet? instance = null;
        private static readonly object locker = new object();

        FryCookHelmet()
        {
            id = 35189;
            name = "Fry Cook Helmet";
            icon = "35189.png";
        }

        public static FryCookHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FryCookHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LoomApprenticeHelmet : WeavingItem
    {
        private static LoomApprenticeHelmet? instance = null;
        private static readonly object locker = new object();

        LoomApprenticeHelmet()
        {
            id = 35204;
            name = "Loom Apprentice Helmet";
            icon = "35204.png";
        }

        public static LoomApprenticeHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LoomApprenticeHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WorkshopAssistantHelmet : WeavingItem
    {
        private static WorkshopAssistantHelmet? instance = null;
        private static readonly object locker = new object();

        WorkshopAssistantHelmet()
        {
            id = 35174;
            name = "Workshop Assistant Helmet";
            icon = "35174.png";
        }

        public static WorkshopAssistantHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WorkshopAssistantHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ApprenticeAnvilHelmet : WeavingItem
    {
        private static ApprenticeAnvilHelmet? instance = null;
        private static readonly object locker = new object();

        ApprenticeAnvilHelmet()
        {
            id = 35159;
            name = "Apprentice Anvil Helmet";
            icon = "35159.png";
        }

        public static ApprenticeAnvilHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ApprenticeAnvilHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class FryCookBracers : WeavingItem
    {
        private static FryCookBracers? instance = null;
        private static readonly object locker = new object();

        FryCookBracers()
        {
            id = 35188;
            name = "Fry Cook Bracers";
            icon = "35188.png";
        }

        public static FryCookBracers Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FryCookBracers();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LoomApprenticeGloves : WeavingItem
    {
        private static LoomApprenticeGloves? instance = null;
        private static readonly object locker = new object();

        LoomApprenticeGloves()
        {
            id = 35203;
            name = "Loom Apprentice Gloves";
            icon = "35203.png";
        }

        public static LoomApprenticeGloves Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LoomApprenticeGloves();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WorkshopAssistantGloves : WeavingItem
    {
        private static WorkshopAssistantGloves? instance = null;
        private static readonly object locker = new object();

        WorkshopAssistantGloves()
        {
            id = 35173;
            name = "Workshop Assistant Gloves";
            icon = "35173.png";
        }

        public static WorkshopAssistantGloves Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WorkshopAssistantGloves();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ApprenticeAnvilBracers : WeavingItem
    {
        private static ApprenticeAnvilBracers? instance = null;
        private static readonly object locker = new object();

        ApprenticeAnvilBracers()
        {
            id = 35158;
            name = "Apprentice Anvil Bracers";
            icon = "35158.png";
        }

        public static ApprenticeAnvilBracers Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ApprenticeAnvilBracers();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SousChefBoots : WeavingItem
    {
        private static SousChefBoots? instance = null;
        private static readonly object locker = new object();

        SousChefBoots()
        {
            id = 35192;
            name = "Sous Chef Boots";
            icon = "35192.png";
        }

        public static SousChefBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SousChefBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ThreadspinnerBoots : WeavingItem
    {
        private static ThreadspinnerBoots? instance = null;
        private static readonly object locker = new object();

        ThreadspinnerBoots()
        {
            id = 35207;
            name = "Threadspinner Boots";
            icon = "35207.png";
        }

        public static ThreadspinnerBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ThreadspinnerBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WoodworkerBoots : WeavingItem
    {
        private static WoodworkerBoots? instance = null;
        private static readonly object locker = new object();

        WoodworkerBoots()
        {
            id = 35177;
            name = "Woodworker Boots";
            icon = "35177.png";
        }

        public static WoodworkerBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WoodworkerBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SilversmithBoots : WeavingItem
    {
        private static SilversmithBoots? instance = null;
        private static readonly object locker = new object();

        SilversmithBoots()
        {
            id = 35162;
            name = "Silversmith Boots";
            icon = "35162.png";
        }

        public static SilversmithBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SilversmithBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SousChefLegs : WeavingItem
    {
        private static SousChefLegs? instance = null;
        private static readonly object locker = new object();

        SousChefLegs()
        {
            id = 35195;
            name = "Sous Chef Legs";
            icon = "35195.png";
        }

        public static SousChefLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SousChefLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ThreadspinnerLegs : WeavingItem
    {
        private static ThreadspinnerLegs? instance = null;
        private static readonly object locker = new object();

        ThreadspinnerLegs()
        {
            id = 35210;
            name = "Threadspinner Legs";
            icon = "35210.png";
        }

        public static ThreadspinnerLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ThreadspinnerLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WoodworkerLegs : WeavingItem
    {
        private static WoodworkerLegs? instance = null;
        private static readonly object locker = new object();

        WoodworkerLegs()
        {
            id = 35180;
            name = "Woodworker Legs";
            icon = "35180.png";
        }

        public static WoodworkerLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WoodworkerLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SilversmithLegs : WeavingItem
    {
        private static SilversmithLegs? instance = null;
        private static readonly object locker = new object();

        SilversmithLegs()
        {
            id = 35165;
            name = "Silversmith Legs";
            icon = "35165.png";
        }

        public static SilversmithLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SilversmithLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SousChefArmor : WeavingItem
    {
        private static SousChefArmor? instance = null;
        private static readonly object locker = new object();

        SousChefArmor()
        {
            id = 35191;
            name = "Sous Chef Armor";
            icon = "35191.png";
        }

        public static SousChefArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SousChefArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ThreadspinnerArmor : WeavingItem
    {
        private static ThreadspinnerArmor? instance = null;
        private static readonly object locker = new object();

        ThreadspinnerArmor()
        {
            id = 35206;
            name = "Threadspinner Armor";
            icon = "35206.png";
        }

        public static ThreadspinnerArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ThreadspinnerArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WoodworkerArmor : WeavingItem
    {
        private static WoodworkerArmor? instance = null;
        private static readonly object locker = new object();

        WoodworkerArmor()
        {
            id = 35176;
            name = "Woodworker Armor";
            icon = "35176.png";
        }

        public static WoodworkerArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WoodworkerArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SilversmithArmor : WeavingItem
    {
        private static SilversmithArmor? instance = null;
        private static readonly object locker = new object();

        SilversmithArmor()
        {
            id = 35161;
            name = "Silversmith Armor";
            icon = "35161.png";
        }

        public static SilversmithArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SilversmithArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SousChefHelmet : WeavingItem
    {
        private static SousChefHelmet? instance = null;
        private static readonly object locker = new object();

        SousChefHelmet()
        {
            id = 35194;
            name = "Sous Chef Helmet";
            icon = "35194.png";
        }

        public static SousChefHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SousChefHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ThreadspinnerHelmet : WeavingItem
    {
        private static ThreadspinnerHelmet? instance = null;
        private static readonly object locker = new object();

        ThreadspinnerHelmet()
        {
            id = 35209;
            name = "Threadspinner Helmet";
            icon = "35209.png";
        }

        public static ThreadspinnerHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ThreadspinnerHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WoodworkerHelmet : WeavingItem
    {
        private static WoodworkerHelmet? instance = null;
        private static readonly object locker = new object();

        WoodworkerHelmet()
        {
            id = 35179;
            name = "Woodworker Helmet";
            icon = "35179.png";
        }

        public static WoodworkerHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WoodworkerHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SilversmithHelmet : WeavingItem
    {
        private static SilversmithHelmet? instance = null;
        private static readonly object locker = new object();

        SilversmithHelmet()
        {
            id = 35164;
            name = "Silversmith Helmet";
            icon = "35164.png";
        }

        public static SilversmithHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SilversmithHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SousChefBracers : WeavingItem
    {
        private static SousChefBracers? instance = null;
        private static readonly object locker = new object();

        SousChefBracers()
        {
            id = 35193;
            name = "Sous Chef Bracers";
            icon = "35193.png";
        }

        public static SousChefBracers Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SousChefBracers();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ThreadspinnerGloves : WeavingItem
    {
        private static ThreadspinnerGloves? instance = null;
        private static readonly object locker = new object();

        ThreadspinnerGloves()
        {
            id = 35208;
            name = "Threadspinner Gloves";
            icon = "35208.png";
        }

        public static ThreadspinnerGloves Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ThreadspinnerGloves();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WoodworkerGloves : WeavingItem
    {
        private static WoodworkerGloves? instance = null;
        private static readonly object locker = new object();

        WoodworkerGloves()
        {
            id = 35178;
            name = "Woodworker Gloves";
            icon = "35178.png";
        }

        public static WoodworkerGloves Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WoodworkerGloves();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SilversmithBracers : WeavingItem
    {
        private static SilversmithBracers? instance = null;
        private static readonly object locker = new object();

        SilversmithBracers()
        {
            id = 35163;
            name = "Silversmith Bracers";
            icon = "35163.png";
        }

        public static SilversmithBracers Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SilversmithBracers();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MasterOfCuisineBoots : WeavingItem
    {
        private static MasterOfCuisineBoots? instance = null;
        private static readonly object locker = new object();

        MasterOfCuisineBoots()
        {
            id = 35197;
            name = "Master of Cuisine Boots";
            icon = "35197.png";
        }

        public static MasterOfCuisineBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MasterOfCuisineBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MasterTailorBoots : WeavingItem
    {
        private static MasterTailorBoots? instance = null;
        private static readonly object locker = new object();

        MasterTailorBoots()
        {
            id = 35212;
            name = "Master Tailor Boots";
            icon = "35212.png";
        }

        public static MasterTailorBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MasterTailorBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MasterMasonBoots : WeavingItem
    {
        private static MasterMasonBoots? instance = null;
        private static readonly object locker = new object();

        MasterMasonBoots()
        {
            id = 35182;
            name = "Master Mason Boots";
            icon = "35182.png";
        }

        public static MasterMasonBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MasterMasonBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ForgemasterBoots : WeavingItem
    {
        private static ForgemasterBoots? instance = null;
        private static readonly object locker = new object();

        ForgemasterBoots()
        {
            id = 35167;
            name = "Forgemaster Boots";
            icon = "35167.png";
        }

        public static ForgemasterBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ForgemasterBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MasterOfCuisineLegs : WeavingItem
    {
        private static MasterOfCuisineLegs? instance = null;
        private static readonly object locker = new object();

        MasterOfCuisineLegs()
        {
            id = 35200;
            name = "Master of Cuisine Legs";
            icon = "35200.png";
        }

        public static MasterOfCuisineLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MasterOfCuisineLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MasterTailorLegs : WeavingItem
    {
        private static MasterTailorLegs? instance = null;
        private static readonly object locker = new object();

        MasterTailorLegs()
        {
            id = 35215;
            name = "Master Tailor Legs";
            icon = "35215.png";
        }

        public static MasterTailorLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MasterTailorLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MasterMasonLegs : WeavingItem
    {
        private static MasterMasonLegs? instance = null;
        private static readonly object locker = new object();

        MasterMasonLegs()
        {
            id = 35185;
            name = "Master Mason Legs";
            icon = "35185.png";
        }

        public static MasterMasonLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MasterMasonLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ForgemasterLegs : WeavingItem
    {
        private static ForgemasterLegs? instance = null;
        private static readonly object locker = new object();

        ForgemasterLegs()
        {
            id = 35170;
            name = "Forgemaster Legs";
            icon = "35170.png";
        }

        public static ForgemasterLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ForgemasterLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MasterOfCuisineArmor : WeavingItem
    {
        private static MasterOfCuisineArmor? instance = null;
        private static readonly object locker = new object();

        MasterOfCuisineArmor()
        {
            id = 35196;
            name = "Master Of Cuisine Armor";
            icon = "35196.png";
        }

        public static MasterOfCuisineArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MasterOfCuisineArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MasterTailorArmor : WeavingItem
    {
        private static MasterTailorArmor? instance = null;
        private static readonly object locker = new object();

        MasterTailorArmor()
        {
            id = 35211;
            name = "Master Tailor Armor";
            icon = "35211.png";
        }

        public static MasterTailorArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MasterTailorArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MasterMasonArmor : WeavingItem
    {
        private static MasterMasonArmor? instance = null;
        private static readonly object locker = new object();

        MasterMasonArmor()
        {
            id = 35181;
            name = "Master Mason Armor";
            icon = "35181.png";
        }

        public static MasterMasonArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MasterMasonArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ForgemasterArmor : WeavingItem
    {
        private static ForgemasterArmor? instance = null;
        private static readonly object locker = new object();

        ForgemasterArmor()
        {
            id = 35166;
            name = "Forgemaster Armor";
            icon = "35166.png";
        }

        public static ForgemasterArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ForgemasterArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MasterOfCuisineHelmet : WeavingItem
    {
        private static MasterOfCuisineHelmet? instance = null;
        private static readonly object locker = new object();

        MasterOfCuisineHelmet()
        {
            id = 35199;
            name = "Master of Cuisine Helmet";
            icon = "35199.png";
        }

        public static MasterOfCuisineHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MasterOfCuisineHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MasterTailorHelmet : WeavingItem
    {
        private static MasterTailorHelmet? instance = null;
        private static readonly object locker = new object();

        MasterTailorHelmet()
        {
            id = 35214;
            name = "Master Tailor Helmet";
            icon = "35214.png";
        }

        public static MasterTailorHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MasterTailorHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MasterMasonHelmet : WeavingItem
    {
        private static MasterMasonHelmet? instance = null;
        private static readonly object locker = new object();

        MasterMasonHelmet()
        {
            id = 35184;
            name = "Master Mason Helmet";
            icon = "35184.png";
        }

        public static MasterMasonHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MasterMasonHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ForgemasterHelmet : WeavingItem
    {
        private static ForgemasterHelmet? instance = null;
        private static readonly object locker = new object();

        ForgemasterHelmet()
        {
            id = 35169;
            name = "Forgemaster Helmet";
            icon = "35169.png";
        }

        public static ForgemasterHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ForgemasterHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MasterOfCuisineBracers : WeavingItem
    {
        private static MasterOfCuisineBracers? instance = null;
        private static readonly object locker = new object();

        MasterOfCuisineBracers()
        {
            id = 35198;
            name = "Master of Cuisine Bracers";
            icon = "35198.png";
        }

        public static MasterOfCuisineBracers Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MasterOfCuisineBracers();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MasterTailorBracers : WeavingItem
    {
        private static MasterTailorBracers? instance = null;
        private static readonly object locker = new object();

        MasterTailorBracers()
        {
            id = 35213;
            name = "Master Tailor Bracers";
            icon = "35213.png";
        }

        public static MasterTailorBracers Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MasterTailorBracers();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MasterMasonGloves : WeavingItem
    {
        private static MasterMasonGloves? instance = null;
        private static readonly object locker = new object();

        MasterMasonGloves()
        {
            id = 35183;
            name = "Master Mason Gloves";
            icon = "35183.png";
        }

        public static MasterMasonGloves Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MasterMasonGloves();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ForgemasterBracers : WeavingItem
    {
        private static ForgemasterBracers? instance = null;
        private static readonly object locker = new object();

        ForgemasterBracers()
        {
            id = 35168;
            name = "Forgemaster Bracers";
            icon = "35168.png";
        }

        public static ForgemasterBracers Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ForgemasterBracers();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion
}
