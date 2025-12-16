namespace GameFramework.Inventory
{
    public interface IItemStack
    {
        IItem ItemModel { get; }
        int CurrentCount { get; }
        int MaxCount { get; }
        
        bool IsEmpty();
        
        bool Add(int amount);
        bool CanAdd(int amount);
        
        bool Remove(int amount);
        bool CanRemove(int amount);
    }
}