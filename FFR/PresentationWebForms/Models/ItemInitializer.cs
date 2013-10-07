using System.Collections.Generic;
using System.Data.Entity;
using PresentationWebForms;


namespace PresentationWebForms.Models
{
    public class ItemInitializer : DropCreateDatabaseIfModelChanges<ItemContext>
    {
        protected override void Seed(ItemContext context)
        {
            GetItems().ForEach(p => context.Items.Add(p));
        }

        private static List<Item> GetItems()
        {


            var items = new List<Item> {
                new Item
                {
                    ItemId = 1,
                    ItemName = "FP Green Test",
                    Price = 900,
                    QuantityAvailable = 10
                },
                new Item
                {
                    ItemId =2,
                    ItemName = "FP Red Test",
                    Price = 1200,
                    QuantityAvailable = 10
                }
                
            };

            return items;
        }

    }
}