using System.Threading.Tasks;

namespace SpyPrice.Core.Item
{
    public interface IItemService
    {
        Task CreateItem(string name, string code, int itemCategoryId);

        Task CreateItem(Data.Models.Item item);

        Task<bool> ItemExists(string code);
    }
}
