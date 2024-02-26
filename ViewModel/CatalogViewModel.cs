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
        private List<ItemCatalogViewModel> alchemyItems;
        private List<ItemCatalogViewModel> blacksmithingItems;
        private List<ItemCatalogViewModel> carpentryItems;
        private List<ItemCatalogViewModel> cookingItems;
        private List<ItemCatalogViewModel> farmingItems;
        private List<ItemCatalogViewModel> fishingItems;
        private List<ItemCatalogViewModel> husbandryItems;
        private List<ItemCatalogViewModel> miningItems;
        private List<ItemCatalogViewModel> monsterItems;
        private List<ItemCatalogViewModel> tradepackItems;
        private List<ItemCatalogViewModel> weavingItems;
        private List<ItemCatalogViewModel> woodcuttingItems;

        public CatalogViewModel()
        {
            catalog = new Catalog();

            alchemyItems = new List<ItemCatalogViewModel>();
            blacksmithingItems = new List<ItemCatalogViewModel>();
            carpentryItems = new List<ItemCatalogViewModel>();
            cookingItems = new List<ItemCatalogViewModel>();
            farmingItems = new List<ItemCatalogViewModel>();
            fishingItems = new List<ItemCatalogViewModel>();
            husbandryItems = new List<ItemCatalogViewModel>();
            miningItems = new List<ItemCatalogViewModel>();
            monsterItems = new List<ItemCatalogViewModel>();
            weavingItems = new List<ItemCatalogViewModel>();
            woodcuttingItems = new List<ItemCatalogViewModel>();

            catalog.GetAllAlchemyItems().ForEach(x => alchemyItems.Add(new ItemCatalogViewModel(x)));
            catalog.GetAllBlacksmithingItems().ForEach(x => blacksmithingItems.Add(new ItemCatalogViewModel(x)));
            catalog.GetAllCarpentryItems().ForEach(x => carpentryItems.Add(new ItemCatalogViewModel(x)));
            catalog.GetAllCookingItems().ForEach(x => cookingItems.Add(new ItemCatalogViewModel(x)));
            catalog.GetAllFarmingItems().ForEach(x => farmingItems.Add(new ItemCatalogViewModel(x)));
            catalog.GetAllFishingItems().ForEach(x => fishingItems.Add(new ItemCatalogViewModel(x)));
            catalog.GetAllHusbandryItems().ForEach(x => husbandryItems.Add(new ItemCatalogViewModel(x)));
            catalog.GetAllMiningItems().ForEach(x => miningItems.Add(new ItemCatalogViewModel(x)));
            catalog.GetAllMonsterItems().ForEach(x => monsterItems.Add(new ItemCatalogViewModel(x)));
            catalog.GetAllWeavingItems().ForEach(x => weavingItems.Add(new ItemCatalogViewModel(x)));
            catalog.GetAllWoodcuttingItems().ForEach(x => woodcuttingItems.Add(new ItemCatalogViewModel(x)));
        }

        public List<ItemCatalogViewModel> AlchemyItems
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

        public List<ItemCatalogViewModel> BlacksmithingItems
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

        public List<ItemCatalogViewModel> CarpentryItems
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

        public List<ItemCatalogViewModel> CookingItems
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

        public List<ItemCatalogViewModel> FarmingItems
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

        public List<ItemCatalogViewModel> FishingItems
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

        public List<ItemCatalogViewModel> HusbandryItems
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

        public List<ItemCatalogViewModel> MiningItems
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

        public List<ItemCatalogViewModel> MonsterItems
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

        public List<ItemCatalogViewModel> TradepackItems
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

        public List<ItemCatalogViewModel> WeavingItems
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


        public List<ItemCatalogViewModel> WoodcuttingItems
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
