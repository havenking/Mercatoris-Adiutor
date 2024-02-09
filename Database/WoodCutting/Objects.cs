using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercatorisAdiutor.Database.WoodCutting.Objects
{
    public struct Juniper : GatheringObject
    {
        public string Name => nameof(Juniper);

        public int Experience => 1800;

        public int Labor => 20;

        public int Time => 120;

        public int Cost => 550;

        public Production[] Production =>
            [
                new Production() { Item = Items.DenseLog.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.SmallLog.Instance, Min = 4, Max = 8 }
            ];
    }

    public struct Fir : GatheringObject
    {
        public string Name => nameof(Fir);

        public int Experience => 6400;

        public int Labor => 80;

        public int Time => 480;

        public int Cost => 2200;

        public Production[] Production =>
            [
                new Production() { Item = Items.DenseLog.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.SmallLog.Instance, Min = 20, Max = 26 }
            ];
    }

    public struct Palm : GatheringObject
    {
        public string Name => nameof(Palm);

        public int Experience => 4800;

        public int Labor => 60;

        public int Time => 360;

        public int Cost => 1650;

        public Production[] Production =>
            [
                new Production() { Item = Items.DenseLog.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.HeavyLog.Instance, Min = 14, Max = 19 }
            ];
    }

    public struct Oak : GatheringObject
    {
        public string Name => nameof(Oak);

        public int Experience => 19000;

        public int Labor => 240;

        public int Time => 1440;

        public int Cost => 6600;

        public Production[] Production =>
            [
                new Production() { Item = Items.DenseLog.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.SmallLog.Instance, Min = 50, Max = 80 }
            ];
    }

    public struct Wildleaf : GatheringObject
    {
        public string Name => nameof(Wildleaf);

        public int Experience => 13000;

        public int Labor => 160;

        public int Time => 960;

        public int Cost => 4400;

        public Production[] Production =>
            [
                new Production() { Item = Items.DenseLog.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.SturdyLog.Instance, Min = 28, Max = 37 }
            ];
    }

    public struct Willow : GatheringObject
    {
        public string Name => nameof(Willow);

        public int Experience => 9600;

        public int Labor => 120;

        public int Time => 720;

        public int Cost => 3300;

        public Production[] Production =>
            [
                new Production() { Item = Items.DenseLog.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.FineLog.Instance, Min = 14, Max = 19 }
            ];
    }
}
