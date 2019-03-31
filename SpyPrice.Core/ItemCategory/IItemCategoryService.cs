using System.Threading.Tasks;

namespace SpyPrice.Core.ItemCategory
{
    public interface IItemCategoryService
    {
        Task CreateItemCategory(Data.Models.ItemCategory itemCategory);

        Task<bool> ItemCategoryExists(string code);
    }
}
