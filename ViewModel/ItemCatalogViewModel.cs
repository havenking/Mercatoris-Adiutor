using MercatorisAdiutor.Model;

namespace MercatorisAdiutor.ViewModel
{
    public class ItemCatalogViewModel : BaseViewModel
    {
        private Database database;
        private Item item;

        public ItemCatalogViewModel(Item item)
        {
            database = Database.Instance;

            this.item = item;
        }

        public int Id => item.Id;

        public string Name => item.Name;

        public string Icon => item.Icon;

        public Profession Profession => item.Profession;

        public Category Category => item.Category;

        public int Price
        {
            get 
            { 
                return item.Price;
            }

            set 
            { 
                item.Price = value;
                UpdatePrice();
            }
        }

        private async void UpdatePrice()
        {
            await database.UpdateDatabaseItemPrice(item.Id, item.Price);
        }
    }
}
