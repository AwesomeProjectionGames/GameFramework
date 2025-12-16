using System.Collections.Generic;

namespace GameFramework.Inventory
{
    /// <summary>
    /// A manager that permit to reconstruct items from a hash or an id
    /// </summary>
    public interface IItemRegistry : IEnumerable<IItem>
    {
        IItem this[string id] { get; }

        IEnumerable<IItem> AllItems { get; }

        IItem GetItemOfId(string id);

        bool TryGetItemOfId(string id, out IItem item);

        bool RegisterItem(string id, IItem item);
    }
}