using MercatorisAdiutor.Model.Carpentry.Items;
using MercatorisAdiutor.Model.Cooking.Items;
using MercatorisAdiutor.Model.Farming.Items;
using MercatorisAdiutor.Model.Fishing.Items;
using MercatorisAdiutor.Model.Husbandry.Items;
using MercatorisAdiutor.Model.Mining.Items;
using MercatorisAdiutor.Model.Weaving.Items;
using MercatorisAdiutor.Model.WoodCutting.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace MercatorisAdiutor.Model
{
    public  class Catalog
    {
        public Catalog() 
        {
            Database.InitializeDatabse();
        }

        public List<Item> GetAllAlchemyItems()
        {
            List<Item> items =
            [
            ];

            return items.OrderBy(a => a.Name).ToList();
        }

        public List<Item> GetAllBlacksmithingItems()
        {
            List<Item> items =
            [
            ];

            return items.OrderBy(a => a.Name).ToList();
        }

        public List<Item> GetAllCarpentryItems()
        {
            List<Item> items =
            [
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
                LargeWagonContainer.Instance,    
            ];

            return items.OrderBy(a => a.Name).ToList();
        }

        public List<Item> GetAllCookingItems()
        {
            List<Item> items =
            [
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
                MoaDelight.Instance,    
            ];

            return items.OrderBy(a => a.Name).ToList();
        }

        public List<Item> GetAllFarmingItems()
        {
            List<Item> items =
            [
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
                Sunberry.Instance,
            ];

            return items.OrderBy(a => a.Name).ToList();
        }

        public List<Item> GetAllFishingItems()
        {
            List<Item> items =
            [
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
                Stingray.Instance,
            ];

            return items.OrderBy(a => a.Name).ToList();
        }

        public List<Item> GetAllHusbandryItems()
        {
            List<Item> items =
            [
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
                Beef.Instance,
            ];

            return items.OrderBy(a => a.Name).ToList();
        }

        public List<Item> GetAllMiningItems()
        {
            List<Item> items =
            [
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
                TitaniumOre.Instance,
            ];

            return items.OrderBy(a => a.Name).ToList();
        }

        public List<Item> GetAllMonsterItems()
        {
            List<Item> items =
            [
            ];

            return items.OrderBy(a => a.Name).ToList();
        }

        public List<Item> GetAllTradepackItems()
        {
            List<Item> items =
            [
            ];

            return items.OrderBy(a => a.Name).ToList();
        }

        public List<Item> GetAllWeavingItems()
        {
            List<Item> items =
            [
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
            ];
            return items.OrderBy(a => a.Name).ToList();
        }

        public List<Item> GetAllWoodcuttingItems()
        {
            List<Item> items =
            [
                DenseLog.Instance,
                SmallLog.Instance,
                HeavyLog.Instance,
                SturdyLog.Instance,
                FineLog.Instance,
            ];

            return items.OrderBy(a => a.Name).ToList();
        }
    }
}
