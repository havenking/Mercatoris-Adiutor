namespace MercatorisAdiutor.Model.Carpentry.Items
{
    public abstract class CarpentryItem : Item
    {
        internal int id = -1;
        internal string name = string.Empty;
        internal string icon = string.Empty;
        internal string description = string.Empty;
        internal int price = 0;

        public int Id => id;

        public string Name => name;

        public string Icon => icon;

        public Profession Profession => Profession.Carpentry;

        public Category Category => Category.Crafting;

        public int Price 
        {
            get { return price; }
            set { price = value; }
        }
    }

    #region Planks
    public sealed class DensePlank : CarpentryItem
    {
        private static DensePlank? instance = null;
        private static readonly object locker = new object();

        DensePlank() 
        {
            name = "Dense Plank";
        }

        public static DensePlank Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new DensePlank();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class RoughPlank : CarpentryItem
    {
        private static RoughPlank? instance = null;
        private static readonly object locker = new object();

        RoughPlank()
        {
            id = 0;
            name = "Rough Plank";
            icon = "generic.png";
        }

        public static RoughPlank Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RoughPlank();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class RefinedPlank : CarpentryItem
    {
        private static RefinedPlank? instance = null;
        private static readonly object locker = new object();

        RefinedPlank()
        {
            id = 0;
            name = "Refined Plank";
            icon = "generic.png";
        }

        public static RefinedPlank Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RefinedPlank();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class TreatedPlank : CarpentryItem
    {
        private static TreatedPlank? instance = null;
        private static readonly object locker = new object();

        TreatedPlank()
        {
            id = 0;
            name = "Treated Plank";
            icon = "generic.png";
        }

        public static TreatedPlank Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new TreatedPlank();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class HeavyPlank : CarpentryItem
    {
        private static HeavyPlank? instance = null;
        private static readonly object locker = new object();

        HeavyPlank()
        {
            id = 0;
            name = "Heavy Plank";
            icon = "generic.png";
        }

        public static HeavyPlank Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new HeavyPlank();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SturdyPlank : CarpentryItem
    {
        private static SturdyPlank? instance = null;
        private static readonly object locker = new object();

        SturdyPlank()
        {
            id = 0;
            name = "Sturdy Plank";
            icon = "generic.png";
        }

        public static SturdyPlank Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SturdyPlank();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class FinePlank : CarpentryItem
    {
        private static FinePlank? instance = null;
        private static readonly object locker = new object();

        FinePlank()
        {
            id = 0;
            name = "Fine Plank";
            icon = "generic.png";
        }

        public static FinePlank Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FinePlank();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Weapons
    #region Tier1
    public sealed class WoodenBulwark : CarpentryItem
    {
        private static WoodenBulwark? instance = null;
        private static readonly object locker = new object();

        WoodenBulwark()
        {
            id = 0;
            name = "Wooden Bulwark";
            icon = "generic.png";
        }

        public static WoodenBulwark Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WoodenBulwark();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MysticStaff : CarpentryItem
    {
        private static MysticStaff? instance = null;
        private static readonly object locker = new object();

        MysticStaff()
        {
            id = 0;
            name = "Mystic Staff";
            icon = "generic.png";
        }

        public static MysticStaff Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MysticStaff();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class OakWoodBow : CarpentryItem
    {
        private static OakWoodBow? instance = null;
        private static readonly object locker = new object();

        OakWoodBow()
        {
            id = 0;
            name = "OakWood Bow";
            icon = "generic.png";
        }

        public static OakWoodBow Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new OakWoodBow();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WoodenBuckler : CarpentryItem
    {
        private static WoodenBuckler? instance = null;
        private static readonly object locker = new object();

        WoodenBuckler()
        {
            id = 0;
            name = "Wooden Buckler";
            icon = "generic.png";
        }

        public static WoodenBuckler Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WoodenBuckler();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class KnottedSceptre : CarpentryItem
    {
        private static KnottedSceptre? instance = null;
        private static readonly object locker = new object();

        KnottedSceptre()
        {
            id = 0;
            name = "Knotted Sceptre";
            icon = "generic.png";
        }

        public static KnottedSceptre Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new KnottedSceptre();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Tier2
    public sealed class SentinelShield : CarpentryItem
    {
        private static SentinelShield? instance = null;
        private static readonly object locker = new object();

        SentinelShield()
        {
            id = 0;
            name = "Sentinel Shield";
            icon = "generic.png";
        }

        public static SentinelShield Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SentinelShield();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SturdyBuckler : CarpentryItem
    {
        private static SturdyBuckler? instance = null;
        private static readonly object locker = new object();

        SturdyBuckler()
        {
            id = 0;
            name = "Sturdy Buckler";
            icon = "generic.png";
        }

        public static SturdyBuckler Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SturdyBuckler();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class TribalSceptre : CarpentryItem
    {
        private static TribalSceptre? instance = null;
        private static readonly object locker = new object();

        TribalSceptre()
        {
            id = 0;
            name = "Tribal Sceptre";
            icon = "generic.png";
        }

        public static TribalSceptre Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new TribalSceptre();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ViperBow : CarpentryItem
    {
        private static ViperBow? instance = null;
        private static readonly object locker = new object();

        ViperBow()
        {
            id = 0;
            name = "Viper's Bow";
            icon = "generic.png";
        }

        public static ViperBow Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ViperBow();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WarlockStaff : CarpentryItem
    {
        private static WarlockStaff? instance = null;
        private static readonly object locker = new object();

        WarlockStaff()
        {
            id = 0;
            name = "Warlock Staff";
            icon = "generic.png";
        }

        public static WarlockStaff Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WarlockStaff();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Tier3
    public sealed class SerpentSceptre : CarpentryItem
    {
        private static SerpentSceptre? instance = null;
        private static readonly object locker = new object();

        SerpentSceptre()
        {
            id = 0;
            name = "Serpent Sceptre";
            icon = "generic.png";
        }

        public static SerpentSceptre Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SerpentSceptre();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class DefenderBulwark : CarpentryItem
    {
        private static DefenderBulwark? instance = null;
        private static readonly object locker = new object();

        DefenderBulwark()
        {
            id = 0;
            name = "Defender's Bulwark";
            icon = "generic.png";
        }

        public static DefenderBulwark Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new DefenderBulwark();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CultistStaff : CarpentryItem
    {
        private static CultistStaff? instance = null;
        private static readonly object locker = new object();

        CultistStaff()
        {
            id = 0;
            name = "Cultist Staff";
            icon = "generic.png";
        }

        public static CultistStaff Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CultistStaff();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MarauderShield : CarpentryItem
    {
        private static MarauderShield? instance = null;
        private static readonly object locker = new object();

        MarauderShield()
        {
            id = 0;
            name = "Marauder's Shield";
            icon = "generic.png";
        }

        public static MarauderShield Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MarauderShield();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BlackAshBow : CarpentryItem
    {
        private static BlackAshBow? instance = null;
        private static readonly object locker = new object();

        BlackAshBow()
        {
            id = 0;
            name = "Black Ash Bow";
            icon = "generic.png";
        }

        public static BlackAshBow Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BlackAshBow();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Tier4
    public sealed class CrystalSceptre : CarpentryItem
    {
        private static CrystalSceptre? instance = null;
        private static readonly object locker = new object();

        CrystalSceptre()
        {
            id = 0;
            name = "Crystal Sceptre";
            icon = "generic.png";
        }

        public static CrystalSceptre Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CrystalSceptre();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CelestialStaff : CarpentryItem
    {
        private static CelestialStaff? instance = null;
        private static readonly object locker = new object();

        CelestialStaff()
        {
            id = 0;
            name = "Celestial Staff";
            icon = "generic.png";
        }

        public static CelestialStaff Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CelestialStaff();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class RuneShield : CarpentryItem
    {
        private static RuneShield? instance = null;
        private static readonly object locker = new object();

        RuneShield()
        {
            id = 0;
            name = "Rune Shield";
            icon = "generic.png";
        }

        public static RuneShield Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RuneShield();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SteelcladBulwark : CarpentryItem
    {
        private static SteelcladBulwark? instance = null;
        private static readonly object locker = new object();

        SteelcladBulwark()
        {
            id = 0;
            name = "Steelclad Bulwark";
            icon = "generic.png";
        }

        public static SteelcladBulwark Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SteelcladBulwark();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BullseyeBow : CarpentryItem
    {
        private static BullseyeBow? instance = null;
        private static readonly object locker = new object();

        BullseyeBow()
        {
            id = 0;
            name = "Bullseye Bow";
            icon = "generic.png";
        }

        public static BullseyeBow Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BullseyeBow();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Tier5
    public sealed class RavenguardShield : CarpentryItem
    {
        private static RavenguardShield? instance = null;
        private static readonly object locker = new object();

        RavenguardShield()
        {
            id = 0;
            name = "Ravenguard's Shield";
            icon = "generic.png";
        }

        public static RavenguardShield Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RavenguardShield();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class KingDefender : CarpentryItem
    {
        private static KingDefender? instance = null;
        private static readonly object locker = new object();

        KingDefender()
        {
            id = 0;
            name = "King's Defender";
            icon = "generic.png";
        }

        public static KingDefender Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new KingDefender();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CelestialSceptre : CarpentryItem
    {
        private static CelestialSceptre? instance = null;
        private static readonly object locker = new object();

        CelestialSceptre()
        {
            id = 0;
            name = "Celestial Sceptre";
            icon = "generic.png";
        }

        public static CelestialSceptre Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CelestialSceptre();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class PredatorBow : CarpentryItem
    {
        private static PredatorBow? instance = null;
        private static readonly object locker = new object();

        PredatorBow()
        {
            id = 0;
            name = "Predator Bow";
            icon = "generic.png";
        }

        public static PredatorBow Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new PredatorBow();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LightshardStaff : CarpentryItem
    {
        private static LightshardStaff? instance = null;
        private static readonly object locker = new object();

        LightshardStaff()
        {
            id = 0;
            name = "Lightshard Staff";
            icon = "generic.png";
        }

        public static LightshardStaff Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LightshardStaff();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Tier6
    public sealed class ProtectorTowerShield : CarpentryItem
    {
        private static ProtectorTowerShield? instance = null;
        private static readonly object locker = new object();

        ProtectorTowerShield()
        {
            id = 0;
            name = "Protector's Tower Shield";
            icon = "generic.png";
        }

        public static ProtectorTowerShield Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ProtectorTowerShield();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class NecromancerStaff : CarpentryItem
    {
        private static NecromancerStaff? instance = null;
        private static readonly object locker = new object();

        NecromancerStaff()
        {
            id = 0;
            name = "Necromancer Staff";
            icon = "generic.png";
        }

        public static NecromancerStaff Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new NecromancerStaff();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MarksmanBow : CarpentryItem
    {
        private static MarksmanBow? instance = null;
        private static readonly object locker = new object();

        MarksmanBow()
        {
            id = 0;
            name = "Marksman Bow";
            icon = "generic.png";
        }

        public static MarksmanBow Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MarksmanBow();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CrowboneSceptre : CarpentryItem
    {
        private static CrowboneSceptre? instance = null;
        private static readonly object locker = new object();

        CrowboneSceptre()
        {
            id = 0;
            name = "Crowbone Sceptre";
            icon = "generic.png";
        }

        public static CrowboneSceptre Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CrowboneSceptre();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class NocturnalShield : CarpentryItem
    {
        private static NocturnalShield? instance = null;
        private static readonly object locker = new object();

        NocturnalShield()
        {
            id = 0;
            name = "Nocturnal Shield";
            icon = "generic.png";
        }

        public static NocturnalShield Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new NocturnalShield();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion
    #endregion

    #region Fishing
    public sealed class FishingStick : CarpentryItem
    {
        private static FishingStick? instance = null;
        private static readonly object locker = new object();

        FishingStick()
        {
            id = 0;
            name = "Fishing Stick";
            icon = "generic.png";
        }

        public static FishingStick Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FishingStick();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class FishingRod : CarpentryItem
    {
        private static FishingRod? instance = null;
        private static readonly object locker = new object();

        FishingRod()
        {
            id = 0;
            name = "Fishing Rod";
            icon = "generic.png";
        }

        public static FishingRod Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FishingRod();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CraftmanFishingRod : CarpentryItem
    {
        private static CraftmanFishingRod? instance = null;
        private static readonly object locker = new object();

        CraftmanFishingRod()
        {
            id = 0;
            name = "Craftman's Fishing Rod";
            icon = "generic.png";
        }

        public static CraftmanFishingRod Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CraftmanFishingRod();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SailorFishingRod : CarpentryItem
    {
        private static SailorFishingRod? instance = null;
        private static readonly object locker = new object();

        SailorFishingRod()
        {
            id = 0;
            name = "Sailor's Fishing Rod";
            icon = "generic.png";
        }

        public static SailorFishingRod Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SailorFishingRod();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ArtisanFishingRod : CarpentryItem
    {
        private static ArtisanFishingRod? instance = null;
        private static readonly object locker = new object();

        ArtisanFishingRod()
        {
            id = 0;
            name = "Artisan Fishing Rod";
            icon = "generic.png";
        }

        public static ArtisanFishingRod Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ArtisanFishingRod();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LightwoodAngler : CarpentryItem
    {
        private static LightwoodAngler? instance = null;
        private static readonly object locker = new object();

        LightwoodAngler()
        {
            id = 0;
            name = "Lightwood Angler";
            icon = "generic.png";
        }

        public static LightwoodAngler Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LightwoodAngler();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Housing Craft
    public sealed class WeakTable : CarpentryItem
    {
        private static WeakTable? instance = null;
        private static readonly object locker = new object();

        WeakTable()
        {
            id = 0;
            name = "Weak Table";
            icon = "generic.png";
        }

        public static WeakTable Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WeakTable();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class FrailLoam : CarpentryItem
    {
        private static FrailLoam? instance = null;
        private static readonly object locker = new object();

        FrailLoam()
        {
            id = 0;
            name = "Frail Loam";
            icon = "generic.png";
        }

        public static FrailLoam Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FrailLoam();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ProtectiveCharm : CarpentryItem
    {
        private static ProtectiveCharm? instance = null;
        private static readonly object locker = new object();

        ProtectiveCharm()
        {
            id = 0;
            name = "Protective Charm";
            icon = "generic.png";
        }

        public static ProtectiveCharm Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ProtectiveCharm();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BasicStabilizer : CarpentryItem
    {
        private static BasicStabilizer? instance = null;
        private static readonly object locker = new object();

        BasicStabilizer()
        {
            id = 0;
            name = "Basic Stabilizer";
            icon = "generic.png";
        }

        public static BasicStabilizer Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BasicStabilizer();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class StorageContaier : CarpentryItem
    {
        private static StorageContaier? instance = null;
        private static readonly object locker = new object();

        StorageContaier()
        {
            id = 0;
            name = "Storage Contaier";
            icon = "generic.png";
        }

        public static StorageContaier Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new StorageContaier();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WorkBench : CarpentryItem
    {
        private static WorkBench? instance = null;
        private static readonly object locker = new object();

        WorkBench()
        {
            id = 0;
            name = "Work Bench";
            icon = "generic.png";
        }

        public static WorkBench Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WorkBench();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Chair : CarpentryItem
    {
        private static Chair? instance = null;
        private static readonly object locker = new object();

        Chair()
        {
            id = 0;
            name = "Chair";
            icon = "generic.png";
        }

        public static Chair Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Chair();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SimpleBed : CarpentryItem
    {
        private static SimpleBed? instance = null;
        private static readonly object locker = new object();

        SimpleBed()
        {
            id = 0;
            name = "Simple Bed";
            icon = "generic.png";
        }

        public static SimpleBed Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SimpleBed();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WallReinforcement : CarpentryItem
    {
        private static WallReinforcement? instance = null;
        private static readonly object locker = new object();

        WallReinforcement()
        {
            id = 0;
            name = "Wall Reinforcement";
            icon = "generic.png";
        }

        public static WallReinforcement Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WallReinforcement();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class EnergyStabilizer : CarpentryItem
    {
        private static EnergyStabilizer? instance = null;
        private static readonly object locker = new object();

        EnergyStabilizer()
        {
            id = 0;
            name = "Energy Stabilizer";
            icon = "generic.png";
        }

        public static EnergyStabilizer Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new EnergyStabilizer();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SimpleLoom : CarpentryItem
    {
        private static SimpleLoom? instance = null;
        private static readonly object locker = new object();

        SimpleLoom()
        {
            id = 0;
            name = "Simple Loom";
            icon = "generic.png";
        }

        public static SimpleLoom Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SimpleLoom();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WardingCharm : CarpentryItem
    {
        private static WardingCharm? instance = null;
        private static readonly object locker = new object();

        WardingCharm()
        {
            id = 0;
            name = "Warding Charm";
            icon = "generic.png";
        }

        public static WardingCharm Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WardingCharm();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SuperiorWorkBench : CarpentryItem
    {
        private static SuperiorWorkBench? instance = null;
        private static readonly object locker = new object();

        SuperiorWorkBench()
        {
            id = 0;
            name = "Superior Work Bench";
            icon = "generic.png";
        }

        public static SuperiorWorkBench Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SuperiorWorkBench();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Cabinet : CarpentryItem
    {
        private static Cabinet? instance = null;
        private static readonly object locker = new object();

        Cabinet()
        {
            id = 0;
            name = "Cabinet";
            icon = "generic.png";
        }

        public static Cabinet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Cabinet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SquareTable : CarpentryItem
    {
        private static SquareTable? instance = null;
        private static readonly object locker = new object();

        SquareTable()
        {
            id = 0;
            name = "Square Table";
            icon = "generic.png";
        }

        public static SquareTable Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SquareTable();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ComfortableBed : CarpentryItem
    {
        private static ComfortableBed? instance = null;
        private static readonly object locker = new object();

        ComfortableBed()
        {
            id = 0;
            name = "Comfortable Bed";
            icon = "generic.png";
        }

        public static ComfortableBed Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ComfortableBed();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SturdyContainer : CarpentryItem
    {
        private static SturdyContainer? instance = null;
        private static readonly object locker = new object();

        SturdyContainer()
        {
            id = 0;
            name = "Sturdy Container";
            icon = "generic.png";
        }

        public static SturdyContainer Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SturdyContainer();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ArcaneStabilizer : CarpentryItem
    {
        private static ArcaneStabilizer? instance = null;
        private static readonly object locker = new object();

        ArcaneStabilizer()
        {
            id = 0;
            name = "Arcane Stabilizer";
            icon = "generic.png";
        }

        public static ArcaneStabilizer Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ArcaneStabilizer();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SpellboundCharm : CarpentryItem
    {
        private static SpellboundCharm? instance = null;
        private static readonly object locker = new object();

        SpellboundCharm()
        {
            id = 0;
            name = "Spellbound Charm";
            icon = "generic.png";
        }

        public static SpellboundCharm Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SpellboundCharm();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WallFortification : CarpentryItem
    {
        private static WallFortification? instance = null;
        private static readonly object locker = new object();

        WallFortification()
        {
            id = 0;
            name = "Wall Fortification";
            icon = "generic.png";
        }

        public static WallFortification Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WallFortification();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LuxuryBed : CarpentryItem
    {
        private static LuxuryBed? instance = null;
        private static readonly object locker = new object();

        LuxuryBed()
        {
            id = 0;
            name = "Luxury Bed";
            icon = "generic.png";
        }

        public static LuxuryBed Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LuxuryBed();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Loom : CarpentryItem
    {
        private static Loom? instance = null;
        private static readonly object locker = new object();

        Loom()
        {
            id = 0;
            name = "Loom";
            icon = "generic.png";
        }

        public static Loom Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Loom();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ArtisanWorkBench : CarpentryItem
    {
        private static ArtisanWorkBench? instance = null;
        private static readonly object locker = new object();

        ArtisanWorkBench()
        {
            id = 0;
            name = "Artisan Work Bench";
            icon = "generic.png";
        }

        public static ArtisanWorkBench Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ArtisanWorkBench();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Armoires : CarpentryItem
    {
        private static Armoires? instance = null;
        private static readonly object locker = new object();

        Armoires()
        {
            id = 0;
            name = "Armoires";
            icon = "generic.png";
        }

        public static Armoires Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Armoires();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SturdySquareTable : CarpentryItem
    {
        private static SturdySquareTable? instance = null;
        private static readonly object locker = new object();

        SturdySquareTable()
        {
            id = 0;
            name = "Sturdy Square Table";
            icon = "generic.png";
        }

        public static SturdySquareTable Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SturdySquareTable();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Fireplace : CarpentryItem
    {
        private static Fireplace? instance = null;
        private static readonly object locker = new object();

        Fireplace()
        {
            id = 0;
            name = "Fireplace";
            icon = "generic.png";
        }

        public static Fireplace Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Fireplace();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Ship Craft
    public sealed class Mast : CarpentryItem
    {
        private static Mast? instance = null;
        private static readonly object locker = new object();

        Mast()
        {
            id = 0;
            name = "Mast";
            icon = "generic.png";
        }

        public static Mast Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Mast();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SmallGunDeck : CarpentryItem
    {
        private static SmallGunDeck? instance = null;
        private static readonly object locker = new object();

        SmallGunDeck()
        {
            id = 0;
            name = "Small Gun Deck";
            icon = "generic.png";
        }

        public static SmallGunDeck Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallGunDeck();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SmallFishingStorage : CarpentryItem
    {
        private static SmallFishingStorage? instance = null;
        private static readonly object locker = new object();

        SmallFishingStorage()
        {
            id = 0;
            name = "Small Fishing Storage";
            icon = "generic.png";
        }

        public static SmallFishingStorage Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallFishingStorage();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SmallCargoHold : CarpentryItem
    {
        private static SmallCargoHold? instance = null;
        private static readonly object locker = new object();

        SmallCargoHold()
        {
            id = 0;
            name = "Small Cargo Hold";
            icon = "generic.png";
        }

        public static SmallCargoHold Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallCargoHold();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SmallHullFrame : CarpentryItem
    {
        private static SmallHullFrame? instance = null;
        private static readonly object locker = new object();

        SmallHullFrame()
        {
            id = 0;
            name = "Small Hull Frame";
            icon = "generic.png";
        }

        public static SmallHullFrame Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallHullFrame();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumGunDeck : CarpentryItem
    {
        private static MediumGunDeck? instance = null;
        private static readonly object locker = new object();

        MediumGunDeck()
        {
            id = 0;
            name = "Medium Gun Deck";
            icon = "generic.png";
        }

        public static MediumGunDeck Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumGunDeck();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumFishingStorage : CarpentryItem
    {
        private static MediumFishingStorage? instance = null;
        private static readonly object locker = new object();

        MediumFishingStorage()
        {
            id = 0;
            name = "Medium Fishing Storage";
            icon = "generic.png";
        }

        public static MediumFishingStorage Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumFishingStorage();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumHullFrame : CarpentryItem
    {
        private static MediumHullFrame? instance = null;
        private static readonly object locker = new object();

        MediumHullFrame()
        {
            id = 0;
            name = "Medium Hull Frame";
            icon = "generic.png";
        }

        public static MediumHullFrame Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumHullFrame();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumCargoHold : CarpentryItem
    {
        private static MediumCargoHold? instance = null;
        private static readonly object locker = new object();

        MediumCargoHold()
        {
            id = 0;
            name = "Medium Cargo Hold";
            icon = "generic.png";
        }

        public static MediumCargoHold Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumCargoHold();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LargeCargoHold : CarpentryItem
    {
        private static LargeCargoHold? instance = null;
        private static readonly object locker = new object();

        LargeCargoHold()
        {
            id = 0;
            name = "Large Cargo Hold";
            icon = "generic.png";
        }

        public static LargeCargoHold Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LargeCargoHold();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LargeGunDeck : CarpentryItem
    {
        private static LargeGunDeck? instance = null;
        private static readonly object locker = new object();

        LargeGunDeck()
        {
            id = 0;
            name = "Large Gun Deck";
            icon = "generic.png";
        }

        public static LargeGunDeck Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LargeGunDeck();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LargeFishingStorage : CarpentryItem
    {
        private static LargeFishingStorage? instance = null;
        private static readonly object locker = new object();

        LargeFishingStorage()
        {
            id = 0;
            name = "Large Fishing Storage";
            icon = "generic.png";
        }

        public static LargeFishingStorage Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LargeFishingStorage();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LargeHullFrame : CarpentryItem
    {
        private static LargeHullFrame? instance = null;
        private static readonly object locker = new object();

        LargeHullFrame()
        {
            id = 0;
            name = "LargeHullFrame";
            icon = "generic.png";
        }

        public static LargeHullFrame Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LargeHullFrame();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Ship Module
    public sealed class SmallAmmunitionCabinKit : CarpentryItem
    {
        private static SmallAmmunitionCabinKit? instance = null;
        private static readonly object locker = new object();

        SmallAmmunitionCabinKit()
        {
            id = 0;
            name = "Small Ammunition Cabin Kit";
            icon = "generic.png";
        }

        public static SmallAmmunitionCabinKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallAmmunitionCabinKit();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SmallMaintenanceUnitKit : CarpentryItem
    {
        private static SmallMaintenanceUnitKit? instance = null;
        private static readonly object locker = new object();

        SmallMaintenanceUnitKit()
        {
            id = 0;
            name = "Small Maintenance Unit Kit";
            icon = "generic.png";
        }

        public static SmallMaintenanceUnitKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallMaintenanceUnitKit();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SmallFishingCraneKit : CarpentryItem
    {
        private static SmallFishingCraneKit? instance = null;
        private static readonly object locker = new object();

        SmallFishingCraneKit()
        {
            id = 0;
            name = "Small Fishing Crane Kit";
            icon = "generic.png";
        }

        public static SmallFishingCraneKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallFishingCraneKit();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SmallTradepackContainerKit : CarpentryItem
    {
        private static SmallTradepackContainerKit? instance = null;
        private static readonly object locker = new object();

        SmallTradepackContainerKit()
        {
            id = 0;
            name = "Small Tradepack Container Kit";
            icon = "generic.png";
        }

        public static SmallTradepackContainerKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallTradepackContainerKit();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumTradepackContainerKit : CarpentryItem
    {
        private static MediumTradepackContainerKit? instance = null;
        private static readonly object locker = new object();

        MediumTradepackContainerKit()
        {
            id = 0;
            name = "Medium Tradepack Container Kit";
            icon = "generic.png";
        }

        public static MediumTradepackContainerKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumTradepackContainerKit();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumMaintenanceUnitKit : CarpentryItem
    {
        private static MediumMaintenanceUnitKit? instance = null;
        private static readonly object locker = new object();

        MediumMaintenanceUnitKit()
        {
            id = 0;
            name = "Medium Maintenance Unit Kit";
            icon = "generic.png";
        }

        public static MediumMaintenanceUnitKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumMaintenanceUnitKit();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumAmmunitionCabinKit : CarpentryItem
    {
        private static MediumAmmunitionCabinKit? instance = null;
        private static readonly object locker = new object();

        MediumAmmunitionCabinKit()
        {
            id = 0;
            name = "Medium Ammunition Cabin Kit";
            icon = "generic.png";
        }

        public static MediumAmmunitionCabinKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumAmmunitionCabinKit();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumFishingCraneKit : CarpentryItem
    {
        private static MediumFishingCraneKit? instance = null;
        private static readonly object locker = new object();

        MediumFishingCraneKit()
        {
            id = 0;
            name = "Medium Fishing Crane Kit";
            icon = "generic.png";
        }

        public static MediumFishingCraneKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumFishingCraneKit();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Wagon Craft
    public sealed class CommonWheel : CarpentryItem
    {
        private static CommonWheel? instance = null;
        private static readonly object locker = new object();

        CommonWheel()
        {
            id = 0;
            name = "Common Wheel";
            icon = "generic.png";
        }

        public static CommonWheel Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CommonWheel();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SmallWagonContainer : CarpentryItem
    {
        private static SmallWagonContainer? instance = null;
        private static readonly object locker = new object();

        SmallWagonContainer()
        {
            id = 0;
            name = "Small Wagon Container";
            icon = "generic.png";
        }

        public static SmallWagonContainer Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallWagonContainer();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WoodenArch : CarpentryItem
    {
        private static WoodenArch? instance = null;
        private static readonly object locker = new object();

        WoodenArch()
        {
            id = 0;
            name = "Wooden Arch";
            icon = "generic.png";
        }

        public static WoodenArch Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WoodenArch();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SwiftWheel : CarpentryItem
    {
        private static SwiftWheel? instance = null;
        private static readonly object locker = new object();

        SwiftWheel()
        {
            id = 0;
            name = "Swift Wheel";
            icon = "generic.png";
        }

        public static SwiftWheel Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SwiftWheel();
                    }

                    return instance;
                }
            }
        }
    }


    public sealed class CommonWagonContainer : CarpentryItem
    {
        private static CommonWagonContainer? instance = null;
        private static readonly object locker = new object();

        CommonWagonContainer()
        {
            id = 0;
            name = "Common Wagon Container";
            icon = "generic.png";
        }

        public static CommonWagonContainer Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CommonWagonContainer();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SturdyWheel : CarpentryItem
    {
        private static SturdyWheel? instance = null;
        private static readonly object locker = new object();

        SturdyWheel()
        {
            id = 0;
            name = "Sturdy Wheel";
            icon = "generic.png";
        }

        public static SturdyWheel Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SturdyWheel();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumWagonContainer : CarpentryItem
    {
        private static MediumWagonContainer? instance = null;
        private static readonly object locker = new object();

        MediumWagonContainer()
        {
            id = 0;
            name = "Medium Wagon Container";
            icon = "generic.png";
        }

        public static MediumWagonContainer Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumWagonContainer();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SuppleWoodenArch : CarpentryItem
    {
        private static SuppleWoodenArch? instance = null;
        private static readonly object locker = new object();

        SuppleWoodenArch()
        {
            id = 0;
            name = "Supple Wooden Arch";
            icon = "generic.png";
        }

        public static SuppleWoodenArch Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SuppleWoodenArch();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ReinforcedWheel : CarpentryItem
    {
        private static ReinforcedWheel? instance = null;
        private static readonly object locker = new object();

        ReinforcedWheel()
        {
            id = 0;
            name = "Reinforced Wheel";
            icon = "generic.png";
        }

        public static ReinforcedWheel Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ReinforcedWheel();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LargeWagonContainer : CarpentryItem
    {
        private static LargeWagonContainer? instance = null;
        private static readonly object locker = new object();

        LargeWagonContainer()
        {
            id = 0;
            name = "Large Wagon Container";
            icon = "generic.png";
        }

        public static LargeWagonContainer Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LargeWagonContainer();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion
}
