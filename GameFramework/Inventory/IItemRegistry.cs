using System.Collections.Generic;
using GameFramework.Identification;

namespace GameFramework.Inventory
{
    /// <summary>
    /// A manager that permit to reconstruct items from a hash or an id
    /// Used to respawn the same item with DEFAULT features configuration.
    /// Each instance of one prefab will have the same identifier.
    /// Don't confuse with UUID, which is unique for each instance.
    /// </summary>
    public interface IItemRegistry : IEnumerable<IItemActor>, IIDRegistry
    {
        IItemActor this[string id] { get; }

        IEnumerable<IItemActor> AllItems { get; }

        IItemActor GetItemOfId(string id);

        bool TryGetItemOfId(string id, out IItemActor item);

        bool RegisterItem(string id, IItemActor item);
    }
}