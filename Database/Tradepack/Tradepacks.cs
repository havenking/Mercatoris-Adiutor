using System.Windows.Media.Media3D;

namespace MercatorisAdiutor.Database.Tradepack.Tradepacks
{
    public enum TradePosts
    {
        Riverend,
        Margrove,
        OrcaBay,
        Seabreeze,
        Tarmire,
        Darzuac,
        Gilead,
        Glaceforde,
        Ravencrest,
        Defiance
    }

    public enum TradepackStatus
    {
        Active,
        Inactive
    }

    public abstract class Tradepack
    {
        internal string name = string.Empty;
        internal int price = 0;
        internal TradepackStatus status = TradepackStatus.Active;
        internal Material[] materials = Array.Empty<Material>();

        public string Name => name;

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
}
