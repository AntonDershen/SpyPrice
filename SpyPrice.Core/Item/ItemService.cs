using Microsoft.EntityFrameworkCore;
using SpyPrice.Data;
using System.Threading.Tasks;

namespace SpyPrice.Core.Item
{
    public class ItemCategoryService : IItemService
    {
        public async Task CreateItem(string name, string code, int itemCategoryId)
        {
            await CreateItem(new Data.Models.Item(name, code, itemCategoryId));
        }

        public async Task CreateItem(Data.Models.Item item)
        {
            using (var context = new ApplicationContext())
            {
                context.Item.Add(item);
                await context.SaveChangesAsync();
            }
        }

        public async Task<bool> ItemExists(string code)
        {
            using (var context = new ApplicationContext())
            {
                return await context.Item
                    .AnyAsync(it => it.Code == code);
            }
        }
    }
}
