using MercatorisAdiutor.Database.Farming.Items;
using System.Windows.Input;
using System.Xml.Linq;

namespace MercatorisAdiutor.Database.Farming.Objects
{
    public abstract class FarmingGatheringObject : GatheringObject
    {
        internal string name = string.Empty;
        internal int labor = 0;
        internal int cost = 0;
        internal int gatheringNumber = 0;
        internal int gatheringExperience = 0;
        internal int gatheringTime = 0;
        internal Production[] gatheringProduction = Array.Empty<Production>();

        public string Name => name;

        public int Labor => labor;

        public int Cost => cost;

        public int TotalExperience => GatheringExperience * GatheringNumber;

        public int TotalTime => GatheringTime * GatheringNumber;

        public int GatheringNumber => gatheringNumber;

        public int GatheringExperience => gatheringExperience;

        public int GatheringTime => gatheringTime;

        public Production[] TotalProduction
        {
            get
            {
                List<Production> totalProduction = new List<Production>();

                foreach (Production production in GatheringProduction)
                    totalProduction.Add(production * GatheringNumber);

                return totalProduction.ToArray();
            }
        }

        public Production[] GatheringProduction => gatheringProduction;
    }

    public sealed class Potato : FarmingGatheringObject
    {
        private static Potato? instance = null;
        private static readonly object locker = new object();

        Potato()
        {
            name = "Potato";
            labor = 2;
            cost = 85;
            gatheringNumber = 1;
            gatheringExperience = 200;
            gatheringTime = 60;

            gatheringProduction =
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Potato.Instance, Min = 2, Max = 4 }
            ];
        }

        public static Potato Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Potato();
                    }

                    //return instance == null ? new Potato() : instance;
                    return instance;
                }
            }
        }
    }

    public sealed class Cotton : FarmingGatheringObject
    {
        private static Cotton? instance = null;
        private static readonly object locker = new object();

        Cotton ()
        {
            name = "Cotton";
            labor = 90;
            cost = 2475;
            gatheringNumber = 3;
            gatheringExperience = 3600;
            gatheringTime = 270;

            gatheringProduction =
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Cotton.Instance, Min = 4, Max = 8 }
            ];
        }

        public static Cotton Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Cotton();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Corn : FarmingGatheringObject
    {
        private static Corn? instance = null;
        private static readonly object locker = new object();

        Corn ()
        {
            name = "Corn";
            labor = 37;
            cost = 1050;
            gatheringNumber = 1;
            gatheringExperience = 3000;
            gatheringTime = 900;

            gatheringProduction =
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Corn.Instance, Min = 6, Max = 9 }
            ];
        }

        public static Corn Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Corn();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Wheat : FarmingGatheringObject
    {
        private static Wheat? instance = null;
        private static readonly object locker = new object();

        Wheat ()
        {
            name = "Wheat";
            labor = 15;
            cost = 425;
            gatheringNumber = 1;
            gatheringExperience = 1200;
            gatheringTime = 360;

            gatheringProduction =
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Wheat.Instance, Min = 3, Max = 9 }
            ];
        }

        public static Wheat Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Wheat();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Apple : FarmingGatheringObject
    {
        private static Apple? instance = null;
        private static readonly object locker = new object();

        Apple ()
        {
            name = "Apple";
            labor = 150;
            cost = 4125;
            gatheringNumber = 3;
            gatheringExperience = 6000;
            gatheringTime = 450;

            gatheringProduction =
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Apple.Instance, Min = 3, Max = 6 }
            ];
        }

        public static Apple Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Apple();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Carrot : FarmingGatheringObject
    {
        private static Carrot? instance = null;
        private static readonly object locker = new object();

        Carrot ()
        {
            name = "Carrot";
            labor = 5;
            cost = 170;
            gatheringNumber = 1;
            gatheringExperience = 400;
            gatheringTime = 120;

            gatheringProduction =
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Carrot.Instance, Min = 2, Max = 4 }
            ];
        }

        public static Carrot Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Carrot();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Grape : FarmingGatheringObject
    {
        private static Grape? instance = null;
        private static readonly object locker = new object();

        Grape ()
        {
            name = "Grape";
            labor = 15;
            cost = 425;
            gatheringNumber = 1;
            gatheringExperience = 1200;
            gatheringTime = 360;

            gatheringProduction =
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Grape.Instance, Min = 2, Max = 4 }
            ];
        }

        public static Grape Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Grape();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Blueberry : FarmingGatheringObject
    {
        private static Blueberry? instance = null;
        private static readonly object locker = new object();

        Blueberry ()
        {
            name = "Blueberry";
            labor = 15;
            cost = 425;
            gatheringNumber = 1;
            gatheringExperience = 1200;
            gatheringTime = 360;

            gatheringProduction =
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Blueberry.Instance, Min = 9, Max = 15 }
            ];
        }

        public static Blueberry Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Blueberry();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Cabbage : FarmingGatheringObject
    {
        private static Cabbage? instance = null;
        private static readonly object locker = new object();

        Cabbage ()
        {
            name = "Cabbage";
            labor = 15;
            cost = 425;
            gatheringNumber = 1;
            gatheringExperience = 1200;
            gatheringTime = 360;

            gatheringProduction =
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Cabbage.Instance, Min = 2, Max = 4 }
            ];
        }

        public static Cabbage Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Cabbage();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Pepper : FarmingGatheringObject
    {
        private static Pepper? instance = null;
        private static readonly object locker = new object();

        Pepper ()
        {
            name = "Pepper";
            labor = 71;
            cost = 1975;
            gatheringNumber = 1;
            gatheringExperience = 5700;
            gatheringTime = 1710;

            gatheringProduction =
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Pepper.Instance, Min = 9, Max = 15 }
            ];
        }

        public static Pepper Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Pepper();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Cherry : FarmingGatheringObject
    {
        private static Cherry? instance = null;
        private static readonly object locker = new object();

        Cherry ()
        {
            name = "Cherry";
            labor = 420;
            cost = 11500;
            gatheringNumber = 3;
            gatheringExperience = 16800;
            gatheringTime = 1260;

            gatheringProduction =
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Cherry.Instance, Min = 6, Max = 12 }
            ];
        }

        public static Cherry Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Cherry();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Orange : FarmingGatheringObject
    {
        private static Orange? instance = null;
        private static readonly object locker = new object();

        Orange ()
        {
            name = "Orange";
            labor = 300;
            cost = 8250;
            gatheringNumber = 3;
            gatheringExperience = 12000;
            gatheringTime = 900;

            gatheringProduction =
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Orange.Instance, Min = 3, Max = 6 }
            ];
        }

        public static Orange Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Orange();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Onion : FarmingGatheringObject
    {
        private static Onion? instance = null;
        private static readonly object locker = new object();

        Onion ()
        {
            name = "Onion";
            labor = 22;
            cost = 625;
            gatheringNumber = 1;
            gatheringExperience = 1800;
            gatheringTime = 540;

            gatheringProduction =
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Onion.Instance, Min = 3, Max = 6 }
            ];
        }

        public static Onion Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Onion();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Strawberry : FarmingGatheringObject
    {
        private static Strawberry? instance = null;
        private static readonly object locker = new object();

        Strawberry ()
        {
            name = "Strawberry";
            labor = 18;
            cost = 525;
            gatheringNumber = 1;
            gatheringExperience = 1500;
            gatheringTime = 450;

            gatheringProduction =
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Strawberry.Instance, Min = 6, Max = 12 }
            ];
        }

        public static Strawberry Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Strawberry();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Beans : FarmingGatheringObject
    {
        private static Beans? instance = null;
        private static readonly object locker = new object();

        Beans ()
        {
            name = "Beans";
            labor = 37;
            cost = 1050;
            gatheringNumber = 1;
            gatheringExperience = 3000;
            gatheringTime = 900;

            gatheringProduction =
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Bean.Instance, Min = 9, Max = 15 }
            ];
        }

        public static Beans Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Beans();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Banana : FarmingGatheringObject
    {
        private static Banana? instance = null;
        private static readonly object locker = new object();

        Banana ()
        {
            name = "Banana";
            labor = 480;
            cost = 13175;
            gatheringNumber = 3;
            gatheringExperience = 19200;
            gatheringTime = 1440;

            gatheringProduction =
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Banana.Instance, Min = 6, Max = 12 }
            ];
        }

        public static Banana Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Banana();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Pumpkin : FarmingGatheringObject
    {
        private static Pumpkin? instance = null;
        private static readonly object locker = new object();

        Pumpkin ()
        {
            name = "Pumpkin";
            labor = 60;
            cost = 1650;
            gatheringNumber = 1;
            gatheringExperience = 4800;
            gatheringTime = 1440;

            gatheringProduction =
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Pumpkin.Instance, Min = 2, Max = 4 }
            ];
        }

        public static Pumpkin Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Pumpkin();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Watermelon : FarmingGatheringObject
    {
        private static Watermelon? instance = null;
        private static readonly object locker = new object();

        Watermelon ()
        {
            name = "Watermelon";
            labor = 75;
            cost = 2050;
            gatheringNumber = 1;
            gatheringExperience = 6000;
            gatheringTime = 1800;

            gatheringProduction =
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Watermelon.Instance, Min = 2, Max = 4 }
            ];
        }

        public static Watermelon Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Watermelon();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Pea : FarmingGatheringObject
    {
        private static Pea? instance = null;
        private static readonly object locker = new object();

        Pea ()
        {
            name = "Pea";
            labor = 48;
            cost = 1350;
            gatheringNumber = 1;
            gatheringExperience = 3900;
            gatheringTime = 1170;

            gatheringProduction =
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Pea.Instance, Min = 9, Max = 15 }
            ];
        }

        public static Pea Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Pea();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Moonberry : FarmingGatheringObject
    {
        private static Moonberry? instance = null;
        private static readonly object locker = new object();

        Moonberry ()
        {
            name = "Moonberry";
            labor = 52;
            cost = 1450;
            gatheringNumber = 1;
            gatheringExperience = 4200;
            gatheringTime = 1260;

            gatheringProduction =
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Moonberry.Instance, Min = 3, Max = 9 }
            ];
        }

        public static Moonberry Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Moonberry();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Garlic : FarmingGatheringObject
    {
        private static Garlic? instance = null;
        private static readonly object locker = new object();

        Garlic ()
        {
            name = "Garlic";
            labor = 41;
            cost = 1150;
            gatheringNumber = 1;
            gatheringExperience = 3300;
            gatheringTime = 990;

            gatheringProduction =
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Garlic.Instance, Min = 6, Max = 12 }
            ];
        }

        public static Garlic Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Garlic();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Acorn : FarmingGatheringObject
    {
        private static Acorn? instance = null;
        private static readonly object locker = new object();

        Acorn ()
        {
            name = "Acorn";
            labor = 960;
            cost = 26250;
            gatheringNumber = 3;
            gatheringExperience = 38400;
            gatheringTime = 2880;

            gatheringProduction =
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Acorn.Instance, Min = 6, Max = 12 }
            ];
        }

        public static Acorn Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Acorn();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Brocolli : FarmingGatheringObject
    {
        private static Brocolli? instance = null;
        private static readonly object locker = new object();

        Brocolli ()
        {
            name = "Brocolli";
            labor = 37;
            cost = 1050;
            gatheringNumber = 1;
            gatheringExperience = 3000;
            gatheringTime = 900;

            gatheringProduction =
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Brocolli.Instance, Min = 3, Max = 6 }
            ];
        }

        public static Brocolli Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Brocolli();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Sunberry : FarmingGatheringObject
    {
        private static Sunberry? instance = null;
        private static readonly object locker = new object();

        Sunberry ()
        {
            name = "Sunberry";
            labor = 75;
            cost = 2050;
            gatheringNumber = 1;
            gatheringExperience = 6000;
            gatheringTime = 1800;

            gatheringProduction =
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Sunberry.Instance, Min = 3, Max = 9 }
            ];
        }

        public static Sunberry Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Sunberry();
                    }

                    return instance;
                }
            }
        }
    }
}
