namespace MercatorisAdiutor.Database
{
    public class ItemDatabase : Database
    {
        public ItemDatabase()
            :base()
        {

        }

        public Item[] Search()
        {
            List<Item> results = new List<Item>();

            return results.ToArray();
        }
    }
}
