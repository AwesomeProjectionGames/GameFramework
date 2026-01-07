namespace GameFramework.Inventory
{
    /// <summary>
    /// Define a single dimension inventory with a list of unordered objects
    /// </summary>
    public interface IInventoryOrderableList : IInventory
    {
        /// <summary>
        /// Try to add an item at 
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        /// <param name="removeExistingItem"></param>
        /// <returns></returns>
        bool TryToAddItemAt(IItemActor item, int index, bool removeExistingItem);
        
        /// <summary>
        /// Try to swap two items in the list
        /// </summary>
        /// <param name="index1">The index of the item to swap</param>
        /// <param name="index2">The index of the item to swap</param>
        /// <returns></returns>
        bool TryToSwapItems(int index1, int index2);
    }
}