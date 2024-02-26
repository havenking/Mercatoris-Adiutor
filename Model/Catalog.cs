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
        Database database;

        public Catalog() 
        {
            database = Database.Instance;
        }

        public List<Item> GetAllAlchemyItems()
        {
            return database.GetAllAlchemyItems();
        }

        public List<Item> GetAllBlacksmithingItems()
        {
            return database.GetAllBlacksmithingItems();
        }

        public List<Item> GetAllCarpentryItems()
        {
            return database.GetAllCarpentryItems();
        }

        public List<Item> GetAllCookingItems()
        {
            return database.GetAllCookingItems();
        }

        public List<Item> GetAllFarmingItems()
        {
            return database.GetAllFarmingItems();
        }

        public List<Item> GetAllFishingItems()
        {
            return database.GetAllFishingItems();
        }

        public List<Item> GetAllHusbandryItems()
        {
            return database.GetAllHusbandryItems();
        }

        public List<Item> GetAllMiningItems()
        {
            return database.GetAllMiningItems();
        }

        public List<Item> GetAllMonsterItems()
        {
            return database.GetAllMonsterItems();
        }

        public List<Item> GetAllWeavingItems()
        {
            return database.GetAllWeavingItems();
        }

        public List<Item> GetAllWoodcuttingItems()
        {
            return database.GetAllWoodcuttingItems();
        }
    }
}
