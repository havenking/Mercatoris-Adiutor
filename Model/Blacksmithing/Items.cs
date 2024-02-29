namespace MercatorisAdiutor.Model.Blacksmithing.Items
{
    public abstract class BlacksmithingItem : Item
    {
        internal int id = -1;
        internal string name = string.Empty;
        internal string icon = string.Empty;
        internal string description = string.Empty;
        internal int price = 0;

        public int Id => id;

        public string Name => name;

        public string Icon => icon;

        public Profession Profession => Profession.Blacksmithing;

        public Category Category => Category.Crafting;

        public int Price 
        {
            get { return price; }
            set { price = value; }
        }
    }

    #region Ingots
    public sealed class CopperIngot : BlacksmithingItem
    {
        private static CopperIngot? instance = null;
        private static readonly object locker = new object();

        CopperIngot()
        {
            id = 28726;
            name = "Copper Ingot";
            icon = "28726.png";
        }

        public static CopperIngot Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CopperIngot();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class IronIngot : BlacksmithingItem
    {
        private static IronIngot? instance = null;
        private static readonly object locker = new object();

        IronIngot()
        {
            id = 28723;
            name = "Iron Ingot";
            icon = "28723.png";
        }

        public static IronIngot Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new IronIngot();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SteelIngot : BlacksmithingItem
    {
        private static SteelIngot? instance = null;
        private static readonly object locker = new object();

        SteelIngot()
        {
            id = 28724;
            name = "Steel Ingot";
            icon = "28724.png";
        }

        public static SteelIngot Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SteelIngot();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CobaltIngot : BlacksmithingItem
    {
        private static CobaltIngot? instance = null;
        private static readonly object locker = new object();

        CobaltIngot()
        {
            id = 28725;
            name = "Cobalt Ingot";
            icon = "28725.png";
        }

        public static CobaltIngot Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CobaltIngot();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class TitaniumIngot : BlacksmithingItem
    {
        private static TitaniumIngot? instance = null;
        private static readonly object locker = new object();

        TitaniumIngot()
        {
            id = 28727;
            name = "Titanium Ingot";
            icon = "28727.png";
        }

        public static TitaniumIngot Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new TitaniumIngot();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Weapons
    public sealed class ShipbuildingMallet : BlacksmithingItem
    {
        private static ShipbuildingMallet? instance = null;
        private static readonly object locker = new object();

        ShipbuildingMallet()
        {
            id = 29016;
            name = "Shipbuilding Mallet";
            icon = "29016.png";
        }

        public static ShipbuildingMallet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ShipbuildingMallet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class RoughSword : BlacksmithingItem
    {
        private static RoughSword? instance = null;
        private static readonly object locker = new object();

        RoughSword()
        {
            id = 29059;
            name = "Rough Sword";
            icon = "29059.png";
        }

        public static RoughSword Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RoughSword();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SolidMace : BlacksmithingItem
    {
        private static SolidMace? instance = null;
        private static readonly object locker = new object();

        SolidMace()
        {
            id = 29004;
            name = "Solid Mace";
            icon = "29004.png";
        }

        public static SolidMace Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SolidMace();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SerratedDagger : BlacksmithingItem
    {
        private static SerratedDagger? instance = null;
        private static readonly object locker = new object();

        SerratedDagger()
        {
            id = 29010;
            name = "Serrated Dagger";
            icon = "29010.png";
        }

        public static SerratedDagger Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SerratedDagger();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WickedAxe : BlacksmithingItem
    {
        private static WickedAxe? instance = null;
        private static readonly object locker = new object();

        WickedAxe()
        {
            id = 28992;
            name = "Wicked Axe";
            icon = "28992.png";
        }

        public static WickedAxe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WickedAxe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BurnishedGreatsword : BlacksmithingItem
    {
        private static BurnishedGreatsword? instance = null;
        private static readonly object locker = new object();

        BurnishedGreatsword()
        {
            id = 28985;
            name = "Burnished Greatsword";
            icon = "28985.png";
        }

        public static BurnishedGreatsword Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BurnishedGreatsword();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SkirmisherBlade : BlacksmithingItem
    {
        private static SkirmisherBlade? instance = null;
        private static readonly object locker = new object();

        SkirmisherBlade()
        {
            id = 37107;
            name = "Skirmisher's Blade";
            icon = "37107.png";
        }

        public static SkirmisherBlade Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SkirmisherBlade();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class RoughGreataxe : BlacksmithingItem
    {
        private static RoughGreataxe? instance = null;
        private static readonly object locker = new object();

        RoughGreataxe()
        {
            id = 28978;
            name = "Rough Greataxe";
            icon = "28978.png";
        }

        public static RoughGreataxe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RoughGreataxe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ValiantGreatsword : BlacksmithingItem
    {
        private static ValiantGreatsword? instance = null;
        private static readonly object locker = new object();

        ValiantGreatsword()
        {
            id = 28986;
            name = "Valiant Greatsword";
            icon = "28986.png";
        }

        public static ValiantGreatsword Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ValiantGreatsword();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SwashbucklerBlade : BlacksmithingItem
    {
        private static SwashbucklerBlade? instance = null;
        private static readonly object locker = new object();

        SwashbucklerBlade()
        {
            id = 37108;
            name = "Swashbuckler's Blade";
            icon = "37108.png";
        }

        public static SwashbucklerBlade Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SwashbucklerBlade();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WarriorGreataxe : BlacksmithingItem
    {
        private static WarriorGreataxe? instance = null;
        private static readonly object locker = new object();

        WarriorGreataxe()
        {
            id = 28980;
            name = "Warrior's Greataxe";
            icon = "28980.png";
        }

        public static WarriorGreataxe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WarriorGreataxe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CrushingHammer : BlacksmithingItem
    {
        private static CrushingHammer? instance = null;
        private static readonly object locker = new object();

        CrushingHammer()
        {
            id = 29017;
            name = "Crushing Hammer";
            icon = "29017.png";
        }

        public static CrushingHammer Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CrushingHammer();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MarauderAxe : BlacksmithingItem
    {
        private static MarauderAxe? instance = null;
        private static readonly object locker = new object();

        MarauderAxe()
        {
            id = 28993;
            name = "Marauder's Axe";
            icon = "28993.png";
        }

        public static MarauderAxe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MarauderAxe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class StuddedFlail : BlacksmithingItem
    {
        private static StuddedFlail? instance = null;
        private static readonly object locker = new object();

        StuddedFlail()
        {
            id = 29005;
            name = "Studded Flail";
            icon = "29005.png";
        }

        public static StuddedFlail Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new StuddedFlail();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WardenSword : BlacksmithingItem
    {
        private static WardenSword? instance = null;
        private static readonly object locker = new object();

        WardenSword()
        {
            id = 29060;
            name = "Warden's Sword";
            icon = "29060.png";
        }

        public static WardenSword Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WardenSword();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class NobleDagger : BlacksmithingItem
    {
        private static NobleDagger? instance = null;
        private static readonly object locker = new object();

        NobleDagger()
        {
            id = 29011;
            name = "Noble Dagger";
            icon = "29011.png";
        }

        public static NobleDagger Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new NobleDagger();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LawbreakerSword : BlacksmithingItem
    {
        private static LawbreakerSword? instance = null;
        private static readonly object locker = new object();

        LawbreakerSword()
        {
            id = 29061;
            name = "Lawbreaker's Sword";
            icon = "29061.png";
        }

        public static LawbreakerSword Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LawbreakerSword();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SerpentineBlade : BlacksmithingItem
    {
        private static SerpentineBlade? instance = null;
        private static readonly object locker = new object();

        SerpentineBlade()
        {
            id = 37109;
            name = "Serpentine Blade";
            icon = "37109.png";
        }

        public static SerpentineBlade Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SerpentineBlade();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class DreadAxe : BlacksmithingItem
    {
        private static DreadAxe? instance = null;
        private static readonly object locker = new object();

        DreadAxe()
        {
            id = 28994;
            name = "Dread Axe";
            icon = "28994.png";
        }

        public static DreadAxe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new DreadAxe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class HeroicGreatsword : BlacksmithingItem
    {
        private static HeroicGreatsword? instance = null;
        private static readonly object locker = new object();

        HeroicGreatsword()
        {
            id = 28987;
            name = "Heroic Greatsword";
            icon = "28987.png";
        }

        public static HeroicGreatsword Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new HeroicGreatsword();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class PunisherGavel : BlacksmithingItem
    {
        private static PunisherGavel? instance = null;
        private static readonly object locker = new object();

        PunisherGavel()
        {
            id = 29018;
            name = "Punisher's Gavel";
            icon = "29018.png";
        }

        public static PunisherGavel Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new PunisherGavel();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class IceDagger : BlacksmithingItem
    {
        private static IceDagger? instance = null;
        private static readonly object locker = new object();

        IceDagger()
        {
            id = 29012;
            name = "Ice Dagger";
            icon = "29012.png";
        }

        public static IceDagger Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new IceDagger();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SavageBattleAxe : BlacksmithingItem
    {
        private static SavageBattleAxe? instance = null;
        private static readonly object locker = new object();

        SavageBattleAxe()
        {
            id = 28981;
            name = "Savage Battle Axe";
            icon = "28981.png";
        }

        public static SavageBattleAxe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SavageBattleAxe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ShieldbreakerFlail : BlacksmithingItem
    {
        private static ShieldbreakerFlail? instance = null;
        private static readonly object locker = new object();

        ShieldbreakerFlail()
        {
            id = 29006;
            name = "Shieldbreaker's Flail";
            icon = "29006.png";
        }

        public static ShieldbreakerFlail Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ShieldbreakerFlail();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class HeartstopperDagger : BlacksmithingItem
    {
        private static HeartstopperDagger? instance = null;
        private static readonly object locker = new object();

        HeartstopperDagger()
        {
            id = 29013;
            name = "Heartstopper Dagger";
            icon = "29013.png";
        }

        public static HeartstopperDagger Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new HeartstopperDagger();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class HangmanGreataxe : BlacksmithingItem
    {
        private static HangmanGreataxe? instance = null;
        private static readonly object locker = new object();

        HangmanGreataxe()
        {
            id = 28982;
            name = "Hangman's Greataxe";
            icon = "28982.png";
        }

        public static HangmanGreataxe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new HangmanGreataxe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LawgiverWarhammer : BlacksmithingItem
    {
        private static LawgiverWarhammer? instance = null;
        private static readonly object locker = new object();

        LawgiverWarhammer()
        {
            id = 29019;
            name = "Lawgiver's Warhammer";
            icon = "29019.png";
        }

        public static LawgiverWarhammer Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LawgiverWarhammer();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class RavenguardMorningstar : BlacksmithingItem
    {
        private static RavenguardMorningstar? instance = null;
        private static readonly object locker = new object();

        RavenguardMorningstar()
        {
            id = 29007;
            name = "Ravenguard Morningstar";
            icon = "29007.png";
        }

        public static RavenguardMorningstar Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RavenguardMorningstar();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class StormcarverAxe : BlacksmithingItem
    {
        private static StormcarverAxe? instance = null;
        private static readonly object locker = new object();

        StormcarverAxe()
        {
            id = 28995;
            name = "Stormcarver Axe";
            icon = "28995.png";
        }

        public static StormcarverAxe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new StormcarverAxe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BonebiterGreatsword : BlacksmithingItem
    {
        private static BonebiterGreatsword? instance = null;
        private static readonly object locker = new object();

        BonebiterGreatsword()
        {
            id = 28988;
            name = "Bonebiter Greatsword";
            icon = "28988.png";
        }

        public static BonebiterGreatsword Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BonebiterGreatsword();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class DuelistCompanion : BlacksmithingItem
    {
        private static DuelistCompanion? instance = null;
        private static readonly object locker = new object();

        DuelistCompanion()
        {
            id = 37110;
            name = "Duelist's Companion";
            icon = "37110.png";
        }

        public static DuelistCompanion Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new DuelistCompanion();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class GuardianLongsword : BlacksmithingItem
    {
        private static GuardianLongsword? instance = null;
        private static readonly object locker = new object();

        GuardianLongsword()
        {
            id = 29062;
            name = "Guardian's Longsword";
            icon = "29062.png";
        }

        public static GuardianLongsword Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new GuardianLongsword();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class OrnamentedSaber : BlacksmithingItem
    {
        private static OrnamentedSaber? instance = null;
        private static readonly object locker = new object();

        OrnamentedSaber()
        {
            id = 37111;
            name = "Ornamented Saber";
            icon = "37111.png";
        }

        public static OrnamentedSaber Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new OrnamentedSaber();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SamuraiDaikatana : BlacksmithingItem
    {
        private static SamuraiDaikatana? instance = null;
        private static readonly object locker = new object();

        SamuraiDaikatana()
        {
            id = 28989;
            name = "Samurai's Daikatana";
            icon = "28989.png";
        }

        public static SamuraiDaikatana Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SamuraiDaikatana();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class DwarvenWarhammer : BlacksmithingItem
    {
        private static DwarvenWarhammer? instance = null;
        private static readonly object locker = new object();

        DwarvenWarhammer()
        {
            id = 29020;
            name = "Dwarven Warhammer";
            icon = "29020.png";
        }

        public static DwarvenWarhammer Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new DwarvenWarhammer();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CrusaderLongsword : BlacksmithingItem
    {
        private static CrusaderLongsword? instance = null;
        private static readonly object locker = new object();

        CrusaderLongsword()
        {
            id = 29063;
            name = "Crusader's Longsword";
            icon = "29063.png";
        }

        public static CrusaderLongsword Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CrusaderLongsword();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class EnforcerMace : BlacksmithingItem
    {
        private static EnforcerMace? instance = null;
        private static readonly object locker = new object();

        EnforcerMace()
        {
            id = 29008;
            name = "Enforcer's Mace";
            icon = "29008.png";
        }

        public static EnforcerMace Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new EnforcerMace();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class OrcishBattleAxe : BlacksmithingItem
    {
        private static OrcishBattleAxe? instance = null;
        private static readonly object locker = new object();

        OrcishBattleAxe()
        {
            id = 28983;
            name = "Orcish Battle Axe";
            icon = "28983.png";
        }

        public static OrcishBattleAxe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new OrcishBattleAxe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class AssassinDagger : BlacksmithingItem
    {
        private static AssassinDagger? instance = null;
        private static readonly object locker = new object();

        AssassinDagger()
        {
            id = 29014;
            name = "Assassin's Dagger";
            icon = "29014.png";
        }

        public static AssassinDagger Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new AssassinDagger();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class HellbladeAxe : BlacksmithingItem
    {
        private static HellbladeAxe? instance = null;
        private static readonly object locker = new object();

        HellbladeAxe()
        {
            id = 28996;
            name = "Hellblade Axe";
            icon = "28996.png";
        }

        public static HellbladeAxe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new HellbladeAxe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class RitualDagger : BlacksmithingItem
    {
        private static RitualDagger? instance = null;
        private static readonly object locker = new object();

        RitualDagger()
        {
            id = 37151;
            name = "Ritual Dagger";
            icon = "37151.png";
        }

        public static RitualDagger Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RitualDagger();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class DragonbaneAxe : BlacksmithingItem
    {
        private static DragonbaneAxe? instance = null;
        private static readonly object locker = new object();

        DragonbaneAxe()
        {
            id = 37154;
            name = "Dragonbane Axe";
            icon = "37154.png";
        }

        public static DragonbaneAxe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new DragonbaneAxe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SkullbasherMace : BlacksmithingItem
    {
        private static SkullbasherMace? instance = null;
        private static readonly object locker = new object();

        SkullbasherMace()
        {
            id = 37156;
            name = "Skullbasher Mace";
            icon = "37156.png";
        }

        public static SkullbasherMace Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SkullbasherMace();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ChampionLongsword : BlacksmithingItem
    {
        private static ChampionLongsword? instance = null;
        private static readonly object locker = new object();

        ChampionLongsword()
        {
            id = 37158;
            name = "Champion's Longsword";
            icon = "37158.png";
        }

        public static ChampionLongsword Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ChampionLongsword();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MagisterGreatsword : BlacksmithingItem
    {
        private static MagisterGreatsword? instance = null;
        private static readonly object locker = new object();

        MagisterGreatsword()
        {
            id = 37153;
            name = "Magister's Greatsword";
            icon = "37153.png";
        }

        public static MagisterGreatsword Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MagisterGreatsword();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class NocturnalGreataxe : BlacksmithingItem
    {
        private static NocturnalGreataxe? instance = null;
        private static readonly object locker = new object();

        NocturnalGreataxe()
        {
            id = 37148;
            name = "Nocturnal Greataxe";
            icon = "37148.png";
        }

        public static NocturnalGreataxe Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new NocturnalGreataxe();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ScarletThorn : BlacksmithingItem
    {
        private static ScarletThorn? instance = null;
        private static readonly object locker = new object();

        ScarletThorn()
        {
            id = 37112;
            name = "Scarlet Thorn";
            icon = "37112.png";
        }

        public static ScarletThorn Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ScarletThorn();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SoulwardenHammer : BlacksmithingItem
    {
        private static SoulwardenHammer? instance = null;
        private static readonly object locker = new object();

        SoulwardenHammer()
        {
            id = 37152;
            name = "Soulwarden's Hammer";
            icon = "37152.png";
        }

        public static SoulwardenHammer Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SoulwardenHammer();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Armors
    public sealed class PliantArmor : BlacksmithingItem
    {
        private static PliantArmor? instance = null;
        private static readonly object locker = new object();

        PliantArmor()
        {
            id = 28678;
            name = "Pliant Armor";
            icon = "28678.png";
        }

        public static PliantArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new PliantArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class PliantHelmet : BlacksmithingItem
    {
        private static PliantHelmet? instance = null;
        private static readonly object locker = new object();

        PliantHelmet()
        {
            id = 28684;
            name = "Pliant Helmet";
            icon = "28684.png";
        }

        public static PliantHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new PliantHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class PliantLegs : BlacksmithingItem
    {
        private static PliantLegs? instance = null;
        private static readonly object locker = new object();

        PliantLegs()
        {
            id = 28685;
            name = "Pliant Legs";
            icon = "28685.png";
        }

        public static PliantLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new PliantLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class PliantBoots : BlacksmithingItem
    {
        private static PliantBoots? instance = null;
        private static readonly object locker = new object();

        PliantBoots()
        {
            id = 28681;
            name = "Pliant Boots";
            icon = "28681.png";
        }

        public static PliantBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new PliantBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CrescentArmor : BlacksmithingItem
    {
        private static CrescentArmor? instance = null;
        private static readonly object locker = new object();

        CrescentArmor()
        {
            id = 28687;
            name = "Crescent Armor";
            icon = "28687.png";
        }

        public static CrescentArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CrescentArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CrescentHelmet : BlacksmithingItem
    {
        private static CrescentHelmet? instance = null;
        private static readonly object locker = new object();

        CrescentHelmet()
        {
            id = 28688;
            name = "Crescent Helmet";
            icon = "28688.png";
        }

        public static CrescentHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CrescentHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CrescentLegs : BlacksmithingItem
    {
        private static CrescentLegs? instance = null;
        private static readonly object locker = new object();

        CrescentLegs()
        {
            id = 28691;
            name = "Crescent Legs";
            icon = "28691.png";
        }

        public static CrescentLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CrescentLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CrescentBoots : BlacksmithingItem
    {
        private static CrescentBoots? instance = null;
        private static readonly object locker = new object();

        CrescentBoots()
        {
            id = 28695;
            name = "Crescent Boots";
            icon = "28695.png";
        }

        public static CrescentBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CrescentBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class HarbingerArmor : BlacksmithingItem
    {
        private static HarbingerArmor? instance = null;
        private static readonly object locker = new object();

        HarbingerArmor()
        {
            id = 28696;
            name = "Harbinger Armor";
            icon = "28696.png";
        }

        public static HarbingerArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new HarbingerArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class HarbingerHelmet : BlacksmithingItem
    {
        private static HarbingerHelmet? instance = null;
        private static readonly object locker = new object();

        HarbingerHelmet()
        {
            id = 28702;
            name = "Harbinger Helmet";
            icon = "28702.png";
        }

        public static HarbingerHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new HarbingerHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class HarbingerLegs : BlacksmithingItem
    {
        private static HarbingerLegs? instance = null;
        private static readonly object locker = new object();

        HarbingerLegs()
        {
            id = 28703;
            name = "Harbinger Legs";
            icon = "28703.png";
        }

        public static HarbingerLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new HarbingerLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class HarbingerBoots : BlacksmithingItem
    {
        private static HarbingerBoots? instance = null;
        private static readonly object locker = new object();

        HarbingerBoots()
        {
            id = 28699;
            name = "Harbinger Boots";
            icon = "28699.png";
        }

        public static HarbingerBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new HarbingerBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class EnforcerArmor : BlacksmithingItem
    {
        private static EnforcerArmor? instance = null;
        private static readonly object locker = new object();

        EnforcerArmor()
        {
            id = 28705;
            name = "Enforcer Armor";
            icon = "28705.png";
        }

        public static EnforcerArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new EnforcerArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class EnforcerHelmet : BlacksmithingItem
    {
        private static EnforcerHelmet? instance = null;
        private static readonly object locker = new object();

        EnforcerHelmet()
        {
            id = 28711;
            name = "Enforcer Helmet";
            icon = "28711.png";
        }

        public static EnforcerHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new EnforcerHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class EnforcerLegs : BlacksmithingItem
    {
        private static EnforcerLegs? instance = null;
        private static readonly object locker = new object();

        EnforcerLegs()
        {
            id = 28712;
            name = "Enforcer Legs";
            icon = "28712.png";
        }

        public static EnforcerLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new EnforcerLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class EnforcerBoots : BlacksmithingItem
    {
        private static EnforcerBoots? instance = null;
        private static readonly object locker = new object();

        EnforcerBoots()
        {
            id = 28708;
            name = "Enforcer Boots";
            icon = "28708.png";
        }

        public static EnforcerBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new EnforcerBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ProtectorArmor : BlacksmithingItem
    {
        private static ProtectorArmor? instance = null;
        private static readonly object locker = new object();

        ProtectorArmor()
        {
            id = 28714;
            name = "Protector's Armor";
            icon = "28714.png";
        }

        public static ProtectorArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ProtectorArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ProtectorHelmet : BlacksmithingItem
    {
        private static ProtectorHelmet? instance = null;
        private static readonly object locker = new object();

        ProtectorHelmet()
        {
            id = 28720;
            name = "Protector's Helmet";
            icon = "28720.png";
        }

        public static ProtectorHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ProtectorHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ProtectorLegs : BlacksmithingItem
    {
        private static ProtectorLegs? instance = null;
        private static readonly object locker = new object();

        ProtectorLegs()
        {
            id = 28721;
            name = "Protector's Legs";
            icon = "28721.png";
        }

        public static ProtectorLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ProtectorLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ProtectorBoots : BlacksmithingItem
    {
        private static ProtectorBoots? instance = null;
        private static readonly object locker = new object();

        ProtectorBoots()
        {
            id = 28717;
            name = "Protector's Boots";
            icon = "28717.png";
        }

        public static ProtectorBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ProtectorBoots();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ChivalryArmor : BlacksmithingItem
    {
        private static ChivalryArmor? instance = null;
        private static readonly object locker = new object();

        ChivalryArmor()
        {
            id = 37143;
            name = "Chivalry Armor";
            icon = "37143.png";
        }

        public static ChivalryArmor Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ChivalryArmor();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ChivalryHelmet : BlacksmithingItem
    {
        private static ChivalryHelmet? instance = null;
        private static readonly object locker = new object();

        ChivalryHelmet()
        {
            id = 37146;
            name = "Chivalry Helmet";
            icon = "37146.png";
        }

        public static ChivalryHelmet Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ChivalryHelmet();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ChivalryLegs : BlacksmithingItem
    {
        private static ChivalryLegs? instance = null;
        private static readonly object locker = new object();

        ChivalryLegs()
        {
            id = 37145;
            name = "Chivalry Legs";
            icon = "37145.png";
        }

        public static ChivalryLegs Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ChivalryLegs();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ChivalryBoots : BlacksmithingItem
    {
        private static ChivalryBoots? instance = null;
        private static readonly object locker = new object();

        ChivalryBoots()
        {
            id = 37144;
            name = "Chivalry Boots";
            icon = "37144.png";
        }

        public static ChivalryBoots Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ChivalryBoots();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Whetstones
    public sealed class Whetstone : BlacksmithingItem
    {
        private static Whetstone? instance = null;
        private static readonly object locker = new object();

        Whetstone()
        {
            id = 28426;
            name = "Whetstone";
            icon = "28426.png";
        }

        public static Whetstone Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Whetstone();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CoarseWhetstone : BlacksmithingItem
    {
        private static CoarseWhetstone? instance = null;
        private static readonly object locker = new object();

        CoarseWhetstone()
        {
            id = 28427;
            name = "Coarse Whetstone";
            icon = "28427.png";
        }

        public static CoarseWhetstone Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CoarseWhetstone();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class HeavyWhetstone : BlacksmithingItem
    {
        private static HeavyWhetstone? instance = null;
        private static readonly object locker = new object();

        HeavyWhetstone()
        {
            id = 35437;
            name = "Heavy Whetstone";
            icon = "35437.png";
        }

        public static HeavyWhetstone Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new HeavyWhetstone();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SolidWhetstone : BlacksmithingItem
    {
        private static SolidWhetstone? instance = null;
        private static readonly object locker = new object();

        SolidWhetstone()
        {
            id = 35438;
            name = "Solid Whetstone";
            icon = "35438.png";
        }

        public static SolidWhetstone Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SolidWhetstone();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class DenseWhetstone : BlacksmithingItem
    {
        private static DenseWhetstone? instance = null;
        private static readonly object locker = new object();

        DenseWhetstone()
        {
            id = 28428;
            name = "Dense Whetstone";
            icon = "28428.png";
        }

        public static DenseWhetstone Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new DenseWhetstone();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Fishing
    public sealed class CopperFishingHook : BlacksmithingItem
    {
        private static CopperFishingHook? instance = null;
        private static readonly object locker = new object();

        CopperFishingHook()
        {
            id = 28888;
            name = "Copper Fishing Hook";
            icon = "28888.png";
        }

        public static CopperFishingHook Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CopperFishingHook();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ComplexFishingHook : BlacksmithingItem
    {
        private static ComplexFishingHook? instance = null;
        private static readonly object locker = new object();

        ComplexFishingHook()
        {
            id = 28886;
            name = "Complex Fishing Hook";
            icon = "28886.png";
        }

        public static ComplexFishingHook Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ComplexFishingHook();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SteelFishingHook : BlacksmithingItem
    {
        private static SteelFishingHook? instance = null;
        private static readonly object locker = new object();

        SteelFishingHook()
        {
            id = 28884;
            name = "Steel Fishing Hook";
            icon = "28884.png";
        }

        public static SteelFishingHook Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SteelFishingHook();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CobaltFishingHook : BlacksmithingItem
    {
        private static CobaltFishingHook? instance = null;
        private static readonly object locker = new object();

        CobaltFishingHook()
        {
            id = 28887;
            name = "Cobalt Fishing Hook";
            icon = "28887.png";
        }

        public static CobaltFishingHook Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CobaltFishingHook();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class TitaniumFishingHook : BlacksmithingItem
    {
        private static TitaniumFishingHook? instance = null;
        private static readonly object locker = new object();

        TitaniumFishingHook()
        {
            id = 28885;
            name = "Titanium Fishing Hook";
            icon = "28885.png";
        }

        public static TitaniumFishingHook Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new TitaniumFishingHook();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Housing Craft
    public sealed class BasicTools : BlacksmithingItem
    {
        private static BasicTools? instance = null;
        private static readonly object locker = new object();

        BasicTools()
        {
            id = 42784;
            name = "Basic Tools";
            icon = "42784.png";
        }

        public static BasicTools Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BasicTools();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CopperAnvil : BlacksmithingItem
    {
        private static CopperAnvil? instance = null;
        private static readonly object locker = new object();

        CopperAnvil()
        {
            id = 42778;
            name = "Copper Anvil";
            icon = "42778.png";
        }

        public static CopperAnvil Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CopperAnvil();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WeakRacks : BlacksmithingItem
    {
        private static WeakRacks? instance = null;
        private static readonly object locker = new object();

        WeakRacks()
        {
            id = 47288;
            name = "Weak Racks";
            icon = "47288.png";
        }

        public static WeakRacks Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WeakRacks();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class StoneBlock : BlacksmithingItem
    {
        private static StoneBlock? instance = null;
        private static readonly object locker = new object();

        StoneBlock()
        {
            id = 41850;
            name = "Stone Block";
            icon = "41850.png";
        }

        public static StoneBlock Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new StoneBlock();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ArmoryRacks : BlacksmithingItem
    {
        private static ArmoryRacks? instance = null;
        private static readonly object locker = new object();

        ArmoryRacks()
        {
            id = 47276;
            name = "Armory Racks";
            icon = "47276.png";
        }

        public static ArmoryRacks Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ArmoryRacks();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WoodworkTools : BlacksmithingItem
    {
        private static WoodworkTools? instance = null;
        private static readonly object locker = new object();

        WoodworkTools()
        {
            id = 37289;
            name = "Woodwork Tools";
            icon = "37289.png";
        }

        public static WoodworkTools Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WoodworkTools();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Stove : BlacksmithingItem
    {
        private static Stove? instance = null;
        private static readonly object locker = new object();

        Stove()
        {
            id = 37281;
            name = "Stove";
            icon = "37281.png";
        }

        public static Stove Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Stove();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class DenseBlock : BlacksmithingItem
    {
        private static DenseBlock? instance = null;
        private static readonly object locker = new object();

        DenseBlock()
        {
            id = 41846;
            name = "Dense Block";
            icon = "41846.png";
        }

        public static DenseBlock Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new DenseBlock();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ForgingTools : BlacksmithingItem
    {
        private static ForgingTools? instance = null;
        private static readonly object locker = new object();

        ForgingTools()
        {
            id = 37234;
            name = "Forging Tools";
            icon = "37234.png";
        }

        public static ForgingTools Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ForgingTools();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Furnace : BlacksmithingItem
    {
        private static Furnace? instance = null;
        private static readonly object locker = new object();

        Furnace()
        {
            id = 37235;
            name = "Furnace";
            icon = "37235.png";
        }

        public static Furnace Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Furnace();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Anvil : BlacksmithingItem
    {
        private static Anvil? instance = null;
        private static readonly object locker = new object();

        Anvil()
        {
            id = 37217;
            name = "Anvil";
            icon = "37217.png";
        }

        public static Anvil Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Anvil();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class GearMaintenanceTools : BlacksmithingItem
    {
        private static GearMaintenanceTools? instance = null;
        private static readonly object locker = new object();

        GearMaintenanceTools()
        {
            id = 47279;
            name = "Gear Maintenance Tools";
            icon = "47279.png";
        }

        public static GearMaintenanceTools Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new GearMaintenanceTools();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SuperiorForgingTools : BlacksmithingItem
    {
        private static SuperiorForgingTools? instance = null;
        private static readonly object locker = new object();

        SuperiorForgingTools()
        {
            id = 37285;
            name = "Superior Forging Tools";
            icon = "37285.png";
        }

        public static SuperiorForgingTools Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SuperiorForgingTools();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class RoyalOrnaments : BlacksmithingItem
    {
        private static RoyalOrnaments? instance = null;
        private static readonly object locker = new object();

        RoyalOrnaments()
        {
            id = 41849;
            name = "Royal Ornaments";
            icon = "41849.png";
        }

        public static RoyalOrnaments Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RoyalOrnaments();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SuperiorStove : BlacksmithingItem
    {
        private static SuperiorStove? instance = null;
        private static readonly object locker = new object();

        SuperiorStove()
        {
            id = 37286;
            name = "Superior Stove";
            icon = "37286.png";
        }

        public static SuperiorStove Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SuperiorStove();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ReinforcedRacks : BlacksmithingItem
    {
        private static ReinforcedRacks? instance = null;
        private static readonly object locker = new object();

        ReinforcedRacks()
        {
            id = 47281;
            name = "Reinforced Racks";
            icon = "47281.png";
        }

        public static ReinforcedRacks Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ReinforcedRacks();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WarmongerTools : BlacksmithingItem
    {
        private static WarmongerTools? instance = null;
        private static readonly object locker = new object();

        WarmongerTools()
        {
            id = 47287;
            name = "Warmonger Tools";
            icon = "47287.png";
        }

        public static WarmongerTools Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WarmongerTools();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ImprovedWoodworkTools : BlacksmithingItem
    {
        private static ImprovedWoodworkTools? instance = null;
        private static readonly object locker = new object();

        ImprovedWoodworkTools()
        {
            id = 37236;
            name = "Improved Woodwork Tools";
            icon = "37236.png";
        }

        public static ImprovedWoodworkTools Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ImprovedWoodworkTools();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ForgemasterAnvil : BlacksmithingItem
    {
        private static ForgemasterAnvil? instance = null;
        private static readonly object locker = new object();

        ForgemasterAnvil()
        {
            id = 37233;
            name = "Forgemaster Anvil";
            icon = "37233.png";
        }

        public static ForgemasterAnvil Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ForgemasterAnvil();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ThiefTools : BlacksmithingItem
    {
        private static ThiefTools? instance = null;
        private static readonly object locker = new object();

        ThiefTools()
        {
            id = 47283;
            name = "Thief Tools";
            icon = "47283.png";
        }

        public static ThiefTools Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ThiefTools();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Forge : BlacksmithingItem
    {
        private static Forge? instance = null;
        private static readonly object locker = new object();

        Forge()
        {
            id = 37232;
            name = "Forge";
            icon = "37232.png";
        }

        public static Forge Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Forge();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ArtisanStove : BlacksmithingItem
    {
        private static ArtisanStove? instance = null;
        private static readonly object locker = new object();

        ArtisanStove()
        {
            id = 37221;
            name = "Artisan Stove";
            icon = "37221.png";
        }

        public static ArtisanStove Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ArtisanStove();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ArtisanForgingTools : BlacksmithingItem
    {
        private static ArtisanForgingTools? instance = null;
        private static readonly object locker = new object();

        ArtisanForgingTools()
        {
            id = 37220;
            name = "Artisan Forging Tools";
            icon = "37220.png";
        }

        public static ArtisanForgingTools Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ArtisanForgingTools();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Misc
    public sealed class Nail : BlacksmithingItem
    {
        private static Nail? instance = null;
        private static readonly object locker = new object();

        Nail()
        {
            id = 28734;
            name = "Nail";
            icon = "28734.png";
        }

        public static Nail Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Nail();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CommonPlate : BlacksmithingItem
    {
        private static CommonPlate? instance = null;
        private static readonly object locker = new object();

        CommonPlate()
        {
            id = 40283;
            name = "Common Plate";
            icon = "40283.png";
        }

        public static CommonPlate Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CommonPlate();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ReinforcedPlate : BlacksmithingItem
    {
        private static ReinforcedPlate? instance = null;
        private static readonly object locker = new object();

        ReinforcedPlate()
        {
            id = 28740;
            name = "Reinforced Plate";
            icon = "28740.png";
        }

        public static ReinforcedPlate Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ReinforcedPlate();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class IronBar : BlacksmithingItem
    {
        private static IronBar? instance = null;
        private static readonly object locker = new object();

        IronBar()
        {
            id = 28737;
            name = "Iron Bar";
            icon = "28737.png";
        }

        public static IronBar Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new IronBar();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Bolt : BlacksmithingItem
    {
        private static Bolt? instance = null;
        private static readonly object locker = new object();

        Bolt()
        {
            id = 40282;
            name = "Bolt";
            icon = "40282.png";
        }

        public static Bolt Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Bolt();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SteelBar : BlacksmithingItem
    {
        private static SteelBar? instance = null;
        private static readonly object locker = new object();

        SteelBar()
        {
            id = 40284;
            name = "Steel Bar";
            icon = "40284.png";
        }

        public static SteelBar Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SteelBar();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Moa Equipment
    public sealed class SimpleHeadgear : BlacksmithingItem
    {
        private static SimpleHeadgear? instance = null;
        private static readonly object locker = new object();

        SimpleHeadgear()
        {
            id = 43238;
            name = "Simple Headgear";
            icon = "43238.png";
        }

        public static SimpleHeadgear Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SimpleHeadgear();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ComposedHeadgear : BlacksmithingItem
    {
        private static ComposedHeadgear? instance = null;
        private static readonly object locker = new object();

        ComposedHeadgear()
        {
            id = 43239;
            name = "Composed Headgear";
            icon = "43239.png";
        }

        public static ComposedHeadgear Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ComposedHeadgear();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class AdvancedHeadgear : BlacksmithingItem
    {
        private static AdvancedHeadgear? instance = null;
        private static readonly object locker = new object();

        AdvancedHeadgear()
        {
            id = 43240;
            name = "Advanced Headgear";
            icon = "43240.png";
        }

        public static AdvancedHeadgear Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new AdvancedHeadgear();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ArtisanHeadgear : BlacksmithingItem
    {
        private static ArtisanHeadgear? instance = null;
        private static readonly object locker = new object();

        ArtisanHeadgear()
        {
            id = 43241;
            name = "Artisan Headgear";
            icon = "43241.png";
        }

        public static ArtisanHeadgear Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ArtisanHeadgear();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SuperiorHeadgear : BlacksmithingItem
    {
        private static SuperiorHeadgear? instance = null;
        private static readonly object locker = new object();

        SuperiorHeadgear()
        {
            id = 43242;
            name = "Superior Headgear";
            icon = "43242.png";
        }

        public static SuperiorHeadgear Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SuperiorHeadgear();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ExplorerHeadgear : BlacksmithingItem
    {
        private static ExplorerHeadgear? instance = null;
        private static readonly object locker = new object();

        ExplorerHeadgear()
        {
            id = 43244;
            name = "Explorer Headgear";
            icon = "43244.png";
        }

        public static ExplorerHeadgear Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ExplorerHeadgear();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ProfessionalHeadgear : BlacksmithingItem
    {
        private static ProfessionalHeadgear? instance = null;
        private static readonly object locker = new object();

        ProfessionalHeadgear()
        {
            id = 43245;
            name = "Professional Headgear";
            icon = "43245.png";
        }

        public static ProfessionalHeadgear Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ProfessionalHeadgear();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WarHeadgear : BlacksmithingItem
    {
        private static WarHeadgear? instance = null;
        private static readonly object locker = new object();

        WarHeadgear()
        {
            id = 43243;
            name = "War Headgear";
            icon = "43243.png";
        }

        public static WarHeadgear Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WarHeadgear();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion

    #region Ship Module
    public sealed class SimpleShipEmblemsKit : BlacksmithingItem
    {
        private static SimpleShipEmblemsKit? instance = null;
        private static readonly object locker = new object();

        SimpleShipEmblemsKit()
        {
            id = 37268;
            name = "Simple Ship Emblems Kit";
            icon = "37268.png";
        }

        public static SimpleShipEmblemsKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SimpleShipEmblemsKit();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MinorShieldingKit : BlacksmithingItem
    {
        private static MinorShieldingKit? instance = null;
        private static readonly object locker = new object();

        MinorShieldingKit()
        {
            id = 37260;
            name = "Minor Shielding Kit";
            icon = "37260.png";
        }

        public static MinorShieldingKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MinorShieldingKit();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SmallCannonKit : BlacksmithingItem
    {
        private static SmallCannonKit? instance = null;
        private static readonly object locker = new object();

        SmallCannonKit()
        {
            id = 37266;
            name = "Small Cannon Kit";
            icon = "37266.png";
        }

        public static SmallCannonKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallCannonKit();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BasicWaterPumpsKit : BlacksmithingItem
    {
        private static BasicWaterPumpsKit? instance = null;
        private static readonly object locker = new object();

        BasicWaterPumpsKit()
        {
            id = 37223;
            name = "Basic Water Pumps Kit";
            icon = "37223.png";
        }

        public static BasicWaterPumpsKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BasicWaterPumpsKit();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumCannonKit : BlacksmithingItem
    {
        private static MediumCannonKit? instance = null;
        private static readonly object locker = new object();

        MediumCannonKit()
        {
            id = 43637;
            name = "Medium Cannon Kit";
            icon = "43637.png";
        }

        public static MediumCannonKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumCannonKit();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CompoundShipEmblemsKit : BlacksmithingItem
    {
        private static CompoundShipEmblemsKit? instance = null;
        private static readonly object locker = new object();

        CompoundShipEmblemsKit()
        {
            id = 37265;
            name = "Compound Ship Emblems Kit";
            icon = "37265.png";
        }

        public static CompoundShipEmblemsKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CompoundShipEmblemsKit();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class EnhancedWaterPumpsKit : BlacksmithingItem
    {
        private static EnhancedWaterPumpsKit? instance = null;
        private static readonly object locker = new object();

        EnhancedWaterPumpsKit()
        {
            id = 37230;
            name = "Enhanced Water Pumps Kit";
            icon = "37230.png";
        }

        public static EnhancedWaterPumpsKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new EnhancedWaterPumpsKit();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SturdyShieldingKit : BlacksmithingItem
    {
        private static SturdyShieldingKit? instance = null;
        private static readonly object locker = new object();

        SturdyShieldingKit()
        {
            id = 37282;
            name = "Sturdy Shielding Kit";
            icon = "37282.png";
        }

        public static SturdyShieldingKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SturdyShieldingKit();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class LargeCannonKit : BlacksmithingItem
    {
        private static LargeCannonKit? instance = null;
        private static readonly object locker = new object();

        LargeCannonKit()
        {
            id = 43636;
            name = "Large Cannon Kit";
            icon = "43636.png";
        }

        public static LargeCannonKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LargeCannonKit();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ComplexShipEmblemsKit : BlacksmithingItem
    {
        private static ComplexShipEmblemsKit? instance = null;
        private static readonly object locker = new object();

        ComplexShipEmblemsKit()
        {
            id = 37218;
            name = "Complex Ship Emblems Kit";
            icon = "37218.png";
        }

        public static ComplexShipEmblemsKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ComplexShipEmblemsKit();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class PressurizedWaterPumpsKit : BlacksmithingItem
    {
        private static PressurizedWaterPumpsKit? instance = null;
        private static readonly object locker = new object();

        PressurizedWaterPumpsKit()
        {
            id = 37261;
            name = "Pressurized Water Pumps Kit";
            icon = "37261.png";
        }

        public static PressurizedWaterPumpsKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new PressurizedWaterPumpsKit();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ReinforcedShieldingKit : BlacksmithingItem
    {
        private static ReinforcedShieldingKit? instance = null;
        private static readonly object locker = new object();

        ReinforcedShieldingKit()
        {
            id = 37263;
            name = "Reinforced Shielding Kit";
            icon = "37263.png";
        }

        public static ReinforcedShieldingKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ReinforcedShieldingKit();
                    }

                    return instance;
                }
            }
        }
    }
    #endregion
}
