namespace GameFramework.Inventory
{
    /// <summary>
    /// Can be use in any object that need an inventory (generally as a shortcut attached for entities)
    /// </summary>
    public interface IHaveInventory
    {
        public IInventory Inventory { get; }
    }
}