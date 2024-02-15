using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercatorisAdiutor.Database.WoodCutting.Objects
{
    public abstract class WoodCuttingGatheringObject : GatheringObject
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

    public sealed class Juniper : WoodCuttingGatheringObject
    {
        private static Juniper? instance = null;
        private static readonly object locker = new object();

        Juniper ()
        {
            name = "Juniper";
            labor = 20;
            cost = 550;
            gatheringNumber = 1;
            gatheringExperience = 1800;
            gatheringTime = 120;

            gatheringProduction =
            [
                new Production() { Item = Items.DenseLog.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.SmallLog.Instance, Min = 4, Max = 8 }
            ];
        }

        public static Juniper Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Juniper();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Fir : WoodCuttingGatheringObject
    {
        private static Fir? instance = null;
        private static readonly object locker = new object();

        Fir ()
        {
            name = "Fir";
            labor = 80;
            cost = 2200;
            gatheringNumber = 1;
            gatheringExperience = 6400;
            gatheringTime = 480;

            gatheringProduction =
            [
                new Production() { Item = Items.DenseLog.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.SmallLog.Instance, Min = 20, Max = 26 }
            ];
        }

        public static Fir Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Fir();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Palm : WoodCuttingGatheringObject
    {
        private static Palm? instance = null;
        private static readonly object locker = new object();

        Palm ()
        {
            name = "Palm";
            labor = 60;
            cost = 1650;
            gatheringNumber = 1;
            gatheringExperience = 4800;
            gatheringTime = 360;

            gatheringProduction =
            [
                new Production() { Item = Items.DenseLog.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.HeavyLog.Instance, Min = 14, Max = 19 }
            ];
        }

        public static Palm Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Palm();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Oak : WoodCuttingGatheringObject
    {
        private static Oak? instance = null;
        private static readonly object locker = new object();

        Oak ()
        {
            name = "Oak";
            labor = 240;
            cost = 6600;
            gatheringNumber = 1;
            gatheringExperience = 19000;
            gatheringTime = 1440;

            gatheringProduction =
            [
                new Production() { Item = Items.DenseLog.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.SmallLog.Instance, Min = 50, Max = 80 }
            ];
        }

        public static Oak Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Oak();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Wildleaf : WoodCuttingGatheringObject
    {
        private static Wildleaf? instance = null;
        private static readonly object locker = new object();

        Wildleaf ()
        {
            name = "Wildleaf";
            labor = 160;
            cost = 4400;
            gatheringNumber = 1;
            gatheringExperience = 13000;
            gatheringTime = 960;

            gatheringProduction =
            [
                new Production() { Item = Items.DenseLog.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.SturdyLog.Instance, Min = 28, Max = 37 }
            ];
        }

        public static Wildleaf Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Wildleaf();
                    }

                    return instance;
                }
            }
        }
    }

    public sealed class Willow : WoodCuttingGatheringObject
    {
        private static Willow? instance = null;
        private static readonly object locker = new object();

        Willow ()
        {
            name = "Willow";
            labor = 120;
            cost = 3300;
            gatheringNumber = 1;
            gatheringExperience = 9600;
            gatheringTime = 720;

            gatheringProduction =
            [
                new Production() { Item = Items.DenseLog.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.FineLog.Instance, Min = 14, Max = 19 }
            ];
        }

        public static Willow Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Willow();
                    }

                    return instance;
                }
            }
        }
    }
}
