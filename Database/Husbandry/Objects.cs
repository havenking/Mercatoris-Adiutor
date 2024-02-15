using System.Linq;

namespace MercatorisAdiutor.Database.Husbandry.Objects
{
    public abstract class HusbandryGatheringObject : GatheringObject
    {
        internal string name = string.Empty;
        internal int labor = 0;
        internal int cost = 0;
        internal int gatheringNumber = 0;
        internal int gatheringExperience = 0;
        internal int gatheringTime = 0;
        internal Production[] gatheringProduction = Array.Empty<Production>();
        internal int butcheringNumber = 0;
        internal int butcheringExperience = 0;
        internal int butcheringTime = 0;
        internal Production[] butcheringProduction = Array.Empty<Production>();

        internal Material[] materials = Array.Empty<Material>();

        public string Name => name;

        public int Labor => labor;

        public int Cost => cost;

        public int TotalExperience => (GatheringExperience * GatheringNumber) + (ButcheringExperience * ButcheringNumber);

        public int TotalTime => GatheringTime * GatheringNumber;

        public int GatheringNumber => gatheringNumber;

        public int GatheringExperience => gatheringExperience;

        public int GatheringTime => gatheringTime;

        public int ButcheringNumber => butcheringNumber;

        public int ButcheringExperience => butcheringExperience;

        public int ButcheringTime => butcheringTime;

        public Production[] TotalProduction
        {
            get
            {
                List<Production> totalProduction = new List<Production>();
                int index;

                foreach (Production production in GatheringProduction)
                {
                    totalProduction.Add(production * GatheringNumber);
                }

                foreach (Production production in ButcheringProduction)
                {
                    index = totalProduction.FindIndex(prodA => prodA.Item.Equals(production.Item));
                    Production aux = production * ButcheringNumber;

                    if (index != -1)
                    {
                        totalProduction[index] += (aux);
                    }
                    else
                    {
                        totalProduction.Add(aux);
                    }
                }

                return totalProduction.ToArray();
            }
        }

        public Production[] GatheringProduction => gatheringProduction;

        public Production[] ButcheringProduction => butcheringProduction;

        public Material[] Materials => materials;
    }

    public sealed class SmallPigPen : HusbandryGatheringObject
    {
        private static SmallPigPen? instance = null;
        private static readonly object locker = new object();

        SmallPigPen()
        {
            name = "Small Pig Pen";
            labor = 160;
            cost = 1150;
            butcheringNumber = 1;
            butcheringExperience = 6400;
            butcheringTime = 480;

            butcheringProduction =
            [
                new Production() { Item = Items.Fertilizer.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Shank.Instance, Min = 4, Max = 8 },
                new Production() { Item = Items.Hide.Instance, Min = 4, Max = 8 }
            ];
        }

        public static SmallPigPen Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallPigPen();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SmallHarePen : HusbandryGatheringObject
    {
        private static SmallHarePen? instance = null;
        private static readonly object locker = new object();

        SmallHarePen()
        {
            name = "Small Hare Pen";
            labor = 100;
            cost = 1150;
            gatheringNumber = 2;
            gatheringExperience = 1600;
            gatheringTime = 120;
            butcheringNumber = 1;
            butcheringExperience = 4000;
            butcheringTime = 300;

            gatheringProduction =
            [
                new Production() { Item = Items.Fertilizer.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.SpoolOfHair.Instance, Min = 4, Max = 6 }
            ];

            butcheringProduction =
            [
                new Production() { Item = Items.Fertilizer.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Chicken.Instance, Min = 3, Max = 5 }
            ];
        }

        public static SmallHarePen Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallHarePen();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SmallChickenPen : HusbandryGatheringObject
    {
        private static SmallChickenPen? instance = null;
        private static readonly object locker = new object();

        SmallChickenPen()
        {
            name = "Small Chiken Pen";
            labor = 100;
            cost = 1150;
            gatheringNumber = 2;
            gatheringExperience = 1600;
            gatheringTime = 120;
            butcheringNumber = 1;
            butcheringExperience = 4000;
            butcheringTime = 300;

            gatheringProduction =
            [
                new Production() { Item = Items.Fertilizer.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Egg.Instance, Min = 4, Max = 6 }
            ];

            butcheringProduction =
            [
                new Production() { Item = Items.Fertilizer.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Chicken.Instance, Min = 3, Max = 5 }
            ];
        }

        public static SmallChickenPen Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallChickenPen();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SmallGoatPen : HusbandryGatheringObject
    {
        private static SmallGoatPen? instance = null;
        private static readonly object locker = new object();

        SmallGoatPen()
        {
            name = "Small Goat Pen";
            labor = 130;
            cost = 2000;
            gatheringNumber = 2;
            gatheringExperience = 2000;
            gatheringTime = 150;
            butcheringNumber = 1;
            butcheringExperience = 5200;
            butcheringTime = 390;

            gatheringProduction =
            [
                new Production() { Item = Items.Fertilizer.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Milk.Instance, Min = 2, Max = 3 },
                new Production() { Item = Items.Wool.Instance, Min = 1, Max = 1 }
            ];

            butcheringProduction =
            [
                new Production() { Item = Items.Fertilizer.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Shank.Instance, Min = 4, Max = 7 }
            ];
        }

        public static SmallGoatPen Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallGoatPen();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SmallTurkeyPen : HusbandryGatheringObject
    {
        private static SmallTurkeyPen? instance = null;
        private static readonly object locker = new object();

        SmallTurkeyPen()
        {
            name = "Small Turkey Pen";
            labor = 190;
            cost = 1450;
            butcheringNumber = 1;
            butcheringExperience = 7600;
            butcheringTime = 570;

            butcheringProduction =
            [
                new Production() { Item = Items.Fertilizer.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Chicken.Instance, Min = 3, Max = 5 },
                new Production() { Item = Items.Feather.Instance, Min = 2, Max = 5 }
            ];
        }

        public static SmallTurkeyPen Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallTurkeyPen();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SmallSheepPen : HusbandryGatheringObject
    {
        private static SmallSheepPen? instance = null;
        private static readonly object locker = new object();

        SmallSheepPen()
        {
            name = "Small Sheep Pen";
            labor = 240;
            cost = 2875;
            gatheringNumber = 2;
            gatheringExperience = 4000;
            gatheringTime = 300;
            butcheringNumber = 1;
            butcheringExperience = 9600;
            butcheringTime = 720;

            gatheringProduction =
            [
                new Production() { Item = Items.Fertilizer.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Wool.Instance, Min = 3, Max = 5 }
            ];

            butcheringProduction =
            [
                new Production() { Item = Items.Fertilizer.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Shank.Instance, Min = 8, Max = 12 }
            ];
        }

        public static SmallSheepPen Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallSheepPen();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class CheeseBarrel : HusbandryGatheringObject
    {
        private static CheeseBarrel? instance = null;
        private static readonly object locker = new object();

        CheeseBarrel()
        {
            name = "Cheese Barrel";
            labor = 150;
            cost = 2525;
            gatheringNumber = 1;
            gatheringExperience = 6000;
            gatheringTime = 1800;

            gatheringProduction =
            [
                new Production() { Item = Items.Cheese.Instance, Min = 1, Max = 2 }
            ];

            materials =
            [
                new Material() { Item = Items.Milk.Instance, Quantity = 1 }
            ];
        }

        public static CheeseBarrel Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CheeseBarrel();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class BeeHive : HusbandryGatheringObject
    {
        private static BeeHive? instance = null;
        private static readonly object locker = new object();

        BeeHive()
        {
            name = "Bee Hive";
            labor = 224;
            cost = 3850;
            gatheringNumber = 1;
            gatheringExperience = 9000;
            gatheringTime = 270;

            gatheringProduction =
            [
                new Production() { Item = Items.Honey.Instance, Min = 12, Max = 24 }
            ];
        }

        public static BeeHive Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new BeeHive();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class SmallCowPen : HusbandryGatheringObject
    {
        private static SmallCowPen? instance = null;
        private static readonly object locker = new object();

        SmallCowPen()
        {
            name = "Small Cow Pen";
            labor = 400;
            cost = 2875;
            gatheringNumber = 2;
            gatheringExperience = 2400;
            gatheringTime = 180;
            butcheringNumber = 1;
            butcheringExperience = 16000;
            butcheringTime = 1200;

            gatheringProduction =
            [
                new Production() { Item = Items.Fertilizer.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Milk.Instance, Min = 3, Max = 5 }
            ];

            butcheringProduction =
            [
                new Production() { Item = Items.Fertilizer.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Beef.Instance, Min = 6, Max = 11 },
                new Production() { Item = Items.Hide.Instance, Min = 6, Max = 9 }
            ];
        }

        public static SmallCowPen Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SmallCowPen();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumChickenPen : HusbandryGatheringObject
    {
        private static MediumChickenPen? instance = null;
        private static readonly object locker = new object();

        MediumChickenPen()
        {
            name = "Medium Chicken Pen";
            labor = 224;
            cost = 2875;
            gatheringNumber = 2;
            gatheringExperience = 3600;
            gatheringTime = 120;
            butcheringNumber = 1;
            butcheringExperience = 9000;
            butcheringTime = 300;

            gatheringProduction =
            [
                new Production() { Item = Items.Fertilizer.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Egg.Instance, Min = 9, Max = 14 }
            ];

            butcheringProduction =
            [
                new Production() { Item = Items.Fertilizer.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Chicken.Instance, Min = 7, Max = 12 }
            ];
        }

        public static MediumChickenPen Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumChickenPen();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumHarePen : HusbandryGatheringObject
    {
        private static MediumHarePen? instance = null;
        private static readonly object locker = new object();

        MediumHarePen()
        {
            name = "Medium Hare Pen";
            labor = 224;
            cost = 2875;
            gatheringNumber = 2;
            gatheringExperience = 3600;
            gatheringTime = 120;
            butcheringNumber = 1;
            butcheringExperience = 9000;
            butcheringTime = 300;

            gatheringProduction =
            [
                new Production() { Item = Items.Fertilizer.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.SpoolOfHair.Instance, Min = 9, Max = 14 }
            ];

            butcheringProduction =
            [
                new Production() { Item = Items.Fertilizer.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Chicken.Instance, Min = 7, Max = 12 }
            ];
        }

        public static MediumHarePen Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumHarePen();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumPigPen : HusbandryGatheringObject
    {
        private static MediumPigPen? instance = null;
        private static readonly object locker = new object();

        MediumPigPen()
        {
            name = "Medium Pig Pen";
            labor = 360;
            cost = 3375;
            butcheringNumber = 1;
            butcheringExperience = 14400;
            butcheringTime = 480;

            butcheringProduction =
            [
                new Production() { Item = Items.Fertilizer.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Shank.Instance, Min = 6, Max = 9 },
                new Production() { Item = Items.Hide.Instance, Min = 6, Max = 9 }
            ];
        }

        public static MediumPigPen Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumPigPen();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumGoatPen : HusbandryGatheringObject
    {
        private static MediumGoatPen? instance = null;
        private static readonly object locker = new object();

        MediumGoatPen()
        {
            name = "Medium Goat Pen";
            labor = 292;
            cost = 4175;
            gatheringNumber = 2;
            gatheringExperience = 4500;
            gatheringTime = 150;
            butcheringNumber = 1;
            butcheringExperience = 11700;
            butcheringTime = 390;

            gatheringProduction =
            [
                new Production() { Item = Items.Fertilizer.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Milk.Instance, Min = 4, Max = 6 },
                new Production() { Item = Items.Wool.Instance, Min = 2, Max = 4 }
            ];

            butcheringProduction =
            [
                new Production() { Item = Items.Fertilizer.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Shank.Instance, Min = 9, Max = 14 }
            ];
        }

        public static MediumGoatPen Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumGoatPen();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumTurkeyPen : HusbandryGatheringObject
    {
        private static MediumTurkeyPen? instance = null;
        private static readonly object locker = new object();

        MediumTurkeyPen()
        {
            name = "Medium Turkey Pen";
            labor = 428;
            cost = 3850;
            butcheringNumber = 1;
            butcheringExperience = 17100;
            butcheringTime = 570;

            butcheringProduction =
            [
                new Production() { Item = Items.Fertilizer.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Chicken.Instance, Min = 9, Max = 13 },
                new Production() { Item = Items.Feather.Instance, Min = 5, Max = 8 }
            ];
        }

        public static MediumTurkeyPen Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumTurkeyPen();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumSheepPen : HusbandryGatheringObject
    {
        private static MediumSheepPen? instance = null;
        private static readonly object locker = new object();

        MediumSheepPen()
        {
            name = "Medium Sheep Pen";
            labor = 540;
            cost = 6375;
            gatheringNumber = 2;
            gatheringExperience = 9000;
            gatheringTime = 300;
            butcheringNumber = 1;
            butcheringExperience = 21600;
            butcheringTime = 720;

            gatheringProduction =
            [
                new Production() { Item = Items.Fertilizer.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Wool.Instance, Min = 8, Max = 11 }
            ];

            butcheringProduction =
            [
                new Production() { Item = Items.Fertilizer.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Shank.Instance, Min = 18, Max = 27 }
            ];
        }

        public static MediumSheepPen Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumSheepPen();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class MediumCowPen : HusbandryGatheringObject
    {
        private static MediumCowPen? instance = null;
        private static readonly object locker = new object();

        MediumCowPen()
        {
            name = "Medium Cow Pen";
            labor = 900;
            cost = 6375;
            gatheringNumber = 2;
            gatheringExperience = 5400;
            gatheringTime = 180;
            butcheringNumber = 1;
            butcheringExperience = 36000;
            butcheringTime = 1200;

            gatheringProduction =
            [
                new Production() { Item = Items.Fertilizer.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Milk.Instance, Min = 8, Max = 11 }
            ];

            butcheringProduction =
            [
                new Production() { Item = Items.Fertilizer.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Beef.Instance, Min = 15, Max = 22 },
                new Production() { Item = Items.Hide.Instance, Min = 14, Max = 21 }
            ];
        }

        public static MediumCowPen Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MediumCowPen();
                    }

                    return instance;
                }
            }
        }
    }
}
