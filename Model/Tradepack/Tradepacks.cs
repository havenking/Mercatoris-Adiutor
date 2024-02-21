using System.Windows.Media.Media3D;

namespace MercatorisAdiutor.Model.Tradepack.Tradepacks
{
    public abstract class Tradepack
    {
        internal string name = string.Empty;
        internal string icon = string.Empty;
        internal int price = 0;
        internal TradepackStatus status = TradepackStatus.Active;
        internal Material[] materials = Array.Empty<Material>();

        public string Name => name;

        public string Icon => icon;

        public TradepackStatus Status => status;

        public Material[] Materials => materials;

        public int Price 
        {
            get { return price; }
            set { price = value; }
        }
    }

    public sealed class AgedMeat : Tradepack
    {
        private static AgedMeat? instance = null;
        private static readonly object locker = new object();

        AgedMeat() 
        {
            name = "Aged Meat";
            materials =
            [
                new Material() { Item = Husbandry.Items.Beef.Instance, Quantity = 12 },
                new Material() { Item = Mining.Items.Salt.Instance, Quantity = 5 },
                new Material() { Item = Farming.Items.Garlic.Instance, Quantity = 15 }
            ];
        }

        public static AgedMeat Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new AgedMeat();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BakersBasics : Tradepack
    {
        private static BakersBasics? instance = null;
        private static readonly object locker = new object();

        BakersBasics()
        {
            name = "Bakers Basics";
            materials =
            [
                new Material() { Item = Husbandry.Items.Milk.Instance, Quantity = 15 },
                new Material() { Item = Husbandry.Items.Egg.Instance, Quantity = 30 },
                new Material() { Item = Cooking.Items.GroundFlour.Instance, Quantity = 35 }
            ];
        }

        public static BakersBasics Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BakersBasics();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BarbecueSpecialty : Tradepack
    {
        private static BarbecueSpecialty? instance = null;
        private static readonly object locker = new object();

        BarbecueSpecialty()
        {
            name = "Barbecue Specialty";
            materials =
            [
                new Material() { Item = Husbandry.Items.Beef.Instance, Quantity = 10 },
                new Material() { Item = Husbandry.Items.Chicken.Instance, Quantity = 5 },
                new Material() { Item = Mining.Items.Coal.Instance, Quantity = 30 },
                new Material() { Item = Husbandry.Items.Honey.Instance, Quantity = 6 }
            ];
        }

        public static BarbecueSpecialty Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BarbecueSpecialty();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BasicRations : Tradepack
    {
        private static BasicRations? instance = null;
        private static readonly object locker = new object();

        BasicRations()
        {
            name = "Basic Rations";
            materials =
            [
                new Material() { Item = Farming.Items.Wheat.Instance, Quantity = 15 },
                new Material() { Item = Farming.Items.Corn.Instance, Quantity = 10 },
                new Material() { Item = Farming.Items.Apple.Instance, Quantity = 10 }
            ];
        }

        public static BasicRations Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BasicRations();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BerryBasket : Tradepack
    {
        private static BerryBasket? instance = null;
        private static readonly object locker = new object();

        BerryBasket()
        {
            name = "Berry Basket";
            materials =
            [
                new Material() { Item = Farming.Items.Strawberry.Instance, Quantity = 30 },
                new Material() { Item = Farming.Items.Blueberry.Instance, Quantity = 50 },
                new Material() { Item = Farming.Items.Moonberry.Instance, Quantity = 4 },
                new Material() { Item = Farming.Items.Sunberry.Instance, Quantity = 30 }
            ];
        }

        public static BerryBasket Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BerryBasket();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BrinedShank : Tradepack
    {
        private static BrinedShank? instance = null;
        private static readonly object locker = new object();

        BrinedShank()
        {
            name = "Brined Shank";
            materials =
            [
                new Material() { Item = Husbandry.Items.Shank.Instance, Quantity = 10 },
                new Material() { Item = Mining.Items.Salt.Instance, Quantity = 8 },
                new Material() { Item = Farming.Items.Pepper.Instance, Quantity = 10 },
            ];
        }

        public static BrinedShank Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BrinedShank();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BuildingMaterials : Tradepack
    {
        private static BuildingMaterials? instance = null;
        private static readonly object locker = new object();

        BuildingMaterials()
        {
            name = "Building Materials";
            materials =
            [
                new Material() { Item = Mining.Items.Stone.Instance, Quantity = 100 },
                new Material() { Item = WoodCutting.Items.SmallLog.Instance, Quantity = 22 },
                new Material() { Item = Husbandry.Items.Hide.Instance, Quantity = 10 },
            ];
        }

        public static BuildingMaterials Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BuildingMaterials();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ButcherBox : Tradepack
    {
        private static ButcherBox? instance = null;
        private static readonly object locker = new object();

        ButcherBox()
        {
            name = "Butcher's Box";
            materials =
            [
                new Material() { Item = Husbandry.Items.Chicken.Instance, Quantity = 8 },
                new Material() { Item = Husbandry.Items.Beef.Instance, Quantity = 5 },
                new Material() { Item = Husbandry.Items.Shank.Instance, Quantity = 5 },
                new Material() { Item = Husbandry.Items.Cheese.Instance, Quantity = 1 }
            ];
        }

        public static ButcherBox Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ButcherBox();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CampfireRoast : Tradepack
    {
        private static CampfireRoast? instance = null;
        private static readonly object locker = new object();

        CampfireRoast()
        {
            name = "Campfire Roast";
            materials =
            [
                new Material() { Item = WoodCutting.Items.SmallLog.Instance, Quantity = 22 },
                new Material() { Item = Mining.Items.Stone.Instance, Quantity = 130 },
                new Material() { Item = Husbandry.Items.Chicken.Instance, Quantity = 8 }
            ];
        }

        public static CampfireRoast Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CampfireRoast();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CraftingBasics : Tradepack
    {
        private static CraftingBasics? instance = null;
        private static readonly object locker = new object();

        CraftingBasics()
        {
            name = "Crafting Basics";
            materials =
            [
                new Material() { Item = Mining.Items.CopperOre.Instance, Quantity = 40 },
                new Material() { Item = Husbandry.Items.Hide.Instance, Quantity = 10 },
                new Material() { Item = WoodCutting.Items.SmallLog.Instance, Quantity = 25 }
            ];
        }

        public static CraftingBasics Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CraftingBasics();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CrispProduce : Tradepack
    {
        private static CrispProduce? instance = null;
        private static readonly object locker = new object();

        CrispProduce()
        {
            name = "Crisp Produce";
            materials =
            [
                new Material() { Item = Farming.Items.Apple.Instance, Quantity = 10 },
                new Material() { Item = Farming.Items.Brocolli.Instance, Quantity = 5 },
                new Material() { Item = Farming.Items.Pea.Instance, Quantity = 10 },
                new Material() { Item = Farming.Items.Bean.Instance, Quantity = 5 }
            ];
        }

        public static CrispProduce Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CrispProduce();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class DairyDelivery : Tradepack
    {
        private static DairyDelivery? instance = null;
        private static readonly object locker = new object();

        DairyDelivery()
        {
            name = "Dairy Delivery";
            materials =
            [
                new Material() { Item = Husbandry.Items.Milk.Instance, Quantity = 15 },
                new Material() { Item = Husbandry.Items.Cheese.Instance, Quantity = 1 },
                new Material() { Item = Husbandry.Items.Egg.Instance, Quantity = 30 }
            ];
        }

        public static DairyDelivery Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new DairyDelivery();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class ExoticFruits : Tradepack
    {
        private static ExoticFruits? instance = null;
        private static readonly object locker = new object();

        ExoticFruits()
        {
            name = "Exotic Fruits";
            materials =
            [
                new Material() { Item = Farming.Items.Watermelon.Instance, Quantity = 4 },
                new Material() { Item = Farming.Items.Sunberry.Instance, Quantity = 8 },
                new Material() { Item = Farming.Items.Moonberry.Instance, Quantity = 5 }
            ];
        }

        public static ExoticFruits Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ExoticFruits();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class FriedChicken : Tradepack
    {
        private static FriedChicken? instance = null;
        private static readonly object locker = new object();

        FriedChicken()
        {
            name = "Fried Chicken";
            materials =
            [
                new Material() { Item = Farming.Items.Apple.Instance, Quantity = 12 },
                new Material() { Item = Farming.Items.Onion.Instance, Quantity = 10 },
                new Material() { Item = Farming.Items.Garlic.Instance, Quantity = 10 },
                new Material() { Item = Cooking.Items.GroundFlour.Instance, Quantity = 20 }
            ];
        }

        public static FriedChicken Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FriedChicken();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class FruitBasket : Tradepack
    {
        private static FruitBasket? instance = null;
        private static readonly object locker = new object();

        FruitBasket()
        {
            name = "Fruit Basket";
            materials =
            [
                new Material() { Item = Farming.Items.Grape.Instance, Quantity = 20 },
                new Material() { Item = Farming.Items.Watermelon.Instance, Quantity = 2 },
                new Material() { Item = Farming.Items.Cherry.Instance, Quantity = 5 }
            ];
        }

        public static FruitBasket Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new FruitBasket();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class GeneralSpices : Tradepack
    {
        private static GeneralSpices? instance = null;
        private static readonly object locker = new object();

        GeneralSpices()
        {
            name = "General Spices";
            materials =
            [
                new Material() { Item = Farming.Items.Garlic.Instance, Quantity = 15 },
                new Material() { Item = Farming.Items.Onion.Instance, Quantity = 15 },
                new Material() { Item = Farming.Items.Pepper.Instance, Quantity = 10 },
                new Material() { Item = Mining.Items.Salt.Instance, Quantity = 5 }
            ];
        }

        public static GeneralSpices Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new GeneralSpices();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class GlacefordeExporersKit : Tradepack
    {
        private static GlacefordeExporersKit? instance = null;
        private static readonly object locker = new object();

        GlacefordeExporersKit()
        {
            name = "Glaceforde Exporers Kit";
            materials =
            [
                new Material() { Item = Husbandry.Items.Wool.Instance, Quantity = 10 },
                new Material() { Item = WoodCutting.Items.SmallLog.Instance, Quantity = 30 },
                new Material() { Item = Mining.Items.Coal.Instance, Quantity = 40 }
            ];
        }

        public static GlacefordeExporersKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new GlacefordeExporersKit();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class JuicersBox : Tradepack
    {
        private static JuicersBox? instance = null;
        private static readonly object locker = new object();

        JuicersBox()
        {
            name = "Juicers Box";
            materials =
            [
                new Material() { Item = Farming.Items.Apple.Instance, Quantity = 5 },
                new Material() { Item = Farming.Items.Strawberry.Instance, Quantity = 15 },
                new Material() { Item = Farming.Items.Cherry.Instance, Quantity = 5 },
                new Material() { Item = Farming.Items.Banana.Instance, Quantity = 3 }
            ];
        }

        public static JuicersBox Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new JuicersBox();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class KabbarOmelets : Tradepack
    {
        private static KabbarOmelets? instance = null;
        private static readonly object locker = new object();

        KabbarOmelets()
        {
            name = "Kabbar's Omelets";
            materials =
            [
                new Material() { Item = Husbandry.Items.Egg.Instance, Quantity = 30 },
                new Material() { Item = Husbandry.Items.Cheese.Instance, Quantity = 1 },
                new Material() { Item = Farming.Items.Pepper.Instance, Quantity = 15 }
            ];
        }

        public static KabbarOmelets Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new KabbarOmelets();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class KindlingKit : Tradepack
    {
        private static KindlingKit? instance = null;
        private static readonly object locker = new object();

        KindlingKit()
        {
            name = "Kindling Kit";
            materials =
            [
                new Material() { Item = WoodCutting.Items.SmallLog.Instance, Quantity = 38 },
                new Material() { Item = Mining.Items.Coal.Instance, Quantity = 40 },
                new Material() { Item = Farming.Items.Cotton.Instance, Quantity = 10 }
            ];
        }

        public static KindlingKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new KindlingKit();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MargroveAleIngredients : Tradepack
    {
        private static MargroveAleIngredients? instance = null;
        private static readonly object locker = new object();

        MargroveAleIngredients()
        {
            name = "Margrove Ale Ingredients";
            materials =
            [
                new Material() { Item = Farming.Items.Wheat.Instance, Quantity = 30 },
                new Material() { Item = Farming.Items.Acorn.Instance, Quantity = 3 },
                new Material() { Item = Farming.Items.Pumpkin.Instance, Quantity = 2 }
            ];
        }

        public static MargroveAleIngredients Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MargroveAleIngredients();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class NobleDelicacies : Tradepack
    {
        private static NobleDelicacies? instance = null;
        private static readonly object locker = new object();

        NobleDelicacies()
        {
            name = "Noble Delicacies";
            materials =
            [
                new Material() { Item = Farming.Items.Moonberry.Instance, Quantity = 10 },
                new Material() { Item = Farming.Items.Acorn.Instance, Quantity = 2 },
                new Material() { Item = Farming.Items.Pepper.Instance, Quantity = 12 }
            ];
        }

        public static NobleDelicacies Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new NobleDelicacies();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class PickledVegetables : Tradepack
    {
        private static PickledVegetables? instance = null;
        private static readonly object locker = new object();

        PickledVegetables()
        {
            name = "Pickled Vegetables";
            materials =
            [
                new Material() { Item = Farming.Items.Cabbage.Instance, Quantity = 15 },
                new Material() { Item = Farming.Items.Carrot.Instance, Quantity = 50 },
                new Material() { Item = Mining.Items.Salt.Instance, Quantity = 8 }
            ];
        }

        public static PickledVegetables Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new PickledVegetables();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class PieMakingKit : Tradepack
    {
        private static PieMakingKit? instance = null;
        private static readonly object locker = new object();

        PieMakingKit()
        {
            name = "Pie Making Kit";
            materials =
            [
                new Material() { Item = Farming.Items.Apple.Instance, Quantity = 5 },
                new Material() { Item = Farming.Items.Sunberry.Instance, Quantity = 5 },
                new Material() { Item = Farming.Items.Cherry.Instance, Quantity = 4 },
                new Material() { Item = Cooking.Items.GroundFlour.Instance, Quantity = 30 }
            ];
        }

        public static PieMakingKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new PieMakingKit();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class RavencrestFinestWears : Tradepack
    {
        private static RavencrestFinestWears? instance = null;
        private static readonly object locker = new object();

        RavencrestFinestWears()
        {
            name = "Ravencrest Finest Wears";
            materials =
            [
                new Material() { Item = Farming.Items.Cotton.Instance, Quantity = 8 },
                new Material() { Item = Husbandry.Items.Wool.Instance, Quantity = 8 },
                new Material() { Item = Husbandry.Items.Hide.Instance, Quantity = 8 }
            ];
        }

        public static RavencrestFinestWears Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RavencrestFinestWears();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class RavencrestGreens : Tradepack
    {
        private static RavencrestGreens? instance = null;
        private static readonly object locker = new object();

        RavencrestGreens()
        {
            name = "Ravencrest Greens";
            materials =
            [
                new Material() { Item = Farming.Items.Brocolli.Instance, Quantity = 10 },
                new Material() { Item = Farming.Items.Pea.Instance, Quantity = 25 },
                new Material() { Item = Farming.Items.Cabbage.Instance, Quantity = 15 }
            ];
        }

        public static RavencrestGreens Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RavencrestGreens();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class RohnaSmokedHam : Tradepack
    {
        private static RohnaSmokedHam? instance = null;
        private static readonly object locker = new object();

        RohnaSmokedHam()
        {
            name = "Rohna Smoked Ham";
            materials =
            [
                new Material() { Item = Husbandry.Items.Shank.Instance, Quantity = 5 },
                new Material() { Item = Farming.Items.Acorn.Instance, Quantity = 2 },
                new Material() { Item = Farming.Items.Pea.Instance, Quantity = 10 },
                new Material() { Item = Mining.Items.Salt.Instance, Quantity = 5 }
            ];
        }

        public static RohnaSmokedHam Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RohnaSmokedHam();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SailorRemedy : Tradepack
    {
        private static SailorRemedy? instance = null;
        private static readonly object locker = new object();

        SailorRemedy()
        {
            name = "Sailor's Remedy";
            materials =
            [
                new Material() { Item = Farming.Items.Carrot.Instance, Quantity = 20 },
                new Material() { Item = Farming.Items.Orange.Instance, Quantity = 5 },
                new Material() { Item = Farming.Items.Bean.Instance, Quantity = 20 }
            ];
        }

        public static SailorRemedy Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SailorRemedy();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SajechoFruitBasket : Tradepack
    {
        private static SajechoFruitBasket? instance = null;
        private static readonly object locker = new object();

        SajechoFruitBasket()
        {
            name = "Sajecho Fruit Basket";
            materials =
            [
                new Material() { Item = Farming.Items.Banana.Instance, Quantity = 2 },
                new Material() { Item = Farming.Items.Watermelon.Instance, Quantity = 1 },
                new Material() { Item = Farming.Items.Orange.Instance, Quantity = 4 },
                new Material() { Item = Farming.Items.Grape.Instance, Quantity = 10 }
            ];
        }

        public static SajechoFruitBasket Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SajechoFruitBasket();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SajechoSpices : Tradepack
    {
        private static SajechoSpices? instance = null;
        private static readonly object locker = new object();

        SajechoSpices()
        {
            name = "Sajecho's Spices";
            materials =
            [
                new Material() { Item = Mining.Items.Salt.Instance, Quantity = 5 },
                new Material() { Item = Farming.Items.Orange.Instance, Quantity = 4 },
                new Material() { Item = Farming.Items.Onion.Instance, Quantity = 15 }
            ];
        }

        public static SajechoSpices Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SajechoSpices();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SeabreezeRum : Tradepack
    {
        private static SeabreezeRum? instance = null;
        private static readonly object locker = new object();

        SeabreezeRum()
        {
            name = "Seabreeze Rum";
            materials =
            [
                new Material() { Item = Farming.Items.Corn.Instance, Quantity = 10 },
                new Material() { Item = Farming.Items.Cabbage.Instance, Quantity = 8 },
                new Material() { Item = Farming.Items.Banana.Instance, Quantity = 5 },
                new Material() { Item = Farming.Items.Blueberry.Instance, Quantity = 30 }
            ];
        }

        public static SeabreezeRum Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SeabreezeRum();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SettlerRations : Tradepack
    {
        private static SettlerRations? instance = null;
        private static readonly object locker = new object();

        SettlerRations()
        {
            name = "Settler's Rations";
            materials =
            [
                new Material() { Item = Farming.Items.Wheat.Instance, Quantity = 30 },
                new Material() { Item = Farming.Items.Carrot.Instance, Quantity = 35 },
                new Material() { Item = Farming.Items.Corn.Instance, Quantity = 10 }
            ];
        }

        public static SettlerRations Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SettlerRations();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SlumsProvisions : Tradepack
    {
        private static SlumsProvisions? instance = null;
        private static readonly object locker = new object();

        SlumsProvisions()
        {
            name = "Slums Provisions";
            materials =
            [
                new Material() { Item = Farming.Items.Cotton.Instance, Quantity = 10 },
                new Material() { Item = Husbandry.Items.Shank.Instance, Quantity = 8 },
                new Material() { Item = Farming.Items.Potato.Instance, Quantity = 80 }
            ];
        }

        public static SlumsProvisions Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SlumsProvisions();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SombreshadePie : Tradepack
    {
        private static SombreshadePie? instance = null;
        private static readonly object locker = new object();

        SombreshadePie()
        {
            name = "Sombreshade's Pie";
            materials =
            [
                new Material() { Item = Farming.Items.Pumpkin.Instance, Quantity = 5 },
                new Material() { Item = Husbandry.Items.Milk.Instance, Quantity = 10 },
                new Material() { Item = Cooking.Items.GroundFlour.Instance, Quantity = 20 },
                new Material() { Item = Husbandry.Items.Honey.Instance, Quantity = 13 }
            ];
        }

        public static SombreshadePie Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SombreshadePie();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class StrawberryCakes : Tradepack
    {
        private static StrawberryCakes? instance = null;
        private static readonly object locker = new object();

        StrawberryCakes()
        {
            name = "Strawberry Cakes";
            materials =
            [
                new Material() { Item = Husbandry.Items.Milk.Instance, Quantity = 10 },
                new Material() { Item = Farming.Items.Strawberry.Instance, Quantity = 40 },
                new Material() { Item = Husbandry.Items.Honey.Instance, Quantity = 10 }
            ];
        }

        public static StrawberryCakes Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new StrawberryCakes();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class VegetableStew : Tradepack
    {
        private static VegetableStew? instance = null;
        private static readonly object locker = new object();

        VegetableStew()
        {
            name = "Vegetable Stew";
            materials =
            [
                new Material() { Item = Farming.Items.Brocolli.Instance, Quantity = 5 },
                new Material() { Item = Farming.Items.Pumpkin.Instance, Quantity = 5 },
                new Material() { Item = Farming.Items.Bean.Instance, Quantity = 25 },
                new Material() { Item = Farming.Items.Potato.Instance, Quantity = 40 }
            ];
        }

        public static VegetableStew Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new VegetableStew();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class WinemakersKit : Tradepack
    {
        private static WinemakersKit? instance = null;
        private static readonly object locker = new object();

        WinemakersKit()
        {
            name = "Winemakers Kit";
            materials =
            [
                new Material() { Item = Farming.Items.Grape.Instance, Quantity = 40 },
                new Material() { Item = Farming.Items.Blueberry.Instance, Quantity = 15 },
                new Material() { Item = Farming.Items.Moonberry.Instance, Quantity = 5 }
            ];
        }

        public static WinemakersKit Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new WinemakersKit();
                    }

                    return instance;
                }
            }
        }
    }
}
