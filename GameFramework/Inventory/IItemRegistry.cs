using System.Collections.Generic;

namespace GameFramework.Inventory
{
    /// <summary>
    /// A manager that permit to reconstruct items from a hash or an id
    /// Used to respawn the same item with DEFAULT features configuration.
    /// Each instance of one prefab will have the same identifier.
    /// Don't confuse with UUID, which is unique for each instance.
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