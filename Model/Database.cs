using MercatorisAdiutor.Model.Blacksmithing.Items;
using MercatorisAdiutor.Model.Carpentry.Items;
using MercatorisAdiutor.Model.Cooking.Items;
using MercatorisAdiutor.Model.Farming.Items;
using MercatorisAdiutor.Model.Fishing.Items;
using MercatorisAdiutor.Model.Husbandry.Items;
using MercatorisAdiutor.Model.Mining.Items;
using MercatorisAdiutor.Model.Monster.Items;
using MercatorisAdiutor.Model.Tradepack.Tradepacks;
using MercatorisAdiutor.Model.Weaving.Items;
using MercatorisAdiutor.Model.WoodCutting.Items;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace MercatorisAdiutor.Model
{
    public sealed class Database
    {
        private static Database? instance = null;
        private static readonly object locker = new object();
        private static string FOLDERNAME = "Database";
        private static string LOGFILENAME = "MercatorisAdiutor";
        private static string LOGFILEEXTENSION = ".log";

        private static Item[] AlchemyItems =
        {

        };
        private static Item[] BlacksmithingItems =
        {

        };
        private static Item[] CarpentryItems =
        {
            DensePlank.Instance,
            RoughPlank.Instance,
            RefinedPlank.Instance,
            TreatedPlank.Instance,
            HeavyPlank.Instance,
            SturdyPlank.Instance,
            FinePlank.Instance,
            WoodenBulwark.Instance,
            MysticStaff.Instance,
            OakWoodBow.Instance,
            WoodenBuckler.Instance,
            KnottedSceptre.Instance,
            SentinelShield.Instance,
            SturdyBuckler.Instance,
            TribalSceptre.Instance,
            ViperBow.Instance,
            WarlockStaff.Instance,
            SerpentSceptre.Instance,
            DefenderBulwark.Instance,
            CultistStaff.Instance,
            MarauderShield.Instance,
            BlackAshBow.Instance,
            CrystalSceptre.Instance,
            CelestialStaff.Instance,
            RuneShield.Instance,
            SteelcladBulwark.Instance,
            BullseyeBow.Instance,
            RavenguardShield.Instance,
            KingDefender.Instance,
            CelestialSceptre.Instance,
            PredatorBow.Instance,
            LightshardStaff.Instance,
            ProtectorTowerShield.Instance,
            NecromancerStaff.Instance,
            MarksmanBow.Instance,
            CrowboneSceptre.Instance,
            NocturnalShield.Instance,
            FishingStick.Instance,
            FishingRod.Instance,
            CraftmanFishingRod.Instance,
            SailorFishingRod.Instance,
            ArtisanFishingRod.Instance,
            LightwoodAngler.Instance,
            WeakTable.Instance,
            FrailLoam.Instance,
            ProtectiveCharm.Instance,
            BasicStabilizer.Instance,
            StorageContaier.Instance,
            WorkBench.Instance,
            Chair.Instance,
            SimpleBed.Instance,
            WallReinforcement.Instance,
            EnergyStabilizer.Instance,
            SimpleLoom.Instance,
            WardingCharm.Instance,
            SuperiorWorkBench.Instance,
            Cabinet.Instance,
            SquareTable.Instance,
            ComfortableBed.Instance,
            SturdyContainer.Instance,
            ArcaneStabilizer.Instance,
            SpellboundCharm.Instance,
            WallFortification.Instance,
            LuxuryBed.Instance,
            Loom.Instance,
            ArtisanWorkBench.Instance,
            Armoires.Instance,
            SturdySquareTable.Instance,
            Fireplace.Instance,
            Mast.Instance,
            SmallGunDeck.Instance,
            SmallFishingStorage.Instance,
            SmallCargoHold.Instance,
            SmallHullFrame.Instance,
            MediumGunDeck.Instance,
            MediumFishingStorage.Instance,
            MediumHullFrame.Instance,
            MediumCargoHold.Instance,
            LargeCargoHold.Instance,
            LargeGunDeck.Instance,
            LargeFishingStorage.Instance,
            LargeHullFrame.Instance,
            SmallAmmunitionCabinKit.Instance,
            SmallMaintenanceUnitKit.Instance,
            SmallFishingCraneKit.Instance,
            SmallTradepackContainerKit.Instance,
            MediumTradepackContainerKit.Instance,
            MediumMaintenanceUnitKit.Instance,
            MediumAmmunitionCabinKit.Instance,
            MediumFishingCraneKit.Instance,
            CommonWheel.Instance,
            SmallWagonContainer.Instance,
            WoodenArch.Instance,
            SwiftWheel.Instance,
            CommonWagonContainer.Instance,
            SturdyWheel.Instance,
            MediumWagonContainer.Instance,
            SuppleWoodenArch.Instance,
            ReinforcedWheel.Instance,
            LargeWagonContainer.Instance
        };
        private static Item[] CookingItems =
        {
            BakedPotatoes.Instance,
            CornOnACob.Instance,
            PotatoBread.Instance,
            SajechoHardtrack.Instance,
            RohnaCrackers.Instance,
            GlademireCrackers.Instance,
            Bun.Instance,
            LoafBread.Instance,
            Cookies.Instance,
            Scane.Instance,
            Cornbread.Instance,
            DeluxeCookies.Instance,
            Muffin.Instance,
            Bagel.Instance,
            Cake.Instance,
            Croissant.Instance,
            SourdoughtBagel.Instance,
            DeluxeCake.Instance,
            Danish.Instance,
            RyeBread.Instance,
            Pie.Instance,
            Vodka.Instance,
            Beer.Instance,
            LandingBrandy.Instance,
            AppleCider.Instance,
            Wine.Instance,
            Whiskey.Instance,
            OrangeLiqueur.Instance,
            Rum.Instance,
            BlueberryWine.Instance,
            Boozemelon.Instance,
            SpicedRum.Instance,
            BananaVodka.Instance,
            Eclipse.Instance,
            StrawberryWhiskey.Instance,
            CornChowder.Instance,
            CornSalada.Instance,
            ScrambledEggs.Instance,
            ApplePuree.Instance,
            MashedPotatoes.Instance,
            CarrotSoup.Instance,
            LyderianFries.Instance,
            Omelet.Instance,
            SilkyScrambledEggs.Instance,
            SteamedCarrots.Instance,
            FruitPancakes.Instance,
            SmokedSausage.Instance,
            CharredMeatKebab.Instance,
            RoastedChickenAndVeggies.Instance,
            RavendawnianPorridge.Instance,
            RumDownslider.Instance,
            ShakedFruitmilk.Instance,
            SettlerStew.Instance,
            DwarvenPurpleShank.Instance,
            FilletLucien.Instance,
            BlueberryPie.Instance,
            FrozenSweetBerries.Instance,
            LucienWaffles.Instance,
            AcorncharSausage.Instance,
            FreshfishRoll.Instance,
            SweetenedBeans.Instance,
            FireredChickenKebab.Instance,
            LyderianChoppedTenderloin.Instance,
            RohnaRoastedHam.Instance,
            SailorSeastew.Instance,
            BittersweetRoast.Instance,
            ShanksNMash.Instance,
            IcedFruitmilk.Instance,
            Oil.Instance,
            BasicSeasoning.Instance,
            SeafoodSeasoning.Instance,
            GroundFlour.Instance,
            Butter.Instance,
            BrewerYeast.Instance,
            GourmetSeasoning.Instance,
            RichFlour.Instance,
            SpicedOil.Instance,
            SpicySeasoning.Instance,
            BasicAnimalFeed.Instance,
            MoaRation.Instance,
            SuperiorRation.Instance,
            ComplexAnimalFeed.Instance,
            GourmetRation.Instance,
            SafoodExtravaganza.Instance,
            UncannyRation.Instance,
            MoaDelight.Instance
        };
        private static Item[] FarmingItems =
        {
            ThreeLeafClover.Instance,
            Potato.Instance,
            Cotton.Instance,
            Corn.Instance,
            Wheat.Instance,
            Apple.Instance,
            Carrot.Instance,
            Grape.Instance,
            Blueberry.Instance,
            Cabbage.Instance,
            Pepper.Instance,
            Cherry.Instance,
            Orange.Instance,
            Onion.Instance,
            Strawberry.Instance,
            Bean.Instance,
            Banana.Instance,
            Pumpkin.Instance,
            Watermelon.Instance,
            Pea.Instance,
            Moonberry.Instance,
            Garlic.Instance,
            Acorn.Instance,
            Brocolli.Instance,
            Sunberry.Instance
        };
        private static Item[] FishingItems =
        {
            OrangeScales.Instance,
            FishRoe.Instance,
            FishSkin.Instance,
            YellowFishRoe.Instance,
            FishEye.Instance,
            RedFishRoe.Instance,
            FishLiver.Instance,
            FishOil.Instance,
            LuminousSack.Instance,
            BlackFishRoe.Instance,
            Shrimp.Instance,
            TangerineFish.Instance,
            Catfish.Instance,
            Mino.Instance,
            OversizedMino.Instance,
            TenchFish.Instance,
            RainbowFish.Instance,
            SandFish.Instance,
            ScaleFish.Instance,
            JuniperFish.Instance,
            Lobster.Instance,
            PrincessFish.Instance,
            SunFish.Instance,
            AngelFish.Instance,
            SkyFish.Instance,
            StarFish.Instance,
            BigmouthFlounder.Instance,
            FrostSturgeon.Instance,
            BogProwler.Instance,
            Gromper.Instance,
            RainbowFlounder.Instance,
            TigerShark.Instance,
            Stingray.Instance
        };
        private static Item[] HusbandryItems =
        {
            Fertilizer.Instance,
            Shank.Instance,
            Hide.Instance,
            SpoolOfHair.Instance,
            Chicken.Instance,
            Egg.Instance,
            Milk.Instance,
            Wool.Instance,
            Feather.Instance,
            Cheese.Instance,
            Honey.Instance,
            Beef.Instance
        };
        private static Item[] MiningItems =
        {
            Stone.Instance,
            Salt.Instance,
            Coal.Instance,
            Amethyst.Instance,
            Citrine.Instance,
            Ruby.Instance,
            Sapphire.Instance,
            Topaz.Instance,
            CopperOre.Instance,
            IronOre.Instance,
            CobaltOre.Instance,
            TitaniumOre.Instance
        };
        private static Item[] WeavingItems =
        {
            SimpleCloth.Instance,
            CraftmanCloth.Instance,
            Silk.Instance,
            MerchantCloth.Instance,
            ArtisanCloth.Instance,
            CoarseLeather.Instance,
            CraftmanLeather.Instance,
            TannedLeather.Instance,
            MerchantLeather.Instance,
            ArtisanLeather.Instance,
            CoarseThread.Instance,
            CraftmanThread.Instance,
            FineThread.Instance,
            MerchantThread.Instance,
            ArtisanThread.Instance,
            CheapRug.Instance,
            Carpet.Instance,
            ThreadSpool.Instance,
            ClothRoll.Instance,
            LuxuryCarpet.Instance,
            LuxuryThreadSpool.Instance,
            RefinedClothRoll.Instance,
            LuxuryClothRoll.Instance,
            SimpleSaddle.Instance,
            ComposedSaddle.Instance,
            AdvancedSaddle.Instance,
            ArtisanSaddle.Instance,
            SuperiorSaddle.Instance,
            WarSaddle.Instance,
            ProfessionalSaddle.Instance,
            ExplorerSaddle.Instance,
            SmallSailKit.Instance,
            SmallFishingNetsKit.Instance,
            MediumSailKit.Instance,
            MediumFishingNetsKit.Instance,
            LargeSailKit.Instance,
            LargeFishingNetsKit.Instance,
            HideArmor.Instance,
            ShadeclothArmor.Instance,
            HideHelmet.Instance,
            ShadeclothHelmet.Instance,
            HideLegs.Instance,
            ShadeclothLegs.Instance,
            HideBoots.Instance,
            ShadeclothBoots.Instance,
            NomadArmor.Instance,
            ViperArmor.Instance,
            NomadHelmet.Instance,
            ViperHelmet.Instance,
            NomadLegs.Instance,
            ViperLegs.Instance,
            NomadBoots.Instance,
            ViperBoots.Instance,
            BruiserArmor.Instance,
            ProfaneArmor.Instance,
            BruiserHelmet.Instance,
            ProfaneHelmet.Instance,
            BruiserLegs.Instance,
            ProfaneLegs.Instance,
            BruiserBoots.Instance,
            ProfaneBoots.Instance,
            OutlawArmor.Instance,
            CelestialArmor.Instance,
            OutlawHelmet.Instance,
            CelestialHelmet.Instance,
            OutlawLegs.Instance,
            CelestialLegs.Instance,
            OutlawBoots.Instance,
            CelestialBoots.Instance,
            StuddedArmor.Instance,
            MysticArmor.Instance,
            StuddedHelmet.Instance,
            MysticHelmet.Instance,
            StuddedLegs.Instance,
            MysticLegs.Instance,
            StuddedBoots.Instance,
            MysticBoots.Instance,
            GuerrilaArmor.Instance,
            WarlockArmor.Instance,
            GuerrilaHelmet.Instance,
            WarlockHelmet.Instance,
            GuerrilaLegs.Instance,
            WarlockLegs.Instance,
            GuerrilaBoots.Instance,
            WarlockBoots.Instance,
            FryCookBoots.Instance,
            LoomApprenticeBoots.Instance,
            WorkshopAssistantBoots.Instance,
            ApprenticeAnvilBoots.Instance,
            FryCookLegs.Instance,
            LoomApprenticeLegs.Instance,
            WorkshopAssistantLegs.Instance,
            ApprenticeAnvilLegs.Instance,
            FryCookArmor.Instance,
            LoomApprenticeArmor.Instance,
            WorkshopAssistantArmor.Instance,
            ApprenticeAnvilArmor.Instance,
            FryCookHelmet.Instance,
            LoomApprenticeHelmet.Instance,
            WorkshopAssistantHelmet.Instance,
            ApprenticeAnvilHelmet.Instance,
            FryCookBracers.Instance,
            LoomApprenticeGloves.Instance,
            WorkshopAssistantGloves.Instance,
            ApprenticeAnvilBracers.Instance,
            SousChefBoots.Instance,
            ThreadspinnerBoots.Instance,
            WoodworkerBoots.Instance,
            SilversmithBoots.Instance,
            SousChefLegs.Instance,
            ThreadspinnerLegs.Instance,
            WoodworkerLegs.Instance,
            SilversmithLegs.Instance,
            SousChefArmor.Instance,
            ThreadspinnerArmor.Instance,
            WoodworkerArmor.Instance,
            SilversmithArmor.Instance,
            SousChefHelmet.Instance,
            ThreadspinnerHelmet.Instance,
            WoodworkerHelmet.Instance,
            SilversmithHelmet.Instance,
            SousChefBracers.Instance,
            ThreadspinnerGloves.Instance,
            WoodworkerGloves.Instance,
            SilversmithBracers.Instance,
            MasterOfCuisineBoots.Instance,
            MasterTailorBoots.Instance,
            MasterMasonBoots.Instance,
            ForgemasterBoots.Instance,
            MasterOfCuisineLegs.Instance,
            MasterTailorLegs.Instance,
            MasterMasonLegs.Instance,
            ForgemasterLegs.Instance,
            MasterOfCuisineArmor.Instance,
            MasterTailorArmor.Instance,
            MasterMasonArmor.Instance,
            ForgemasterArmor.Instance,
            MasterOfCuisineHelmet.Instance,
            MasterTailorHelmet.Instance,
            MasterMasonHelmet.Instance,
            ForgemasterHelmet.Instance,
            MasterOfCuisineBracers.Instance,
            MasterTailorBracers.Instance,
            MasterMasonGloves.Instance,
            ForgemasterBracers.Instance
        };
        private static Item[] WoodCuttingItems =
        {
            DenseLog.Instance,
            SmallLog.Instance,
            HeavyLog.Instance,
            SturdyLog.Instance,
            FineLog.Instance
        };
        private static Item[] MonsterItems =
        {

        };

        private Semaphore fileSemaphore;

        Database()
        {
            fileSemaphore = new Semaphore(initialCount: 1, maximumCount: 1);

            InitializeDatabse();
        }

        public static Database Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Database();
                    }

                    return instance;
                }
            }
        }

        public void InitializeDatabse()
        {
            fileSemaphore.WaitOne();

            string folderPath = Directory.GetCurrentDirectory() + "/" + FOLDERNAME;
            string filePath = Directory.GetCurrentDirectory() + "/" + FOLDERNAME + "/" + LOGFILENAME + LOGFILEEXTENSION;

            if (Directory.Exists(folderPath) && File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] splits = line.Split(" ## ");

                    if (splits.Length == 2 &&
                        int.TryParse(splits[0], out int itemId) &&
                        int.TryParse(splits[1], out int itemPrice))
                    {
                        UpdateItemPriceById(itemId, itemPrice);
                    }
                }
            }
            else
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/" + FOLDERNAME);

                List<Item> items =
                [
                    .. AlchemyItems,
                    .. BlacksmithingItems,
                    .. CarpentryItems,
                    .. CookingItems,
                    .. FarmingItems,
                    .. FishingItems,
                    .. HusbandryItems,
                    .. MiningItems,
                    .. MonsterItems,
                    .. WeavingItems,
                    .. WoodCuttingItems
                ];

                IOrderedEnumerable<Item> ordereditems = items.OrderBy(a => a.Id);

                using (StreamWriter writer = File.CreateText(filePath))
                {
                    foreach (Item orderedItem in ordereditems)
                    {
                        string line = orderedItem.Id + " ## " + orderedItem.Price;

                        writer.WriteLine(line);
                    }
                }
            }

            fileSemaphore.Release();
        }
        public async Task UpdateDatabaseItemPrice(int id, int price)
        {
            fileSemaphore.WaitOne();

            string path = Directory.GetCurrentDirectory() + "/" + FOLDERNAME + "/" + LOGFILENAME + LOGFILEEXTENSION;

            if (File.Exists(path))
            {
                string[] lines = await File.ReadAllLinesAsync(path);
                int i = 0;

                while (lines.Length > i)
                {
                    string[] splits = lines[i].Split(" ## ");

                    if (splits.Length == 2 &&
                        int.TryParse(splits[0], out int itemId) &&
                        int.TryParse(splits[1], out int itemPrice) &&
                        itemId == id)
                    {
                        itemPrice = price;
                        lines[i] = itemId + " ## " + itemPrice;

                        break;
                    }

                    i++;
                }

                await File.WriteAllLinesAsync(path, lines);
            }

            fileSemaphore.Release();
        }

        private void UpdateItemPriceById(int id, int price)
        {
            Item? foundItem;

            foundItem = GetAllAlchemyItems().Find(a => a.Id == id);

            if (foundItem != null)
            {
                foundItem.Price = price;

                return;
            }

            foundItem = GetAllAlchemyItems().Find(a => a.Id == id);

            if (foundItem != null)
            {
                foundItem.Price = price;

                return;
            }

            foundItem = GetAllBlacksmithingItems().Find(a => a.Id == id);

            if (foundItem != null)
            {
                foundItem.Price = price;

                return;
            }

            foundItem = GetAllCarpentryItems().Find(a => a.Id == id);

            if (foundItem != null)
            {
                foundItem.Price = price;

                return;
            }

            foundItem = GetAllCookingItems().Find(a => a.Id == id);

            if (foundItem != null)
            {
                foundItem.Price = price;

                return;
            }

            foundItem = GetAllFarmingItems().Find(a => a.Id == id);

            if (foundItem != null)
            {
                foundItem.Price = price;

                return;
            }

            foundItem = GetAllFishingItems().Find(a => a.Id == id);

            if (foundItem != null)
            {
                foundItem.Price = price;

                return;
            }

            foundItem = GetAllHusbandryItems().Find(a => a.Id == id);

            if (foundItem != null)
            {
                foundItem.Price = price;

                return;
            }

            foundItem = GetAllMiningItems().Find(a => a.Id == id);

            if (foundItem != null)
            {
                foundItem.Price = price;

                return;
            }

            foundItem = GetAllMonsterItems().Find(a => a.Id == id);

            if (foundItem != null)
            {
                foundItem.Price = price;

                return;
            }

            foundItem = GetAllWeavingItems().Find(a => a.Id == id);

            if (foundItem != null)
            {
                foundItem.Price = price;

                return;
            }

            foundItem = GetAllWoodcuttingItems().Find(a => a.Id == id);

            if (foundItem != null)
            {
                foundItem.Price = price;

                return;
            }
        }

        public List<Item> GetAllAlchemyItems() => AlchemyItems.OrderBy(a => a.Name).ToList();

        public List<Item> GetAllBlacksmithingItems() => BlacksmithingItems.OrderBy(a => a.Name).ToList();

        public List<Item> GetAllCarpentryItems() => CarpentryItems.OrderBy(a => a.Name).ToList();

        public List<Item> GetAllCookingItems() => CookingItems.OrderBy(a => a.Name).ToList();

        public List<Item> GetAllFarmingItems() => FarmingItems.OrderBy(a => a.Name).ToList();

        public List<Item> GetAllFishingItems() => FishingItems.OrderBy(a => a.Name).ToList();

        public List<Item> GetAllHusbandryItems() => HusbandryItems.OrderBy(a => a.Name).ToList();

        public List<Item> GetAllMiningItems() => MiningItems.OrderBy(a => a.Name).ToList();

        public List<Item> GetAllMonsterItems() => MonsterItems.OrderBy(a => a.Name).ToList();

        public List<Item> GetAllWeavingItems() => WeavingItems.OrderBy(a => a.Name).ToList();

        public List<Item> GetAllWoodcuttingItems() => WoodCuttingItems.OrderBy(a => a.Name).ToList();
    }
}
