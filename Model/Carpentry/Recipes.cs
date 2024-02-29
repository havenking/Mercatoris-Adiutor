namespace MercatorisAdiutor.Model.Carpentry.Objects
{
    public abstract class CarpentryCraftingRecipe : CraftingRecipe
    {
        internal string name = string.Empty;
        internal int tax = 0;
        internal int experience = 0;
        internal int quantity = 1;
        internal Material[] materials = Array.Empty<Material>();
        internal Item craftedItem;

        public string Name => name;

        public int Tax => tax;

        public int Experience => experience;

        public int Quantity => quantity;

        public Material[] Materials => materials;

        public Item CraftedItem => craftedItem;
    }

    #region Planks
    public sealed class DensePlankRecipe : CarpentryCraftingRecipe
    {
        private static DensePlankRecipe? instance = null;
        private static readonly object locker = new object();

        DensePlankRecipe()
        {
            name = "Dense Plank";
            tax = 120;
            experience = 2000;
            materials =
            [
                new Material() { Item = WoodCutting.Items.DenseLog.Instance, Quantity = 4 }
            ];
            craftedItem = Items.DensePlank.Instance;
        }

        public static DensePlankRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new DensePlankRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class RoughPlankRecipe : CarpentryCraftingRecipe
    {
        private static RoughPlankRecipe? instance = null;
        private static readonly object locker = new object();

        RoughPlankRecipe()
        {
            name = "Rough Plank";
            tax = 27;
            experience = 440;
            materials =
            [
                new Material() { Item = WoodCutting.Items.SmallLog.Instance, Quantity = 5 }
            ];
            craftedItem = Items.RoughPlank.Instance;
        }

        public static RoughPlankRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RoughPlankRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class RefinedPlankRecipe : CarpentryCraftingRecipe
    {
        private static RefinedPlankRecipe? instance = null;
        private static readonly object locker = new object();

        RefinedPlankRecipe()
        {
            name = "Refined Plank";
            tax = 53;
            experience = 880;
            materials =
            [
                new Material() { Item = WoodCutting.Items.HeavyLog.Instance, Quantity = 8 }
            ];
            craftedItem = Items.RefinedPlank.Instance;
        }

        public static RefinedPlankRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RefinedPlankRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class TreatedPlankRecipe : CarpentryCraftingRecipe
    {
        private static TreatedPlankRecipe? instance = null;
        private static readonly object locker = new object();

        TreatedPlankRecipe()
        {
            name = "Treated Plank";
            tax = 82;
            experience = 1360;
            materials =
            [
                new Material() { Item = Cooking.Items.Oil.Instance, Quantity = 2 },
                new Material() { Item = WoodCutting.Items.HeavyLog.Instance, Quantity = 12 }
            ];
            craftedItem = Items.TreatedPlank.Instance;
        }

        public static TreatedPlankRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new TreatedPlankRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class HeavyPlankRecipe : CarpentryCraftingRecipe
    {
        private static HeavyPlankRecipe? instance = null;
        private static readonly object locker = new object();

        HeavyPlankRecipe()
        {
            name = "Heavy Plank";
            tax = 264;
            experience = 4400;
            materials =
            [
                new Material() { Item = Cooking.Items.Oil.Instance, Quantity = 2 },
                new Material() { Item = WoodCutting.Items.DenseLog.Instance, Quantity = 8 }
            ];
            craftedItem = Items.HeavyPlank.Instance;
        }

        public static HeavyPlankRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new HeavyPlankRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SturdyPlankRecipe : CarpentryCraftingRecipe
    {
        private static SturdyPlankRecipe? instance = null;
        private static readonly object locker = new object();

        SturdyPlankRecipe()
        {
            name = "Sturdy Plank";
            tax = 90;
            experience = 1500;
            materials =
            [
                new Material() { Item = Cooking.Items.Oil.Instance, Quantity = 4 },
                new Material() { Item = WoodCutting.Items.SturdyLog.Instance, Quantity = 10 }
            ];
            craftedItem = Items.SturdyPlank.Instance;
        }

        public static SturdyPlankRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SturdyPlankRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class FinePlankRecipe : CarpentryCraftingRecipe
    {
        private static FinePlankRecipe? instance = null;
        private static readonly object locker = new object();

        FinePlankRecipe()
        {
            name = "Fine Plank";
            tax = 132;
            experience = 2200;
            materials =
            [
                new Material() { Item = Cooking.Items.Oil.Instance, Quantity = 6 },
                new Material() { Item = WoodCutting.Items.FineLog.Instance, Quantity = 10 }
            ];
            craftedItem = Items.FinePlank.Instance;
        }

        public static FinePlankRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FinePlankRecipe();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Weapons
    #region Tier1
    public sealed class WoodenBulwarkRecipe : CarpentryCraftingRecipe
    {
        private static WoodenBulwarkRecipe? instance = null;
        private static readonly object locker = new object();

        WoodenBulwarkRecipe()
        {
            name = "Wooden Bulwark";
            tax = 53;
            experience = 880;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 2 }
            ];
            craftedItem = Carpentry.Items.WoodenBulwark.Instance;
        }

        public static WoodenBulwarkRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WoodenBulwarkRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MysticStaffRecipe : CarpentryCraftingRecipe
    {
        private static MysticStaffRecipe? instance = null;
        private static readonly object locker = new object();

        MysticStaffRecipe()
        {
            name = "Mystic Staff";
            tax = 106;
            experience = 1760;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 4 }
            ];
            craftedItem = Items.MysticStaff.Instance;
        }

        public static MysticStaffRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MysticStaffRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class OakWoodBowRecipe : CarpentryCraftingRecipe
    {
        private static OakWoodBowRecipe? instance = null;
        private static readonly object locker = new object();

        OakWoodBowRecipe()
        {
            name = "OakWood Bow";
            tax = 106;
            experience = 1760;
            materials =
            [
                new Material() { Item = Weaving.Items.CoarseThread.Instance, Quantity = 1 },
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 3 }
            ];
            craftedItem = Items.OakWoodBow.Instance;
        }

        public static OakWoodBowRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new OakWoodBowRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WoodenBucklerRecipe : CarpentryCraftingRecipe
    {
        private static WoodenBucklerRecipe? instance = null;
        private static readonly object locker = new object();

        WoodenBucklerRecipe()
        {
            name = "Wooden Buckler";
            tax = 53;
            experience = 880;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 2 }
            ];
            craftedItem = Items.WoodenBuckler.Instance;
        }

        public static WoodenBucklerRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WoodenBucklerRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class KnottedSceptreRecipe : CarpentryCraftingRecipe
    {
        private static KnottedSceptreRecipe? instance = null;
        private static readonly object locker = new object();

        KnottedSceptreRecipe()
        {
            name = "Knotted Sceptre";
            tax = 53;
            experience = 880;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 2 }
            ];
            craftedItem = Items.KnottedSceptre.Instance;
        }

        public static KnottedSceptreRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new KnottedSceptreRecipe();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Tier2
    public sealed class SentinelShieldRecipe : CarpentryCraftingRecipe
    {
        private static SentinelShieldRecipe? instance = null;
        private static readonly object locker = new object();

        SentinelShieldRecipe()
        {
            name = "Sentinel Shield";
            tax = 111;
            experience = 1840;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 3 },
                new Material() { Item = Blacksmithing.Items.CopperIngot.Instance, Quantity = 3 },
                new Material() { Item = Carpentry.Items.WoodenBulwark.Instance, Quantity = 1 }
            ];
            craftedItem = Items.SentinelShield.Instance;
        }

        public static SentinelShieldRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SentinelShieldRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SturdyBucklerRecipe : CarpentryCraftingRecipe
    {
        private static SturdyBucklerRecipe? instance = null;
        private static readonly object locker = new object();

        SturdyBucklerRecipe()
        {
            name = "Sturdy Buckler";
            tax = 111;
            experience = 1840;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 3 },
                new Material() { Item = Weaving.Items.CoarseLeather.Instance, Quantity = 1 },
                new Material() { Item = Carpentry.Items.WoodenBuckler.Instance, Quantity = 1 }
            ];
            craftedItem = Items.SturdyBuckler.Instance;
        }

        public static SturdyBucklerRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SturdyBucklerRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class TribalSceptreRecipe : CarpentryCraftingRecipe
    {
        private static TribalSceptreRecipe? instance = null;
        private static readonly object locker = new object();

        TribalSceptreRecipe()
        {
            name = "Tribal Sceptre";
            tax = 111;
            experience = 1840;
            materials =
            [
                new Material() { Item = Carpentry.Items.KnottedSceptre.Instance, Quantity = 1 },
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 4 }
            ];
            craftedItem = Items.TribalSceptre.Instance;
        }

        public static TribalSceptreRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new TribalSceptreRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ViperBowRecipe : CarpentryCraftingRecipe
    {
        private static ViperBowRecipe? instance = null;
        private static readonly object locker = new object();

        ViperBowRecipe()
        {
            name = "Viper's Bow";
            tax = 221;
            experience = 3680;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 6 },
                new Material() { Item = Weaving.Items.CoarseThread.Instance, Quantity = 2 },
                new Material() { Item = Carpentry.Items.OakWoodBow.Instance, Quantity = 1 }
            ];
            craftedItem = Items.ViperBow.Instance;
        }

        public static ViperBowRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ViperBowRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WarlockStaffRecipe : CarpentryCraftingRecipe
    {
        private static WarlockStaffRecipe? instance = null;
        private static readonly object locker = new object();

        WarlockStaffRecipe()
        {
            name = "Warlock Staff";
            tax = 221;
            experience = 3680;
            materials =
            [
                new Material() { Item = Carpentry.Items.MysticStaff.Instance, Quantity = 1 },
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 8 }
            ];
            craftedItem = Items.WarlockStaff.Instance;
        }

        public static WarlockStaffRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WarlockStaffRecipe();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Tier3
    public sealed class SerpentSceptreRecipe : CarpentryCraftingRecipe
    {
        private static SerpentSceptreRecipe? instance = null;
        private static readonly object locker = new object();

        SerpentSceptreRecipe()
        {
            name = "Serpent Sceptre";
            tax = 420;
            experience = 7000;
            materials =
            [
                new Material() { Item = Carpentry.Items.RefinedPlank.Instance, Quantity = 10 },
                new Material() { Item = Carpentry.Items.TribalSceptre.Instance, Quantity = 1 },
                new Material() { Item = Monster.Items.TrollFang.Instance, Quantity = 6 }
            ];
            craftedItem = Items.SerpentSceptre.Instance;
        }

        public static SerpentSceptreRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SerpentSceptreRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class DefenderBulwarkRecipe : CarpentryCraftingRecipe
    {
        private static DefenderBulwarkRecipe? instance = null;
        private static readonly object locker = new object();

        DefenderBulwarkRecipe()
        {
            name = "Defender's Bulwark";
            tax = 420;
            experience = 7000;
            materials =
            [
                new Material() { Item = Monster.Items.SeaCuredLeather.Instance, Quantity = 6 },
                new Material() { Item = Carpentry.Items.RefinedPlank.Instance, Quantity = 6 },
                new Material() { Item = Blacksmithing.Items.IronIngot.Instance, Quantity = 8 },
                new Material() { Item = Carpentry.Items.SentinelShield.Instance, Quantity = 1 }
            ];
            craftedItem = Items.DefenderBulwark.Instance;
        }

        public static DefenderBulwarkRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new DefenderBulwarkRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CultistStaffRecipe : CarpentryCraftingRecipe
    {
        private static CultistStaffRecipe? instance = null;
        private static readonly object locker = new object();

        CultistStaffRecipe()
        {
            name = "Cultist Staff";
            tax = 840;
            experience = 14000;
            materials =
            [
                new Material() { Item = Carpentry.Items.RefinedPlank.Instance, Quantity = 16 },
                new Material() { Item = Carpentry.Items.WarlockStaff.Instance, Quantity = 1 },
                new Material() { Item = Monster.Items.TrollFang.Instance, Quantity = 12 }
            ];
            craftedItem = Items.CultistStaff.Instance;
        }

        public static CultistStaffRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CultistStaffRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MarauderShieldRecipe : CarpentryCraftingRecipe
    {
        private static MarauderShieldRecipe? instance = null;
        private static readonly object locker = new object();

        MarauderShieldRecipe()
        {
            name = "Marauder's Shield";
            tax = 420;
            experience = 7000;
            materials =
            [
                new Material() { Item = Monster.Items.SeaCuredLeather.Instance, Quantity = 6 },
                new Material() { Item = Carpentry.Items.RefinedPlank.Instance, Quantity = 5 },
                new Material() { Item = Weaving.Items.CraftmanLeather.Instance, Quantity = 2 },
                new Material() { Item = Carpentry.Items.SturdyBuckler.Instance, Quantity = 1 }
            ];
            craftedItem = Items.MarauderShield.Instance;
        }

        public static MarauderShieldRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MarauderShieldRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BlackAshBowRecipe : CarpentryCraftingRecipe
    {
        private static BlackAshBowRecipe? instance = null;
        private static readonly object locker = new object();

        BlackAshBowRecipe()
        {
            name = "Black Ash Bow";
            tax = 840;
            experience = 14000;
            materials =
            [
                new Material() { Item = Monster.Items.SeaCuredLeather.Instance, Quantity = 12 },
                new Material() { Item = Carpentry.Items.RefinedPlank.Instance, Quantity = 10 },
                new Material() { Item = Weaving.Items.CraftmanThread.Instance, Quantity = 5 },
                new Material() { Item = Carpentry.Items.ViperBow.Instance, Quantity = 1 }
            ];
            craftedItem = Items.BlackAshBow.Instance;
        }

        public static BlackAshBowRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BlackAshBowRecipe();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Tier4
    public sealed class CrystalSceptreRecipe : CarpentryCraftingRecipe
    {
        private static CrystalSceptreRecipe? instance = null;
        private static readonly object locker = new object();

        CrystalSceptreRecipe()
        {
            name = "Crystal Sceptre";
            tax = 0;
            experience = 0;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 2 }
            ];
            craftedItem = Items.DensePlank.Instance;
        }

        public static CrystalSceptreRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CrystalSceptreRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CelestialStaffRecipe : CarpentryCraftingRecipe
    {
        private static CelestialStaffRecipe? instance = null;
        private static readonly object locker = new object();

        CelestialStaffRecipe()
        {
            name = "Celestial Staff";
            tax = 0;
            experience = 0;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 2 }
            ];
            craftedItem = Items.DensePlank.Instance;
        }

        public static CelestialStaffRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CelestialStaffRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class RuneShieldRecipe : CarpentryCraftingRecipe
    {
        private static RuneShieldRecipe? instance = null;
        private static readonly object locker = new object();

        RuneShieldRecipe()
        {
            name = "Rune Shield";
            tax = 0;
            experience = 0;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 2 }
            ];
            craftedItem = Items.DensePlank.Instance;
        }

        public static RuneShieldRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RuneShieldRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SteelcladBulwarkRecipe : CarpentryCraftingRecipe
    {
        private static SteelcladBulwarkRecipe? instance = null;
        private static readonly object locker = new object();

        SteelcladBulwarkRecipe()
        {
            name = "Steelclad Bulwark";
            tax = 0;
            experience = 0;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 2 }
            ];
            craftedItem = Items.DensePlank.Instance;
        }

        public static SteelcladBulwarkRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SteelcladBulwarkRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BullseyeBowRecipe : CarpentryCraftingRecipe
    {
        private static BullseyeBowRecipe? instance = null;
        private static readonly object locker = new object();

        BullseyeBowRecipe()
        {
            name = "Bullseye Bow";
            tax = 0;
            experience = 0;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 2 }
            ];
            craftedItem = Items.DensePlank.Instance;
        }

        public static BullseyeBowRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BullseyeBowRecipe();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Tier5
    public sealed class RavenguardShieldRecipe : CarpentryCraftingRecipe
    {
        private static RavenguardShieldRecipe? instance = null;
        private static readonly object locker = new object();

        RavenguardShieldRecipe()
        {
            name = "Ravenguard's Shield";
            tax = 0;
            experience = 0;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 2 }
            ];
            craftedItem = Items.DensePlank.Instance;
        }

        public static RavenguardShieldRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RavenguardShieldRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class KingDefenderRecipe : CarpentryCraftingRecipe
    {
        private static KingDefenderRecipe? instance = null;
        private static readonly object locker = new object();

        KingDefenderRecipe()
        {
            name = "King's Defender";
            tax = 0;
            experience = 0;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 2 }
            ];
            craftedItem = Items.DensePlank.Instance;
        }

        public static KingDefenderRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new KingDefenderRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CelestialSceptreRecipe : CarpentryCraftingRecipe
    {
        private static CelestialSceptreRecipe? instance = null;
        private static readonly object locker = new object();

        CelestialSceptreRecipe()
        {
            name = "Celestial Sceptre";
            tax = 0;
            experience = 0;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 2 }
            ];
            craftedItem = Items.DensePlank.Instance;
        }

        public static CelestialSceptreRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CelestialSceptreRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class PredatorBowRecipe : CarpentryCraftingRecipe
    {
        private static PredatorBowRecipe? instance = null;
        private static readonly object locker = new object();

        PredatorBowRecipe()
        {
            name = "Predator Bow";
            tax = 0;
            experience = 0;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 2 }
            ];
            craftedItem = Items.DensePlank.Instance;
        }

        public static PredatorBowRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new PredatorBowRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LightshardStaffRecipe : CarpentryCraftingRecipe
    {
        private static LightshardStaffRecipe? instance = null;
        private static readonly object locker = new object();

        LightshardStaffRecipe()
        {
            name = "Lightshard Staff";
            tax = 0;
            experience = 0;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 2 }
            ];
            craftedItem = Items.DensePlank.Instance;
        }

        public static LightshardStaffRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LightshardStaffRecipe();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Tier6
    public sealed class ProtectorTowerShieldRecipe : CarpentryCraftingRecipe
    {
        private static ProtectorTowerShieldRecipe? instance = null;
        private static readonly object locker = new object();

        ProtectorTowerShieldRecipe()
        {
            name = "Protector's Tower Shield";
            tax = 0;
            experience = 0;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 2 }
            ];
            craftedItem = Items.DensePlank.Instance;
        }

        public static ProtectorTowerShieldRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ProtectorTowerShieldRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class NecromancerStaffRecipe : CarpentryCraftingRecipe
    {
        private static NecromancerStaffRecipe? instance = null;
        private static readonly object locker = new object();

        NecromancerStaffRecipe()
        {
            name = "Necromancer Staff";
            tax = 0;
            experience = 0;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 2 }
            ];
            craftedItem = Items.DensePlank.Instance;
        }

        public static NecromancerStaffRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new NecromancerStaffRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MarksmanBowRecipe : CarpentryCraftingRecipe
    {
        private static MarksmanBowRecipe? instance = null;
        private static readonly object locker = new object();

        MarksmanBowRecipe()
        {
            name = "Marksman Bow";
            tax = 0;
            experience = 0;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 2 }
            ];
            craftedItem = Items.DensePlank.Instance;
        }

        public static MarksmanBowRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MarksmanBowRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CrowboneSceptreRecipe : CarpentryCraftingRecipe
    {
        private static CrowboneSceptreRecipe? instance = null;
        private static readonly object locker = new object();

        CrowboneSceptreRecipe()
        {
            name = "Crowbone Sceptre";
            tax = 0;
            experience = 0;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 2 }
            ];
            craftedItem = Items.DensePlank.Instance;
        }

        public static CrowboneSceptreRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CrowboneSceptreRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class NocturnalShieldRecipe : CarpentryCraftingRecipe
    {
        private static NocturnalShieldRecipe? instance = null;
        private static readonly object locker = new object();

        NocturnalShieldRecipe()
        {
            name = "Nocturnal Shield";
            tax = 0;
            experience = 0;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 2 }
            ];
            craftedItem = Items.DensePlank.Instance;
        }

        public static NocturnalShieldRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new NocturnalShieldRecipe();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion
    #endregion

    #region Fishing
    public sealed class FishingStickRecipe : CarpentryCraftingRecipe
    {
        private static FishingStickRecipe? instance = null;
        private static readonly object locker = new object();

        FishingStickRecipe()
        {
            name = "Fishing Stick";
            tax = 63;
            experience = 1040;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 1 },
                new Material() { Item = Weaving.Items.CoarseThread.Instance, Quantity = 1 }
            ];
            craftedItem = Items.FishingStick.Instance;
        }

        public static FishingStickRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FishingStickRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class FishingRodRecipe : CarpentryCraftingRecipe
    {
        private static FishingRodRecipe? instance = null;
        private static readonly object locker = new object();

        FishingRodRecipe()
        {
            name = "Fishing Rod";
            tax = 125;
            experience = 2080;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 2 },
                new Material() { Item = Weaving.Items.CoarseThread.Instance, Quantity = 2 },
                new Material() { Item = Carpentry.Items.FishingStick.Instance, Quantity = 1 }
            ];
            craftedItem = Items.FishingRod.Instance;
        }

        public static FishingRodRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FishingRodRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CraftmanFishingRodRecipe : CarpentryCraftingRecipe
    {
        private static CraftmanFishingRodRecipe? instance = null;
        private static readonly object locker = new object();

        CraftmanFishingRodRecipe()
        {
            name = "Craftman's Fishing Rod";
            tax = 375;
            experience = 6240;
            materials =
            [
                new Material() { Item = Carpentry.Items.RefinedPlank.Instance, Quantity = 3 },
                new Material() { Item = Weaving.Items.CraftmanThread.Instance, Quantity = 3 },
                new Material() { Item = Carpentry.Items.FishingRod.Instance, Quantity = 1 }
            ];
            craftedItem = Items.CraftmanFishingRod.Instance;
        }

        public static CraftmanFishingRodRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CraftmanFishingRodRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SailorFishingRodRecipe : CarpentryCraftingRecipe
    {
        private static SailorFishingRodRecipe? instance = null;
        private static readonly object locker = new object();

        SailorFishingRodRecipe()
        {
            name = "Sailor's Fishing Rod";
            tax = 816;
            experience = 13600;
            materials =
            [
                new Material() { Item = Carpentry.Items.TreatedPlank.Instance, Quantity = 3 },
                new Material() { Item = Weaving.Items.FineThread.Instance, Quantity = 5 },
                new Material() { Item = Carpentry.Items.CraftmanFishingRod.Instance, Quantity = 1 }
            ];
            craftedItem = Items.SailorFishingRod.Instance;
        }

        public static SailorFishingRodRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SailorFishingRodRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ArtisanFishingRodRecipe : CarpentryCraftingRecipe
    {
        private static ArtisanFishingRodRecipe? instance = null;
        private static readonly object locker = new object();

        ArtisanFishingRodRecipe()
        {
            name = "Artisan Fishing Rod";
            tax = 2688;
            experience = 44800;
            materials =
            [
                new Material() { Item = Carpentry.Items.SturdyPlank.Instance, Quantity = 10 },
                new Material() { Item = Weaving.Items.MerchantThread.Instance, Quantity = 12 },
                new Material() { Item = Carpentry.Items.SailorFishingRod.Instance, Quantity = 1 }
            ];
            craftedItem = Items.ArtisanFishingRod.Instance;
        }

        public static ArtisanFishingRodRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ArtisanFishingRodRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LightwoodAnglerRecipe : CarpentryCraftingRecipe
    {
        private static LightwoodAnglerRecipe? instance = null;
        private static readonly object locker = new object();

        LightwoodAnglerRecipe()
        {
            name = "Lightwood Angler";
            tax = 4224;
            experience = 70400;
            materials =
            [
                new Material() { Item = Carpentry.Items.FinePlank.Instance, Quantity = 10 },
                new Material() { Item = Weaving.Items.ArtisanThread.Instance, Quantity = 16 },
                new Material() { Item = Carpentry.Items.ArtisanFishingRod.Instance, Quantity = 1 }
            ];
            craftedItem = Items.LightwoodAngler.Instance;
        }

        public static LightwoodAnglerRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LightwoodAnglerRecipe();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Housing Craft
    public sealed class WeakTableRecipe : CarpentryCraftingRecipe
    {
        private static WeakTableRecipe? instance = null;
        private static readonly object locker = new object();

        WeakTableRecipe()
        {
            name = "Weak Table";
            tax = 216;
            experience = 3600;
            materials =
            [
                new Material() { Item = Blacksmithing.Items.Nail.Instance, Quantity = 2 },
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 8 }
            ];
            craftedItem = Items.WeakTable.Instance;
        }

        public static WeakTableRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WeakTableRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class FrailLoamRecipe : CarpentryCraftingRecipe
    {
        private static FrailLoamRecipe? instance = null;
        private static readonly object locker = new object();

        FrailLoamRecipe()
        {
            name = "Frail Loam";
            tax = 480;
            experience = 8000;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 10 },
                new Material() { Item = Weaving.Items.SimpleCloth.Instance, Quantity = 6 }
            ];
            craftedItem = Items.FrailLoom.Instance;
        }

        public static FrailLoamRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FrailLoamRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ProtectiveCharmRecipe : CarpentryCraftingRecipe
    {
        private static ProtectiveCharmRecipe? instance = null;
        private static readonly object locker = new object();

        ProtectiveCharmRecipe()
        {
            name = "Protective Charm";
            tax = 480;
            experience = 8000;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 10 },
                new Material() { Item = Weaving.Items.SimpleCloth.Instance, Quantity = 6 }
            ];
            craftedItem = Items.ProtectiveCharm.Instance;
        }

        public static ProtectiveCharmRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ProtectiveCharmRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BasicStabilizerRecipe : CarpentryCraftingRecipe
    {
        private static BasicStabilizerRecipe? instance = null;
        private static readonly object locker = new object();

        BasicStabilizerRecipe()
        {
            name = "Basic Stabilizer";
            tax = 480;
            experience = 8000;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 10 },
                new Material() { Item = Weaving.Items.SimpleCloth.Instance, Quantity = 6 }
            ];
            craftedItem = Items.BasicStabilizer.Instance;
        }

        public static BasicStabilizerRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BasicStabilizerRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class StorageContaierRecipe : CarpentryCraftingRecipe
    {
        private static StorageContaierRecipe? instance = null;
        private static readonly object locker = new object();

        StorageContaierRecipe()
        {
            name = "Storage Contaier";
            tax = 442;
            experience = 73600;
            materials =
            [
                new Material() { Item = Carpentry.Items.RefinedPlank.Instance, Quantity = 2 },
                new Material() { Item = Blacksmithing.Items.Nail.Instance, Quantity = 1 },
                new Material() { Item = Blacksmithing.Items.IronBar.Instance, Quantity = 1 }
            ];
            craftedItem = Items.StorageContainer.Instance;
        }

        public static StorageContaierRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new StorageContaierRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WorkBenchRecipe : CarpentryCraftingRecipe
    {
        private static WorkBenchRecipe? instance = null;
        private static readonly object locker = new object();

        WorkBenchRecipe()
        {
            name = "Work Bench";
            tax = 1560;
            experience = 26000;
            materials =
            [
                new Material() { Item = Carpentry.Items.RefinedPlank.Instance, Quantity = 20 },
                new Material() { Item = Blacksmithing.Items.Nail.Instance, Quantity = 5 },
                new Material() { Item = Blacksmithing.Items.IronIngot.Instance, Quantity = 20 },
                new Material() { Item = Blacksmithing.Items.SteelIngot.Instance, Quantity = 10 }
            ];
            craftedItem = Items.WorkBench.Instance;
        }

        public static WorkBenchRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WorkBenchRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ChairRecipe : CarpentryCraftingRecipe
    {
        private static ChairRecipe? instance = null;
        private static readonly object locker = new object();

        ChairRecipe()
        {
            name = "Chair";
            tax = 432;
            experience = 7200;
            materials =
            [
                new Material() { Item = Carpentry.Items.RefinedPlank.Instance, Quantity = 8 },
                new Material() { Item = Blacksmithing.Items.Nail.Instance, Quantity = 2 }
            ];
            craftedItem = Items.Chair.Instance;
        }

        public static ChairRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ChairRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SimpleBedRecipe : CarpentryCraftingRecipe
    {
        private static SimpleBedRecipe? instance = null;
        private static readonly object locker = new object();

        SimpleBedRecipe()
        {
            name = "Simple Bed";
            tax = 1440;
            experience = 24000;
            materials =
            [
                new Material() { Item = Carpentry.Items.RefinedPlank.Instance, Quantity = 10 },
                new Material() { Item = Weaving.Items.SimpleCloth.Instance, Quantity = 15 },
                new Material() { Item = Weaving.Items.CoarseThread.Instance, Quantity = 10 }
            ];
            craftedItem = Items.SimpleBed.Instance;
        }

        public static SimpleBedRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SimpleBedRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WallReinforcementRecipe : CarpentryCraftingRecipe
    {
        private static WallReinforcementRecipe? instance = null;
        private static readonly object locker = new object();

        WallReinforcementRecipe()
        {
            name = "Wall Reinforcement";
            tax = 442;
            experience = 7360;
            materials =
            [
                new Material() { Item = Carpentry.Items.RefinedPlank.Instance, Quantity = 8 },
                new Material() { Item = Blacksmithing.Items.Nail.Instance, Quantity = 1 },
                new Material() { Item = Blacksmithing.Items.IronBar.Instance, Quantity = 1 }
            ];
            craftedItem = Items.WallReinforcement.Instance;
        }

        public static WallReinforcementRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WallReinforcementRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class EnergyStabilizerRecipe : CarpentryCraftingRecipe
    {
        private static EnergyStabilizerRecipe? instance = null;
        private static readonly object locker = new object();

        EnergyStabilizerRecipe()
        {
            name = "Energy Stabilizer";
            tax = 1380;
            experience = 23000;
            materials =
            [
                new Material() { Item = Carpentry.Items.TreatedPlank.Instance, Quantity = 10 },
                new Material() { Item = Weaving.Items.FineThread.Instance, Quantity = 5 }
            ];
            craftedItem = Items.EnergyStabilizer.Instance;
        }

        public static EnergyStabilizerRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new EnergyStabilizerRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SimpleLoomRecipe : CarpentryCraftingRecipe
    {
        private static SimpleLoomRecipe? instance = null;
        private static readonly object locker = new object();

        SimpleLoomRecipe()
        {
            name = "Simple Loom";
            tax = 1380;
            experience = 23000;
            materials =
            [
                new Material() { Item = Carpentry.Items.TreatedPlank.Instance, Quantity = 10 },
                new Material() { Item = Weaving.Items.FineThread.Instance, Quantity = 5 }
            ];
            craftedItem = Items.SimpleLoom.Instance;
        }

        public static SimpleLoomRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SimpleLoomRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WardingCharmRecipe : CarpentryCraftingRecipe
    {
        private static WardingCharmRecipe? instance = null;
        private static readonly object locker = new object();

        WardingCharmRecipe()
        {
            name = "Warding Charm";
            tax = 1380;
            experience = 23000;
            materials =
            [
                new Material() { Item = Carpentry.Items.TreatedPlank.Instance, Quantity = 10 },
                new Material() { Item = Weaving.Items.FineThread.Instance, Quantity = 5 }
            ];
            craftedItem = Items.WardingCharm.Instance;
        }

        public static WardingCharmRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WardingCharmRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SuperiorWorkBenchRecipe : CarpentryCraftingRecipe
    {
        private static SuperiorWorkBenchRecipe? instance = null;
        private static readonly object locker = new object();

        SuperiorWorkBenchRecipe()
        {
            name = "Superior Work Bench";
            tax = 3030;
            experience = 50500;
            materials =
            [
                new Material() { Item = Carpentry.Items.TreatedPlank.Instance, Quantity = 30 },
                new Material() { Item = Blacksmithing.Items.Nail.Instance, Quantity = 5 },
                new Material() { Item = Blacksmithing.Items.SteelIngot.Instance, Quantity = 15 },
                new Material() { Item = Blacksmithing.Items.CobaltIngot.Instance, Quantity = 10 }
            ];
            craftedItem = Items.SuperiorWorkBench.Instance;
        }

        public static SuperiorWorkBenchRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SuperiorWorkBenchRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CabinetRecipe : CarpentryCraftingRecipe
    {
        private static CabinetRecipe? instance = null;
        private static readonly object locker = new object();

        CabinetRecipe()
        {
            name = "Cabinet";
            tax = 216;
            experience = 3600;
            materials =
            [
                new Material() { Item = Carpentry.Items.TreatedPlank.Instance, Quantity = 3 },
                new Material() { Item = Blacksmithing.Items.Nail.Instance, Quantity = 1 }
            ];
            craftedItem = Items.Cabinet.Instance;
        }

        public static CabinetRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CabinetRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SquareTableRecipe : CarpentryCraftingRecipe
    {
        private static SquareTableRecipe? instance = null;
        private static readonly object locker = new object();

        SquareTableRecipe()
        {
            name = "Square Table";
            tax = 1650;
            experience = 27500;
            materials =
            [
                new Material() { Item = Carpentry.Items.TreatedPlank.Instance, Quantity = 2 },
                new Material() { Item = Blacksmithing.Items.Bolt.Instance, Quantity = 4 }
            ];
            craftedItem = Items.SquareTable.Instance;
        }

        public static SquareTableRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SquareTableRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ComfortableBedRecipe : CarpentryCraftingRecipe
    {
        private static ComfortableBedRecipe? instance = null;
        private static readonly object locker = new object();

        ComfortableBedRecipe()
        {
            name = "Comfortable Bed";
            tax = 3870;
            experience = 64500;
            materials =
            [
                new Material() { Item = Carpentry.Items.TreatedPlank.Instance, Quantity = 2 },
                new Material() { Item = Blacksmithing.Items.Bolt.Instance, Quantity = 4 },
                new Material() { Item = Weaving.Items.MerchantThread.Instance, Quantity = 10 },
                new Material() { Item = Weaving.Items.MerchantCloth.Instance, Quantity = 10 }
            ];
            craftedItem = Items.ComfortableBed.Instance;
        }

        public static ComfortableBedRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ComfortableBedRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SturdyContainerRecipe : CarpentryCraftingRecipe
    {
        private static SturdyContainerRecipe? instance = null;
        private static readonly object locker = new object();

        SturdyContainerRecipe()
        {
            name = "Sturdy Container";
            tax = 2496;
            experience = 41600;
            materials =
            [
                new Material() { Item = Carpentry.Items.SturdyPlank.Instance, Quantity = 18 },
                new Material() { Item = Blacksmithing.Items.CommonPlate.Instance, Quantity = 6 }
            ];
            craftedItem = Items.SturdyContainer.Instance;
        }

        public static SturdyContainerRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SturdyContainerRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ArcaneStabilizerRecipe : CarpentryCraftingRecipe
    {
        private static ArcaneStabilizerRecipe? instance = null;
        private static readonly object locker = new object();

        ArcaneStabilizerRecipe()
        {
            name = "Arcane Stabilizer";
            tax = 2100;
            experience = 35000;
            materials =
            [
                new Material() { Item = Carpentry.Items.SturdyPlank.Instance, Quantity = 15 },
                new Material() { Item = Weaving.Items.MerchantThread.Instance, Quantity = 5 }
            ];
            craftedItem = Items.ArcaneStabilizer.Instance;
        }

        public static ArcaneStabilizerRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ArcaneStabilizerRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SpellboundCharmRecipe : CarpentryCraftingRecipe
    {
        private static SpellboundCharmRecipe? instance = null;
        private static readonly object locker = new object();

        SpellboundCharmRecipe()
        {
            name = "Spellbound Charm";
            tax = 2100;
            experience = 35000;
            materials =
            [
                new Material() { Item = Carpentry.Items.SturdyPlank.Instance, Quantity = 15 },
                new Material() { Item = Weaving.Items.MerchantThread.Instance, Quantity = 5 }
            ];
            craftedItem = Items.SpellboundCharm.Instance;
        }

        public static SpellboundCharmRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SpellboundCharmRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WallFortificationRecipe : CarpentryCraftingRecipe
    {
        private static WallFortificationRecipe? instance = null;
        private static readonly object locker = new object();

        WallFortificationRecipe()
        {
            name = "Wall Fortification";
            tax = 2490;
            experience = 41500;
            materials =
            [
                new Material() { Item = Carpentry.Items.SturdyPlank.Instance, Quantity = 18 },
                new Material() { Item = Blacksmithing.Items.CommonPlate.Instance, Quantity = 6 }
            ];
            craftedItem = Items.WallFortification.Instance;
        }

        public static WallFortificationRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WallFortificationRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LuxuryBedRecipe : CarpentryCraftingRecipe
    {
        private static LuxuryBedRecipe? instance = null;
        private static readonly object locker = new object();

        LuxuryBedRecipe()
        {
            name = "Luxury Bed";
            tax = 7800;
            experience = 130000;
            materials =
            [
                new Material() { Item = Carpentry.Items.SturdyPlank.Instance, Quantity = 25 },
                new Material() { Item = Blacksmithing.Items.Bolt.Instance, Quantity = 10 },
                new Material() { Item = Weaving.Items.ArtisanThread.Instance, Quantity = 10 },
                new Material() { Item = Weaving.Items.ArtisanCloth.Instance, Quantity = 20 }
            ];
            craftedItem = Items.LuxuryBed.Instance;
        }

        public static LuxuryBedRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LuxuryBedRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LoomRecipe : CarpentryCraftingRecipe
    {
        private static LoomRecipe? instance = null;
        private static readonly object locker = new object();

        LoomRecipe()
        {
            name = "Loom";
            tax = 1440;
            experience = 24000;
            materials =
            [
                new Material() { Item = Carpentry.Items.SturdyPlank.Instance, Quantity = 8 },
                new Material() { Item = Weaving.Items.MerchantThread.Instance, Quantity = 5 }
            ];
            craftedItem = Items.Loom.Instance;
        }

        public static LoomRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LoomRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ArtisanWorkBenchRecipe : CarpentryCraftingRecipe
    {
        private static ArtisanWorkBenchRecipe? instance = null;
        private static readonly object locker = new object();

        ArtisanWorkBenchRecipe()
        {
            name = "Artisan Work Bench";
            tax = 8400;
            experience = 140000;
            materials =
            [
                new Material() { Item = Carpentry.Items.SturdyPlank.Instance, Quantity = 65 },
                new Material() { Item = Blacksmithing.Items.Nail.Instance, Quantity = 5 },
                new Material() { Item = Blacksmithing.Items.CobaltIngot.Instance, Quantity = 50 },
                new Material() { Item = Blacksmithing.Items.TitaniumIngot.Instance, Quantity = 30 }
            ];
            craftedItem = Items.ArtisanWorkBench.Instance;
        }

        public static ArtisanWorkBenchRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ArtisanWorkBenchRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ArmoiresRecipe : CarpentryCraftingRecipe
    {
        private static ArmoiresRecipe? instance = null;
        private static readonly object locker = new object();

        ArmoiresRecipe()
        {
            name = "Armoires";
            tax = 924;
            experience = 15400;
            materials =
            [
                new Material() { Item = Carpentry.Items.SturdyPlank.Instance, Quantity = 10 },
                new Material() { Item = Blacksmithing.Items.Bolt.Instance, Quantity = 5 }
            ];
            craftedItem = Items.Armoires.Instance;
        }

        public static ArmoiresRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ArmoiresRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SturdySquareTableRecipe : CarpentryCraftingRecipe
    {
        private static SturdySquareTableRecipe? instance = null;
        private static readonly object locker = new object();

        SturdySquareTableRecipe()
        {
            name = "Sturdy Square Table";
            tax = 2280;
            experience = 38000;
            materials =
            [
                new Material() { Item = Carpentry.Items.SturdyPlank.Instance, Quantity = 25 },
                new Material() { Item = Blacksmithing.Items.Bolt.Instance, Quantity = 5 }
            ];
            craftedItem = Items.SturdySquareTable.Instance;
        }

        public static SturdySquareTableRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SturdySquareTableRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class FireplaceRecipe : CarpentryCraftingRecipe
    {
        private static FireplaceRecipe? instance = null;
        private static readonly object locker = new object();

        FireplaceRecipe()
        {
            name = "Fireplace";
            tax = 1656;
            experience = 27600;
            materials =
            [
                new Material() { Item = Carpentry.Items.SturdyPlank.Instance, Quantity = 18 },
                new Material() { Item = Mining.Items.Stone.Instance, Quantity = 10 },
                new Material() { Item = Mining.Items.Coal.Instance, Quantity = 5 }
            ];
            craftedItem = Items.Fireplace.Instance;
        }

        public static FireplaceRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FireplaceRecipe();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Ship Craft
    public sealed class MastRecipe : CarpentryCraftingRecipe
    {
        private static MastRecipe? instance = null;
        private static readonly object locker = new object();

        MastRecipe()
        {
            name = "Mast";
            tax = 1200;
            experience = 20000;
            materials =
            [
                new Material() { Item = Carpentry.Items.RefinedPlank.Instance, Quantity = 20 },
                new Material() { Item = Blacksmithing.Items.Nail.Instance, Quantity = 20 },
                new Material() { Item = Blacksmithing.Items.IronIngot.Instance, Quantity = 5 }
            ];
            craftedItem = Items.Mast.Instance;
        }

        public static MastRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MastRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SmallGunDeckRecipe : CarpentryCraftingRecipe
    {
        private static SmallGunDeckRecipe? instance = null;
        private static readonly object locker = new object();

        SmallGunDeckRecipe()
        {
            name = "Small Gun Deck";
            tax = 1776;
            experience = 29600;
            materials =
            [
                new Material() { Item = Carpentry.Items.RefinedPlank.Instance, Quantity = 30 },
                new Material() { Item = Blacksmithing.Items.Nail.Instance, Quantity = 20 },
                new Material() { Item = Blacksmithing.Items.IronIngot.Instance, Quantity = 8 }
            ];
            craftedItem = Items.SmallGunDeck.Instance;
        }

        public static SmallGunDeckRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallGunDeckRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SmallFishingStorageRecipe : CarpentryCraftingRecipe
    {
        private static SmallFishingStorageRecipe? instance = null;
        private static readonly object locker = new object();

        SmallFishingStorageRecipe()
        {
            name = "Small Fishing Storage";
            tax = 1776;
            experience = 29600;
            materials =
            [
                new Material() { Item = Carpentry.Items.RefinedPlank.Instance, Quantity = 30 },
                new Material() { Item = Blacksmithing.Items.Nail.Instance, Quantity = 20 },
                new Material() { Item = Blacksmithing.Items.IronIngot.Instance, Quantity = 8 }
            ];
            craftedItem = Items.SmallFishingStorage.Instance;
        }

        public static SmallFishingStorageRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallFishingStorageRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SmallCargoHoldRecipe : CarpentryCraftingRecipe
    {
        private static SmallCargoHoldRecipe? instance = null;
        private static readonly object locker = new object();

        SmallCargoHoldRecipe()
        {
            name = "Small Cargo Hold";
            tax = 1776;
            experience = 29600;
            materials =
            [
                new Material() { Item = Carpentry.Items.RefinedPlank.Instance, Quantity = 30 },
                new Material() { Item = Blacksmithing.Items.Nail.Instance, Quantity = 20 },
                new Material() { Item = Blacksmithing.Items.IronIngot.Instance, Quantity = 8 }
            ];
            craftedItem = Items.SmallCargoHold.Instance;
        }

        public static SmallCargoHoldRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallCargoHoldRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SmallHullFrameRecipe : CarpentryCraftingRecipe
    {
        private static SmallHullFrameRecipe? instance = null;
        private static readonly object locker = new object();

        SmallHullFrameRecipe()
        {
            name = "Small Hull Frame";
            tax = 2928;
            experience = 48800;
            materials =
            [
                new Material() { Item = Carpentry.Items.RefinedPlank.Instance, Quantity = 50 },
                new Material() { Item = Blacksmithing.Items.Nail.Instance, Quantity = 40 },
                new Material() { Item = Blacksmithing.Items.IronIngot.Instance, Quantity = 10 }
            ];
            craftedItem = Items.SmallHullFrame.Instance;
        }

        public static SmallHullFrameRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallHullFrameRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumGunDeckRecipe : CarpentryCraftingRecipe
    {
        private static MediumGunDeckRecipe? instance = null;
        private static readonly object locker = new object();

        MediumGunDeckRecipe()
        {
            name = "Medium Gun Deck";
            tax = 5280;
            experience = 88000;
            materials =
            [
                new Material() { Item = Carpentry.Items.TreatedPlank.Instance, Quantity = 50 },
                new Material() { Item = Blacksmithing.Items.Nail.Instance, Quantity = 40 },
                new Material() { Item = Blacksmithing.Items.IronBar.Instance, Quantity = 10 },
                new Material() { Item = Carpentry.Items.WoodenArch.Instance, Quantity = 3 }
            ];
            craftedItem = Items.MediumGunDeck.Instance;
        }

        public static MediumGunDeckRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumGunDeckRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumFishingStorageRecipe : CarpentryCraftingRecipe
    {
        private static MediumFishingStorageRecipe? instance = null;
        private static readonly object locker = new object();

        MediumFishingStorageRecipe()
        {
            name = "Medium Fishing Storage";
            tax = 5280;
            experience = 88000;
            materials =
            [
                new Material() { Item = Carpentry.Items.TreatedPlank.Instance, Quantity = 50 },
                new Material() { Item = Blacksmithing.Items.Nail.Instance, Quantity = 40 },
                new Material() { Item = Blacksmithing.Items.IronBar.Instance, Quantity = 10 },
                new Material() { Item = Carpentry.Items.WoodenArch.Instance, Quantity = 3 }
            ];
            craftedItem = Items.MediumFishingStorage.Instance;
        }

        public static MediumFishingStorageRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumFishingStorageRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumHullFrameRecipe : CarpentryCraftingRecipe
    {
        private static MediumHullFrameRecipe? instance = null;
        private static readonly object locker = new object();

        MediumHullFrameRecipe()
        {
            name = "Medium Hull Frame";
            tax = 12720;
            experience = 212000;
            materials =
            [
                new Material() { Item = Carpentry.Items.TreatedPlank.Instance, Quantity = 120 },
                new Material() { Item = Blacksmithing.Items.Nail.Instance, Quantity = 80 },
                new Material() { Item = Blacksmithing.Items.IronBar.Instance, Quantity = 25 },
                new Material() { Item = Carpentry.Items.WoodenArch.Instance, Quantity = 8 }
            ];
            craftedItem = Items.MediumHullFrame.Instance;
        }

        public static MediumHullFrameRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumHullFrameRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumCargoHoldRecipe : CarpentryCraftingRecipe
    {
        private static MediumCargoHoldRecipe? instance = null;
        private static readonly object locker = new object();

        MediumCargoHoldRecipe()
        {
            name = "Medium Cargo Hold";
            tax = 5280;
            experience = 88000;
            materials =
            [
                new Material() { Item = Carpentry.Items.TreatedPlank.Instance, Quantity = 50 },
                new Material() { Item = Blacksmithing.Items.Nail.Instance, Quantity = 40 },
                new Material() { Item = Blacksmithing.Items.IronBar.Instance, Quantity = 10 },
                new Material() { Item = Carpentry.Items.WoodenArch.Instance, Quantity = 3 }
            ];
            craftedItem = Items.MediumCargoHold.Instance;
        }

        public static MediumCargoHoldRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumCargoHoldRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LargeCargoHoldRecipe : CarpentryCraftingRecipe
    {
        private static LargeCargoHoldRecipe? instance = null;
        private static readonly object locker = new object();

        LargeCargoHoldRecipe()
        {
            name = "Large Cargo Hold";
            tax = 18720;
            experience = 312000;
            materials =
            [
                new Material() { Item = Carpentry.Items.SturdyPlank.Instance, Quantity = 160 },
                new Material() { Item = Blacksmithing.Items.Bolt.Instance, Quantity = 80 },
                new Material() { Item = Blacksmithing.Items.SteelBar.Instance, Quantity = 20 },
                new Material() { Item = Carpentry.Items.SuppleWoodenArch.Instance, Quantity = 8 }
            ];
            craftedItem = Items.LargeCargoHold.Instance;
        }

        public static LargeCargoHoldRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LargeCargoHoldRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LargeGunDeckRecipe : CarpentryCraftingRecipe
    {
        private static LargeGunDeckRecipe? instance = null;
        private static readonly object locker = new object();

        LargeGunDeckRecipe()
        {
            name = "Large Gun Deck";
            tax = 18720;
            experience = 312000;
            materials =
            [
                new Material() { Item = Carpentry.Items.SturdyPlank.Instance, Quantity = 160 },
                new Material() { Item = Blacksmithing.Items.Bolt.Instance, Quantity = 80 },
                new Material() { Item = Blacksmithing.Items.SteelBar.Instance, Quantity = 20 },
                new Material() { Item = Carpentry.Items.SuppleWoodenArch.Instance, Quantity = 8 }
            ];
            craftedItem = Items.LargeGunDeck.Instance;
        }

        public static LargeGunDeckRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LargeGunDeckRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LargeFishingStorageRecipe : CarpentryCraftingRecipe
    {
        private static LargeFishingStorageRecipe? instance = null;
        private static readonly object locker = new object();

        LargeFishingStorageRecipe()
        {
            name = "Large Fishing Storage";
            tax = 18720;
            experience = 312000;
            materials =
            [
                new Material() { Item = Carpentry.Items.SturdyPlank.Instance, Quantity = 160 },
                new Material() { Item = Blacksmithing.Items.Bolt.Instance, Quantity = 80 },
                new Material() { Item = Blacksmithing.Items.SteelBar.Instance, Quantity = 20 },
                new Material() { Item = Carpentry.Items.SuppleWoodenArch.Instance, Quantity = 8 }
            ];
            craftedItem = Items.LargeFishingStorage.Instance;
        }

        public static LargeFishingStorageRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LargeFishingStorageRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LargeHullFrameRecipe : CarpentryCraftingRecipe
    {
        private static LargeHullFrameRecipe? instance = null;
        private static readonly object locker = new object();

        LargeHullFrameRecipe()
        {
            name = "LargeHullFrame";
            tax = 37500;
            experience = 625000;
            materials =
            [
                new Material() { Item = Carpentry.Items.SturdyPlank.Instance, Quantity = 300 },
                new Material() { Item = Blacksmithing.Items.Bolt.Instance, Quantity = 150 },
                new Material() { Item = Blacksmithing.Items.SteelBar.Instance, Quantity = 50 },
                new Material() { Item = Carpentry.Items.SuppleWoodenArch.Instance, Quantity = 20 }
            ];
            craftedItem = Items.LargeHullFrame.Instance;
        }

        public static LargeHullFrameRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LargeHullFrameRecipe();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Ship Module
    public sealed class SmallAmmunitionCabinKitRecipe : CarpentryCraftingRecipe
    {
        private static SmallAmmunitionCabinKitRecipe? instance = null;
        private static readonly object locker = new object();

        SmallAmmunitionCabinKitRecipe()
        {
            name = "Small Ammunition Cabin Kit";
            tax = 4920;
            experience = 82000;
            materials =
            [
                new Material() { Item = Carpentry.Items.TreatedPlank.Instance, Quantity = 50 },
                new Material() { Item = Blacksmithing.Items.Bolt.Instance, Quantity = 10 },
                new Material() { Item = Blacksmithing.Items.SteelIngot.Instance, Quantity = 10 },
                new Material() { Item = Carpentry.Items.WoodenArch.Instance, Quantity = 2 }
            ];
            craftedItem = Items.SmallAmmunitionCabinKit.Instance;
        }

        public static SmallAmmunitionCabinKitRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallAmmunitionCabinKitRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SmallMaintenanceUnitKitRecipe : CarpentryCraftingRecipe
    {
        private static SmallMaintenanceUnitKitRecipe? instance = null;
        private static readonly object locker = new object();

        SmallMaintenanceUnitKitRecipe()
        {
            name = "Small Maintenance Unit Kit";
            tax = 4920;
            experience = 82000;
            materials =
            [
                new Material() { Item = Carpentry.Items.TreatedPlank.Instance, Quantity = 50 },
                new Material() { Item = Blacksmithing.Items.Bolt.Instance, Quantity = 10 },
                new Material() { Item = Blacksmithing.Items.SteelIngot.Instance, Quantity = 10 },
                new Material() { Item = Carpentry.Items.WoodenArch.Instance, Quantity = 2 }
            ];
            craftedItem = Items.SmallMaintenanceUnitKit.Instance;
        }

        public static SmallMaintenanceUnitKitRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallMaintenanceUnitKitRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SmallFishingCraneKitRecipe : CarpentryCraftingRecipe
    {
        private static SmallFishingCraneKitRecipe? instance = null;
        private static readonly object locker = new object();

        SmallFishingCraneKitRecipe()
        {
            name = "Small Fishing Crane Kit";
            tax = 4920;
            experience = 82000;
            materials =
            [
                new Material() { Item = Carpentry.Items.TreatedPlank.Instance, Quantity = 50 },
                new Material() { Item = Blacksmithing.Items.Bolt.Instance, Quantity = 10 },
                new Material() { Item = Blacksmithing.Items.SteelIngot.Instance, Quantity = 10 },
                new Material() { Item = Carpentry.Items.WoodenArch.Instance, Quantity = 2 }
            ];
            craftedItem = Items.SmallFishingCraneKit.Instance;
        }

        public static SmallFishingCraneKitRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallFishingCraneKitRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SmallTradepackContainerKitRecipe : CarpentryCraftingRecipe
    {
        private static SmallTradepackContainerKitRecipe? instance = null;
        private static readonly object locker = new object();

        SmallTradepackContainerKitRecipe()
        {
            name = "Small Tradepack Container Kit";
            tax = 4920;
            experience = 82000;
            materials =
            [
                new Material() { Item = Carpentry.Items.TreatedPlank.Instance, Quantity = 50 },
                new Material() { Item = Blacksmithing.Items.Bolt.Instance, Quantity = 10 },
                new Material() { Item = Blacksmithing.Items.SteelIngot.Instance, Quantity = 10 },
                new Material() { Item = Carpentry.Items.WoodenArch.Instance, Quantity = 2 }
            ];
            craftedItem = Items.SmallTradepackContainerKit.Instance;
        }

        public static SmallTradepackContainerKitRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallTradepackContainerKitRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumTradepackContainerKitRecipe : CarpentryCraftingRecipe
    {
        private static MediumTradepackContainerKitRecipe? instance = null;
        private static readonly object locker = new object();

        MediumTradepackContainerKitRecipe()
        {
            name = "Medium Tradepack Container Kit";
            tax = 14700;
            experience = 245000;
            materials =
            [
                new Material() { Item = Carpentry.Items.SturdyPlank.Instance, Quantity = 135 },
                new Material() { Item = Blacksmithing.Items.Bolt.Instance, Quantity = 30 },
                new Material() { Item = Blacksmithing.Items.CobaltIngot.Instance, Quantity = 20 },
                new Material() { Item = Carpentry.Items.SuppleWoodenArch.Instance, Quantity = 4 }
            ];
            craftedItem = Items.MediumTradepackContainerKit.Instance;
        }

        public static MediumTradepackContainerKitRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumTradepackContainerKitRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumMaintenanceUnitKitRecipe : CarpentryCraftingRecipe
    {
        private static MediumMaintenanceUnitKitRecipe? instance = null;
        private static readonly object locker = new object();

        MediumMaintenanceUnitKitRecipe()
        {
            name = "Medium Maintenance Unit Kit";
            tax = 14700;
            experience = 245000;
            materials =
            [
                new Material() { Item = Carpentry.Items.SturdyPlank.Instance, Quantity = 135 },
                new Material() { Item = Blacksmithing.Items.Bolt.Instance, Quantity = 30 },
                new Material() { Item = Blacksmithing.Items.CobaltIngot.Instance, Quantity = 20 },
                new Material() { Item = Carpentry.Items.SuppleWoodenArch.Instance, Quantity = 4 }
            ];
            craftedItem = Items.MediumMaintenanceUnitKit.Instance;
        }

        public static MediumMaintenanceUnitKitRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumMaintenanceUnitKitRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumAmmunitionCabinKitRecipe : CarpentryCraftingRecipe
    {
        private static MediumAmmunitionCabinKitRecipe? instance = null;
        private static readonly object locker = new object();

        MediumAmmunitionCabinKitRecipe()
        {
            name = "Medium Ammunition Cabin Kit";
            tax = 14700;
            experience = 245000;
            materials =
            [
                new Material() { Item = Carpentry.Items.SturdyPlank.Instance, Quantity = 135 },
                new Material() { Item = Blacksmithing.Items.Bolt.Instance, Quantity = 30 },
                new Material() { Item = Blacksmithing.Items.CobaltIngot.Instance, Quantity = 20 },
                new Material() { Item = Carpentry.Items.SuppleWoodenArch.Instance, Quantity = 4 }
            ];
            craftedItem = Items.MediumAmmunitionCabinKit.Instance;
        }

        public static MediumAmmunitionCabinKitRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumAmmunitionCabinKitRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumFishingCraneKitRecipe : CarpentryCraftingRecipe
    {
        private static MediumFishingCraneKitRecipe? instance = null;
        private static readonly object locker = new object();

        MediumFishingCraneKitRecipe()
        {
            name = "Medium Fishing Crane Kit";
            tax = 14700;
            experience = 245000;
            materials =
            [
                new Material() { Item = Carpentry.Items.SturdyPlank.Instance, Quantity = 135 },
                new Material() { Item = Blacksmithing.Items.Bolt.Instance, Quantity = 30 },
                new Material() { Item = Blacksmithing.Items.CobaltIngot.Instance, Quantity = 20 },
                new Material() { Item = Carpentry.Items.SuppleWoodenArch.Instance, Quantity = 4 }
            ];
            craftedItem = Items.MediumFishingCraneKit.Instance;
        }

        public static MediumFishingCraneKitRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumFishingCraneKitRecipe();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Wagon Craft
    public sealed class CommonWheelRecipe : CarpentryCraftingRecipe
    {
        private static CommonWheelRecipe? instance = null;
        private static readonly object locker = new object();

        CommonWheelRecipe()
        {
            name = "Common Wheel";
            tax = 96;
            experience = 1600;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 10 },
                new Material() { Item = Blacksmithing.Items.Nail.Instance, Quantity = 5 }
            ];
            craftedItem = Items.CommonWheel.Instance;
        }

        public static CommonWheelRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CommonWheelRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SmallWagonContainerRecipe : CarpentryCraftingRecipe
    {
        private static SmallWagonContainerRecipe? instance = null;
        private static readonly object locker = new object();

        SmallWagonContainerRecipe()
        {
            name = "Small Wagon Container";
            tax = 672;
            experience = 11200;
            materials =
            [
                new Material() { Item = Carpentry.Items.RoughPlank.Instance, Quantity = 20 },
                new Material() { Item = Blacksmithing.Items.CommonPlate.Instance, Quantity = 1 }
            ];
            craftedItem = Items.SmallWagonContainer.Instance;
        }

        public static SmallWagonContainerRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallWagonContainerRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WoodenArchRecipe : CarpentryCraftingRecipe
    {
        private static WoodenArchRecipe? instance = null;
        private static readonly object locker = new object();

        WoodenArchRecipe()
        {
            name = "Wooden Arch";
            tax = 288;
            experience = 4800;
            materials =
            [
                new Material() { Item = Carpentry.Items.RefinedPlank.Instance, Quantity = 15 },
                new Material() { Item = Cooking.Items.Oil.Instance, Quantity = 10 }
            ];
            craftedItem = Items.WoodenArch.Instance;
        }

        public static WoodenArchRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WoodenArchRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SwiftWheelRecipe : CarpentryCraftingRecipe
    {
        private static SwiftWheelRecipe? instance = null;
        private static readonly object locker = new object();

        SwiftWheelRecipe()
        {
            name = "Swift Wheel";
            tax = 183;
            experience = 3040;
            materials =
            [
                new Material() { Item = Carpentry.Items.RefinedPlank.Instance, Quantity = 10 },
                new Material() { Item = Blacksmithing.Items.Nail.Instance, Quantity = 5 }
            ];
            craftedItem = Items.SwiftWheel.Instance;
        }

        public static SwiftWheelRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SwiftWheelRecipe();
                    }

                    return instance;
                }
            }
        }
    }


    public sealed class CommonWagonContainerRecipe : CarpentryCraftingRecipe
    {
        private static CommonWagonContainerRecipe? instance = null;
        private static readonly object locker = new object();

        CommonWagonContainerRecipe()
        {
            name = "Common Wagon Container";
            tax = 1752;
            experience = 29200;
            materials =
            [
                new Material() { Item = Carpentry.Items.RefinedPlank.Instance, Quantity = 25 },
                new Material() { Item = Blacksmithing.Items.CommonPlate.Instance, Quantity = 3 }
            ];
            craftedItem = Items.CommonWagonContainer.Instance;
        }

        public static CommonWagonContainerRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CommonWagonContainerRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SturdyWheelRecipe : CarpentryCraftingRecipe
    {
        private static SturdyWheelRecipe? instance = null;
        private static readonly object locker = new object();

        SturdyWheelRecipe()
        {
            name = "Sturdy Wheel";
            tax = 528;
            experience = 8800;
            materials =
            [
                new Material() { Item = Carpentry.Items.TreatedPlank.Instance, Quantity = 16 },
                new Material() { Item = Blacksmithing.Items.Bolt.Instance, Quantity = 5 },
                new Material() { Item = Carpentry.Items.WoodenArch.Instance, Quantity = 1 }
            ];
            craftedItem = Items.SturdyWheel.Instance;
        }

        public static SturdyWheelRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SturdyWheelRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumWagonContainerRecipe : CarpentryCraftingRecipe
    {
        private static MediumWagonContainerRecipe? instance = null;
        private static readonly object locker = new object();

        MediumWagonContainerRecipe()
        {
            name = "Medium Wagon Container";
            tax = 3456;
            experience = 57600;
            materials =
            [
                new Material() { Item = Carpentry.Items.TreatedPlank.Instance, Quantity = 20 },
                new Material() { Item = Blacksmithing.Items.ReinforcedPlate.Instance, Quantity = 5 },
                new Material() { Item = Blacksmithing.Items.IronBar.Instance, Quantity = 5 }
            ];
            craftedItem = Items.MediumWagonContainer.Instance;
        }

        public static MediumWagonContainerRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumWagonContainerRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SuppleWoodenArchRecipe : CarpentryCraftingRecipe
    {
        private static SuppleWoodenArchRecipe? instance = null;
        private static readonly object locker = new object();

        SuppleWoodenArchRecipe()
        {
            name = "Supple Wooden Arch";
            tax = 456;
            experience = 7600;
            materials =
            [
                new Material() { Item = Carpentry.Items.TreatedPlank.Instance, Quantity = 15 },
                new Material() { Item = Cooking.Items.Oil.Instance, Quantity = 20 }
            ];
            craftedItem = Items.SuppleWoodenArch.Instance;
        }

        public static SuppleWoodenArchRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SuppleWoodenArchRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ReinforcedWheelRecipe : CarpentryCraftingRecipe
    {
        private static ReinforcedWheelRecipe? instance = null;
        private static readonly object locker = new object();

        ReinforcedWheelRecipe()
        {
            name = "Reinforced Wheel";
            tax = 1680;
            experience = 28000;
            materials =
            [
                new Material() { Item = Carpentry.Items.SturdyPlank.Instance, Quantity = 50 },
                new Material() { Item = Blacksmithing.Items.Bolt.Instance, Quantity = 10 },
                new Material() { Item = Carpentry.Items.SuppleWoodenArch.Instance, Quantity = 1 }
            ];
            craftedItem = Items.ReinforcedWheel.Instance;
        }

        public static ReinforcedWheelRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ReinforcedWheelRecipe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LargeWagonContainerRecipe : CarpentryCraftingRecipe
    {
        private static LargeWagonContainerRecipe? instance = null;
        private static readonly object locker = new object();

        LargeWagonContainerRecipe()
        {
            name = "Large Wagon Container";
            tax = 8784;
            experience = 146400;
            materials =
            [
                new Material() { Item = Carpentry.Items.SturdyPlank.Instance, Quantity = 35 },
                new Material() { Item = Blacksmithing.Items.ReinforcedPlate.Instance, Quantity = 15 },
                new Material() { Item = Blacksmithing.Items.SteelBar.Instance, Quantity = 10 }
            ];
            craftedItem = Items.LargeWagonContainer.Instance;
        }

        public static LargeWagonContainerRecipe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LargeWagonContainerRecipe();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion
}