using MercatorisAdiutor.Model.WoodCutting.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MercatorisAdiutor.Model
{
    public static class Database
    {
        public static void InitializeWoodcuttingItems()
        {
            DenseLog.Instance.Price = -1;
            SmallLog.Instance.Price = -1;
            HeavyLog.Instance.Price = -1;
            SturdyLog.Instance.Price = -1;
            FineLog.Instance.Price = -1;
        }
    }
}
