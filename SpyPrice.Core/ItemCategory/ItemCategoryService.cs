using Microsoft.EntityFrameworkCore;
using SpyPrice.Data;
using System.Threading.Tasks;

namespace SpyPrice.Core.ItemCategory
{
    public class ItemCategoryService : IItemCategoryService
    {
        public async Task CreateItemCategory(Data.Models.ItemCategory itemCategory)
        {
            using (var context = new ApplicationContext())
            {
                context.ItemCategory.Add(itemCategory);
                await context.SaveChangesAsync();
            }
        }
        public async Task<bool> ItemCategoryExists(string code)
        {
            using (var context = new ApplicationContext())
            {
                return await context.ItemCategory
                    .AnyAsync(it => it.Code == code);
            }
        }
    }
}
