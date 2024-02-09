using System.Windows.Input;

namespace MercatorisAdiutor.Database.Farming.Objects
{
    public struct Potato : GatheringObject
    {
        public string Name => nameof(Potato);

        public int Experience => 200;

        public int Labor => 2;

        public int Time => 60;

        public int Cost => 85;

        public Production[] Production =>
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Potato.Instance, Min = 2, Max = 4 }
            ];
    }

    public struct Cotton : GatheringObject
    {
        public string Name => nameof(Cotton);

        public int Experience => 3600;

        public int Labor => 90;

        public int Time => 270;

        public int Cost => 2475;

        public Production[] Production =>
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Cotton.Instance, Min = 4, Max = 8 }
            ];
    }

    public struct Corn : GatheringObject
    {
        public string Name => nameof(Corn);

        public int Experience => 3000;

        public int Labor => 37;

        public int Time => 900;

        public int Cost => 1050;

        public Production[] Production =>
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Corn.Instance, Min = 6, Max = 9 }
            ];
    }

    public struct Wheat : GatheringObject
    {
        public string Name => nameof(Wheat);

        public int Experience => 1200;

        public int Labor => 15;

        public int Time => 360;

        public int Cost => 425;

        public Production[] Production =>
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Wheat.Instance, Min = 3, Max = 9 }
            ];
    }

    public struct Apple : GatheringObject
    {
        public string Name => nameof(Apple);

        public int Experience => 6000;

        public int Labor => 150;

        public int Time => 450;

        public int Cost => 4125;

        public Production[] Production =>
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Apple.Instance, Min = 3, Max = 6 }
            ];
    }

    public struct Carrot : GatheringObject
    {
        public string Name => nameof(Carrot);

        public int Experience => 400;

        public int Labor => 5;

        public int Time => 120;

        public int Cost => 170;

        public Production[] Production =>
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Carrot.Instance, Min = 2, Max = 4 }
            ];
    }

    public struct Grape : GatheringObject
    {
        public string Name => nameof(Grape);

        public int Experience => 1200;

        public int Labor => 15;

        public int Time => 360;

        public int Cost => 425;

        public Production[] Production =>
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Grape.Instance, Min = 2, Max = 4 }
            ];
    }

    public struct Blueberry : GatheringObject
    {
        public string Name => nameof(Blueberry);

        public int Experience => 1200;

        public int Labor => 15;

        public int Time => 360;

        public int Cost => 425;

        public Production[] Production =>
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Blueberry.Instance, Min = 9, Max = 15 }
            ];
    }

    public struct Cabbage : GatheringObject
    {
        public string Name => nameof(Cabbage);

        public int Experience => 1200;

        public int Labor => 15;

        public int Time => 360;

        public int Cost => 425;

        public Production[] Production =>
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Cabbage.Instance, Min = 2, Max = 4 }
            ];
    }

    public struct Pepper : GatheringObject
    {
        public string Name => nameof(Pepper);

        public int Experience => 5700;

        public int Labor => 71;

        public int Time => 1710;

        public int Cost => 1975;

        public Production[] Production =>
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Pepper.Instance, Min = 9, Max = 15 }
            ];
    }

    public struct Cherry : GatheringObject
    {
        public string Name => nameof(Cherry);

        public int Experience => 16800;

        public int Labor => 420;

        public int Time => 1260;

        public int Cost => 11500;

        public Production[] Production =>
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Cherry.Instance, Min = 6, Max = 12 }
            ];
    }

    public struct Orange : GatheringObject
    {
        public string Name => nameof(Orange);

        public int Experience => 12000;

        public int Labor => 300;

        public int Time => 900;

        public int Cost => 8250;

        public Production[] Production =>
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Orange.Instance, Min = 3, Max = 6 }
            ];
    }

    public struct Onion : GatheringObject
    {
        public string Name => nameof(Onion);

        public int Experience => 1800;

        public int Labor => 22;

        public int Time => 540;

        public int Cost => 625;

        public Production[] Production =>
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Onion.Instance, Min = 3, Max = 6 }
            ];
    }

    public struct Strawberry : GatheringObject
    {
        public string Name => nameof(Strawberry);

        public int Experience => 1500;

        public int Labor => 18;

        public int Time => 450;

        public int Cost => 525;

        public Production[] Production =>
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Strawberry.Instance, Min = 6, Max = 12 }
            ];
    }

    public struct Beans : GatheringObject
    {
        public string Name => nameof(Beans);

        public int Experience => 3000;

        public int Labor => 37;

        public int Time => 900;

        public int Cost => 1050;

        public Production[] Production =>
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Bean.Instance, Min = 9, Max = 15 }
            ];
    }

    public struct Banana : GatheringObject
    {
        public string Name => nameof(Banana);

        public int Experience => 19200;

        public int Labor => 480;

        public int Time => 1440;

        public int Cost => 13175;

        public Production[] Production =>
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Banana.Instance, Min = 6, Max = 12 }
            ];
    }

    public struct Pumpkin : GatheringObject
    {
        public string Name => nameof(Pumpkin);

        public int Experience => 4800;

        public int Labor => 60;

        public int Time => 1440;

        public int Cost => 1650;

        public Production[] Production =>
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Pumpkin.Instance, Min = 2, Max = 4 }
            ];
    }

    public struct Watermelon : GatheringObject
    {
        public string Name => nameof(Watermelon);

        public int Experience => 6000;

        public int Labor => 75;

        public int Time => 1800;

        public int Cost => 2050;

        public Production[] Production =>
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Watermelon.Instance, Min = 2, Max = 4 }
            ];
    }

    public struct Pea : GatheringObject
    {
        public string Name => nameof(Pea);

        public int Experience => 3900;

        public int Labor => 48;

        public int Time => 1170;

        public int Cost => 1350;

        public Production[] Production =>
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Pea.Instance, Min = 9, Max = 15 }
            ];
    }

    public struct Moonberry : GatheringObject
    {
        public string Name => nameof(Moonberry);

        public int Experience => 4200;

        public int Labor => 52;

        public int Time => 1260;

        public int Cost => 1450;

        public Production[] Production =>
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Moonberry.Instance, Min = 3, Max = 9 }
            ];
    }

    public struct Garlic : GatheringObject
    {
        public string Name => nameof(Garlic);

        public int Experience => 3300;

        public int Labor => 41;

        public int Time => 990;

        public int Cost => 1150;

        public Production[] Production =>
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Garlic.Instance, Min = 6, Max = 12 }
            ];
    }

    public struct Acorn : GatheringObject
    {
        public string Name => nameof(Acorn);

        public int Experience => 38400;

        public int Labor => 960;

        public int Time => 2880;

        public int Cost => 26250;

        public Production[] Production =>
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Acorn.Instance, Min = 6, Max = 12 }
            ];
    }

    public struct Brocolli : GatheringObject
    {
        public string Name => nameof(Brocolli);

        public int Experience => 3000;

        public int Labor => 37;

        public int Time => 900;

        public int Cost => 1050;

        public Production[] Production =>
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Brocolli.Instance, Min = 3, Max = 6 }
            ];
    }

    public struct Sunberry : GatheringObject
    {
        public string Name => nameof(Sunberry);

        public int Experience => 6000;

        public int Labor => 75;

        public int Time => 1800;

        public int Cost => 2050;

        public Production[] Production =>
            [
                new Production() { Item = Items.ThreeLeafClover.Instance, Min = 0, Max = 1 },
                new Production() { Item = Items.Sunberry.Instance, Min = 3, Max = 9 }
            ];
    }
}
