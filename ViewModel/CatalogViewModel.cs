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
        private IList<Item> woodcuttingItems;

        public CatalogViewModel()
        {
            catalog = new Catalog();

            WoodcuttingItems = catalog.GetAllWoodcuttingItems();
        }

        public IList<Item> WoodcuttingItems
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
