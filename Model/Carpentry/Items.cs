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
            id = 41847;
            name = "Dense Plank";
            icon = "41847.png";
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
            id = 28744;
            name = "Rough Plank";
            icon = "28744.png";
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
            id = 28743;
            name = "Refined Plank";
            icon = "28743.png";
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
            id = 28745;
            name = "Treated Plank";
            icon = "28745.png";
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
            id = 41848;
            name = "Heavy Plank";
            icon = "41848.png";
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
            id = 45506;
            name = "Sturdy Plank";
            icon = "45506.png";
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
            id = 45503;
            name = "Fine Plank";
            icon = "45503.png";
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
            id = 46241;
            name = "Wooden Bulwark";
            icon = "46241.png";
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
            id = 29050;
            name = "Mystic Staff";
            icon = "29050.png";
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
            id = 28998;
            name = "OakWood Bow";
            icon = "28998.png";
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
            id = 29028;
            name = "Wooden Buckler";
            icon = "29028.png";
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
            id = 33990;
            name = "Knotted Sceptre";
            icon = "33990.png";
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
            id = 46242;
            name = "Sentinel Shield";
            icon = "46242.png";
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
            id = 290290;
            name = "Sturdy Buckler";
            icon = "29029.png";
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
            id = 33991;
            name = "Tribal Sceptre";
            icon = "33991.png";
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
            id = 28999;
            name = "Viper's Bow";
            icon = "28999.png";
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
            id = 29051;
            name = "Warlock Staff";
            icon = "29051.png";
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
            id = 33992;
            name = "Serpent Sceptre";
            icon = "33992.png";
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
            id = 46243;
            name = "Defender's Bulwark";
            icon = "46243.png";
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
            id = 29052;
            name = "Cultist Staff";
            icon = "29052.png";
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
            id = 29030;
            name = "Marauder's Shield";
            icon = "29030.png";
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
            id = 29000;
            name = "Black Ash Bow";
            icon = "29000.png";
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
            id = 33993;
            name = "Crystal Sceptre";
            icon = "33993.png";
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
            id = 29053;
            name = "Celestial Staff";
            icon = "29053.png";
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
            id = 29031;
            name = "Rune Shield";
            icon = "29031.png";
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
            id = 46244;
            name = "Steelclad Bulwark";
            icon = "46244.png";
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
            id = 29001;
            name = "Bullseye Bow";
            icon = "29001.png";
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
            id = 29032;
            name = "Ravenguard's Shield";
            icon = "29032.png";
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
            id = 46245;
            name = "King's Defender";
            icon = "46245.png";
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
            id = 33994;
            name = "Celestial Sceptre";
            icon = "33994.png";
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
            id = 29002;
            name = "Predator Bow";
            icon = "29002.png";
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
            id = 29054;
            name = "Lightshard Staff";
            icon = "29054.png";
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
            id = 46246;
            name = "Protector's Tower Shield";
            icon = "46246.png";
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
            id = 37150;
            name = "Necromancer's Staff";
            icon = "37150.png";
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
            id = 37155;
            name = "Marksman Bow";
            icon = "37155.png";
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
            id = 37157;
            name = "Crowbone Sceptre";
            icon = "37157.png";
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
            id = 37149;
            name = "Nocturnal Shield";
            icon = "37149.png";
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
            id = 28896;
            name = "Fishing Stick";
            icon = "28896.png";
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
            id = 28898;
            name = "Fishing Rod";
            icon = "28898.png";
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
            id = 28895;
            name = "Craftman's Fishing Rod";
            icon = "28895.png";
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
            id = 28899;
            name = "Sailor's Fishing Rod";
            icon = "28899.png";
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
            id = 28900;
            name = "Artisan Fishing Rod";
            icon = "28900.png";
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
            id = 28897;
            name = "Lightwood Angler";
            icon = "28897.png";
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
            id = 42777;
            name = "Weak Table";
            icon = "42777.png";
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

    public sealed class FrailLoom : CarpentryItem
    {
        private static FrailLoom? instance = null;
        private static readonly object locker = new object();

        FrailLoom()
        {
            id = 42781;
            name = "Frail Loom";
            icon = "42781.png";
        }

        public static FrailLoom Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FrailLoom();
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
            id = 47280;
            name = "Protective Charm";
            icon = "47280.png";
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
            id = 47277;
            name = "Basic Stabilizer";
            icon = "47277.png";
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

    public sealed class StorageContainer : CarpentryItem
    {
        private static StorageContainer? instance = null;
        private static readonly object locker = new object();

        StorageContainer()
        {
            id = 37280;
            name = "Storage Container";
            icon = "37280.png";
        }

        public static StorageContainer Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new StorageContainer();
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
            id = 37290;
            name = "Work Bench";
            icon = "37290.png";
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
            id = 37227;
            name = "Chair";
            icon = "37227.png";
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
            id = 37267;
            name = "Simple Bed";
            icon = "37267.png";
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
            id = 47285;
            name = "Wall Reinforcement";
            icon = "47285.png";
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
            id = 47278;
            name = "Energy Stabilizer";
            icon = "47278.png";
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
            id = 42783;
            name = "Simple Loom";
            icon = "42783.png";
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
            id = 47286;
            name = "Warding Charm";
            icon = "47286.png";
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
            id = 37287;
            name = "Superior Work Bench";
            icon = "37287.png";
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
            id = 37224;
            name = "Cabinet";
            icon = "37224.png";
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
            id = 37279;
            name = "Square Table";
            icon = "37279.png";
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
            id = 37228;
            name = "Comfortable Bed";
            icon = "37228.png";
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
            id = 42782;
            name = "Sturdy Container";
            icon = "42782.png";
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
            id = 47275;
            name = "Arcane Stabilizer";
            icon = "47275.png";
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
            id = 47282;
            name = "Spellbound Charm";
            icon = "47282.png";
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
            id = 47284;
            name = "Wall Fortification";
            icon = "47284.png";
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
            id = 37245;
            name = "Luxury Bed";
            icon = "37245.png";
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
            id = 37244;
            name = "Loom";
            icon = "37244.png";
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
            id = 37222;
            name = "Artisan Work Bench";
            icon = "37222.png";
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
            id = 37219;
            name = "Armoires";
            icon = "37219.png";
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
            id = 37283;
            name = "Sturdy Square Table";
            icon = "37283.png";
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
            id = 37231;
            name = "Fireplace";
            icon = "37231.png";
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
            id = 37249;
            name = "Mast";
            icon = "37249.png";
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
            id = 37274;
            name = "Small Gun Deck";
            icon = "37274.png";
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
            id = 37273;
            name = "Small Fishing Storage";
            icon = "37273.png";
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
            id = 37270;
            name = "Small Cargo Hold";
            icon = "37270.png";
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
            id = 37275;
            name = "Small Hull Frame";
            icon = "37275.png";
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
            id = 37255;
            name = "Medium Gun Deck";
            icon = "37255.png";
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
            id = 37254;
            name = "Medium Fishing Storage";
            icon = "37254.png";
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
            id = 37256;
            name = "Medium Hull Frame";
            icon = "37256.png";
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
            id = 37251;
            name = "Medium Cargo Hold";
            icon = "37251.png";
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
            id = 37237;
            name = "Large Cargo Hold";
            icon = "37237.png";
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
            id = 37240;
            name = "Large Gun Deck";
            icon = "37240.png";
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
            id = 37239;
            name = "Large Fishing Storage";
            icon = "37239.png";
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
            id = 37241;
            name = "Large Hull Frame";
            icon = "37241.png";
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
            id = 37269;
            name = "Small Ammunition Cabin Kit";
            icon = "37269.png";
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
            id = 43638;
            name = "Small Maintenance Unit Kit";
            icon = "43638.png";
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
            id = 37271;
            name = "Small Fishing Crane Kit";
            icon = "37271.png";
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
            id = 37277;
            name = "Small Tradepack Container Kit";
            icon = "37277.png";
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
            id = 37258;
            name = "Medium Tradepack Container Kit";
            icon = "37258.png";
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
            id = 43635;
            name = "Medium Maintenance Unit Kit";
            icon = "43635.png";
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
            id = 37250;
            name = "Medium Ammunition Cabin Kit";
            icon = "37250.png";
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
            id = 37252;
            name = "Medium Fishing Crane Kit";
            icon = "37252.png";
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
            id = 37229;
            name = "Common Wheel";
            icon = "37229.png";
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
            id = 37278;
            name = "Small Wagon Container";
            icon = "37278.png";
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
            id = 40286;
            name = "Wooden Arch";
            icon = "40286.png";
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
            id = 40492;
            name = "Swift Wheel";
            icon = "40492.png";
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
            id = 40491;
            name = "Common Wagon Container";
            icon = "40491.png";
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
            id = 37284;
            name = "Sturdy Wheel";
            icon = "37284.png";
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
            id = 37259;
            name = "Medium Wagon Container";
            icon = "37259.png";
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
            id = 40285;
            name = "Supple Wooden Arch";
            icon = "40285.png";
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
            id = 37264;
            name = "Reinforced Wheel";
            icon = "37264.png";
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
            id = 37243;
            name = "Large Wagon Container";
            icon = "37243.png";
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
