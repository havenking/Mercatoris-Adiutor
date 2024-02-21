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
            name = "Simple Cloth";
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
            name = "Craftman's Cloth";
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
            name = "Silk";
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
            name = "Merchant's Cloth";
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
            name = "Artisan Cloth";
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
            name = "Coarse Leather";
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
            name = "Craftman's Leather";
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
            name = "Tanned Leather";
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
            name = "Merchant's Leather";
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
            name = "Artisan Leather";
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
            name = "Coarse Thread";
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
            name = "Craftman's Thread";
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
            name = "Fine Thread";
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
            name = "Merchant's Thread";
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
            name = "Artisan Thread";
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
            name = "Cheap Rug";
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
            name = "Carpet";
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
            name = "Thread Spool";
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
            name = "Cloth Roll";
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
            name = "Luxury Carpet";
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
            name = "Luxury Thread Spool";
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
            name = "Refined Cloth Roll";
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
            name = "Luxury Cloth Roll";
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
            name = "Simple Saddle";
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
            name = "Composed Saddle";
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
            name = "Advanced Saddle";
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
            name = "Artisan Saddle";
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
            name = "Superior Saddle";
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
            name = "War Saddle";
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
            name = "Professional Saddle";
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
            name = "Explorer Saddle";
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
            name = "Small Sail Kit";
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
            name = "Small Fishing Nets Kit";
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
            name = "Medium Sail Kit";
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
            name = "Medium Fishing Nets Kit";
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
            name = "Large Sail Kit";
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
            name = "Large Fishing Nets Kit";
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
            name = "Hide Armor";
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
            name = "Shadecloth Armor";
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
            name = "Hide Helmet";
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
            name = "Shadecloth Helmet";
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
            name = "Hide Legs";
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
            name = "Shadecloth Legs";
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
            name = "Hide Boots";
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
            name = "Shadecloth Boots";
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
            name = "Nomad Armor";
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
            name = "Viper's Armor";
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
            name = "Nomad Helmet";
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
            name = "Viper's Helmet";
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
            name = "Nomad Legs";
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
            name = "Viper's Legs";
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
            name = "Nomad Boots";
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
            name = "Viper's Boots";
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
            name = "Bruiser's Armor";
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
            name = "Profane Armor";
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
            name = "Bruiser's Helmet";
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
            name = "Profane Helmet";
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
            name = "Bruiser's Legs";
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
            name = "Profane Legs";
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
            name = "Bruiser's Boots";
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
            name = "Profane Boots";
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
            name = "Outlaw Armor";
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
            name = "Celestial Armor";
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
            name = "Outlaw Helmet";
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
            name = "Celestial Helmet";
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
            name = "Outlaw Legs";
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
            name = "Celestial Legs";
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
            name = "Outlaw Boots";
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
            name = "Celestial Boots";
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
            name = "Studded Armor";
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
            name = "Mystic Armor";
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
            name = "Studded Helmet";
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
            name = "Mystic Helmet";
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
            name = "Studded Legs";
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
            name = "Mystic Legs";
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
            name = "Studded Boots";
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
            name = "Mystic Boots";
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
            name = "Guerrila Armor";
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
            name = "Warlock Armor";
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
            name = "Guerrila Helmet";
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
            name = "Warlock Helmet";
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
            name = "Guerrila Legs";
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
            name = "Warlock Legs";
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
            name = "Guerrila Boots";
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
            name = "Warlock Boots";
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
            name = "Fry Cook Boots";
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
            name = "Loom Apprentice Boots";
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
            name = "Workshop Assistant Boots";
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
            name = "Apprentice Anvil Boots";
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
            name = "Fry Cook Legs";
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
            name = "Loom Apprentice Legs";
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
            name = "Workshop Assistant Legs";
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
            name = "Apprentice Anvil Legs";
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
            name = "Fry Cook Armor";
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
            name = "Loom Apprentice Armor";
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
            name = "Workshop Assistant Armor";
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
            name = "Apprentice Anvil Armor";
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
            name = "Fry Cook Helmet";
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
            name = "Loom Apprentice Helmet";
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
            name = "Workshop Assistant Helmet";
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
            name = "Apprentice Anvil Helmet";
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
            name = "Fry Cook Bracers";
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
            name = "Loom Apprentice Gloves";
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
            name = "Workshop Assistant Gloves";
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
            name = "Apprentice Anvil Bracers";
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
            name = "Sous Chef Boots";
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
            name = "Threadspinner Boots";
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
            name = "Woodworker Boots";
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
            name = "Silversmith Boots";
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
            name = "Sous Chef Legs";
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
            name = "Threadspinner Legs";
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
            name = "Woodworker Legs";
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
            name = "Silversmith Legs";
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
            name = "Sous Chef Armor";
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
            name = "Threadspinner Armor";
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
            name = "Woodworker Armor";
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
            name = "Silversmith Armor";
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
            name = "Sous Chef Helmet";
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
            name = "Threadspinner Helmet";
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
            name = "Woodworker Helmet";
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
            name = "Silversmith Helmet";
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
            name = "Sous Chef Bracers";
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
            name = "Threadspinner Gloves";
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
            name = "Woodworker Gloves";
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
            name = "Silversmith Bracers";
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
            name = "Master Of Cuisine Boots";
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
            name = "Master Tailor Boots";
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
            name = "Master Mason Boots";
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
            name = "Forgemaster Boots";
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
            name = "Master Of Cuisine Legs";
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
            name = "Master Tailor Legs";
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
            name = "Master Mason Legs";
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
            name = "Forgemaster Legs";
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
            name = "Master Of Cuisine Armor";
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
            name = "Master Tailor Armor";
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
            name = "Master Mason Armor";
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
            name = "Forgemaster Armor";
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
            name = "Master Of Cuisine Helmet";
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
            name = "Master Tailor Helmet";
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
            name = "Master Mason Helmet";
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
            name = "Forgemaster Helmet";
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
            name = "Master Of Cuisine Bracers";
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
            name = "Master Tailor Bracers";
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
            name = "Master Mason Gloves";
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
            name = "Forgemaster Bracers";
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
