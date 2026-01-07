namespace GameFramework.Inventory
{
    public interface IItemStack
    {
        /// <summary>
        /// The item model should point to a replicable instance (something that we can Instanciate or Clone)
        /// </summary>
        IItemActor ItemModel { get; }
        int CurrentCount { get; }
        int MaxCount { get; }
        
        bool IsEmpty();
        
        bool Add(int amount);
        bool CanAdd(int amount);
        
        bool Remove(int amount);
        bool CanRemove(int amount);
    }
}