using MercatorisAdiutor.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercatorisAdiutor.ViewModel
{
    public class CatalogViewModel : BaseViewModel
    {
        private Catalog catalog;
        private List<Item> alchemyItems;
        private List<Item> blacksmithingItems;
        private List<Item> carpentryItems;
        private List<Item> cookingItems;
        private List<Item> farmingItems;
        private List<Item> fishingItems;
        private List<Item> husbandryItems;
        private List<Item> miningItems;
        private List<Item> monsterItems;
        private List<Item> tradepackItems;
        private List<Item> weavingItems;
        private List<Item> woodcuttingItems;

        public CatalogViewModel()
        {
            catalog = new Catalog();

            AlchemyItems = catalog.GetAllAlchemyItems();
            BlacksmithingItems = catalog.GetAllBlacksmithingItems();
            CarpentryItems = catalog.GetAllCarpentryItems();
            CookingItems = catalog.GetAllCookingItems();
            FarmingItems = catalog.GetAllFarmingItems();
            FishingItems = catalog.GetAllFishingItems();
            HusbandryItems = catalog.GetAllHusbandryItems();
            MiningItems = catalog.GetAllMiningItems();
            MonsterItems = catalog.GetAllMonsterItems();
            TradepackItems = catalog.GetAllTradepackItems();
            WeavingItems = catalog.GetAllWeavingItems();
            WoodcuttingItems = catalog.GetAllWoodcuttingItems();
        }

        public List<Item> AlchemyItems
        {
            get
            {
                return alchemyItems;
            }

            set
            {
                alchemyItems = value;
                OnPropertyChanged();
            }
        }

        public List<Item> BlacksmithingItems
        {
            get
            {
                return blacksmithingItems;
            }

            set
            {
                blacksmithingItems = value;
                OnPropertyChanged();
            }
        }

        public List<Item> CarpentryItems
        {
            get
            {
                return carpentryItems;
            }

            set
            {
                carpentryItems = value;
                OnPropertyChanged();
            }
        }

        public List<Item> CookingItems
        {
            get
            {
                return cookingItems;
            }

            set
            {
                cookingItems = value;
                OnPropertyChanged();
            }
        }

        public List<Item> FarmingItems
        {
            get
            {
                return farmingItems;
            }

            set
            {
                farmingItems = value;
                OnPropertyChanged();
            }
        }

        public List<Item> FishingItems
        {
            get
            {
                return fishingItems;
            }

            set
            {
                fishingItems = value;
                OnPropertyChanged();
            }
        }

        public List<Item> HusbandryItems
        {
            get
            {
                return husbandryItems;
            }

            set
            {
                husbandryItems = value;
                OnPropertyChanged();
            }
        }

        public List<Item> MiningItems
        {
            get
            {
                return miningItems;
            }

            set
            {
                miningItems = value;
                OnPropertyChanged();
            }
        }

        public List<Item> MonsterItems
        {
            get
            {
                return monsterItems;
            }

            set
            {
                monsterItems = value;
                OnPropertyChanged();
            }
        }

        public List<Item> TradepackItems
        {
            get
            {
                return tradepackItems;
            }

            set
            {
                tradepackItems = value;
                OnPropertyChanged();
            }
        }

        public List<Item> WeavingItems
        {
            get
            {
                return weavingItems;
            }

            set
            {
                weavingItems = value;
                OnPropertyChanged();
            }
        }


        public List<Item> WoodcuttingItems
        {
            get
            {
                return woodcuttingItems;
            }

            set
            {
                woodcuttingItems = value;
                OnPropertyChanged();
            }
        }
    }
}
