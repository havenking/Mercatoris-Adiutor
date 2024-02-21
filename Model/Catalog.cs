using MercatorisAdiutor.Model.WoodCutting.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercatorisAdiutor.Model
{
    public  class Catalog
    {
        public Catalog() 
        {
            Database.InitializeWoodcuttingItems();
        }

        public IList<Item> GetAllWoodcuttingItems()
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
