using CustomPresenter.Models;
using Intersoft.Crosslight;

namespace CustomPresenter.ModelServices
{
    public interface IItemRepository : IEditableDataRepository<Item, string>
    {
        #region Methods

        CategoryGroup GetCategoryGroup(int group);
        GroupItem<Item> GetLocationGroup(string group);

        #endregion
    }
}