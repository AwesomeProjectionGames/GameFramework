#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;

namespace GameFramework.Inventory
{
    /// <summary>
    /// Define common methods for all inventories
    /// </summary>
    public interface IInventory
    {
        /// <summary>
        /// All items of this inventory. 2D inventories are just a rendering feature over this list.
        /// Note that some entries may be null if the inventory is not full and use an array / orderable mechanism.
        /// </summary>
        IEnumerable<IItem?> Items { get; }
        
        /// <summary>
        /// All non-null items of this inventory.
        /// This is a convenience method to avoid null checks.
        /// Note that, in orderable inventories, this will not change the order of items but remove holes so you cannot base your logic on the index of items.
        /// </summary>
        IEnumerable<IItem> NonNullItems => Items.Where(item => item != null)!;
        
        /// <summary>
        /// Get an item at a specific index.
        /// </summary>
        /// <param name="index">The index of the item to get</param>
        IItem this[int index] { get; }
        
        /// <summary>
        /// The current number of items in the inventory.
        /// </summary>
        int Count { get; }
        
        /// <summary>
        /// The maximum number of items that this inventory can hold.
        /// </summary>
        int MaxItemsCount { get; }
        
        /// <summary>
        /// Try to add an item to the list (next available spot)
        /// </summary>
        /// <param name="item">The item to add</param>
        /// <returns>True only if item was added</returns>
        bool TryToAddItem(IItem item);
        
        /// <summary>
        /// Try to remove an item from the list (first match based on item info hash)
        /// </summary>
        /// <param name="item">The item to find and remove</param>
        /// <returns>True only if item was removed (false if not found)</returns>
        bool TryToRemoveItem(IItem item);
        
        /// <summary>
        /// After an item was added, invoke this with the added item. Note : An item swap will result in 2 * (item removed + item added)
        /// This is the index of the item in the inventory.
        /// </summary>
        event Action<IItem, int> OnItemAdded;
        
        /// <summary>
        /// After an item was deleted, invoke this with the delete item. Note : An item swap will result in 2 * (item removed + item added)
        /// This is the index of the item in the inventory.
        /// </summary>
        event Action<IItem, int> OnItemRemoved;
        
        /// <summary>
        /// Before an item is added, invoke this with the item. The index is the index of the item in the inventory.
        /// </summary>
        event Action<IItem, int>? OnItemWillBeAdded;
        
        /// <summary>
        /// Before an item is removed, invoke this with the item. The index is the index of the item in the inventory.
        /// </summary>
        event Action<IItem, int>? OnItemWillBeRemoved;
        
        /// <summary>
        /// Try to remove an item from the list (at slot index)
        /// </summary>
        /// <param name="index">The slot index</param>
        /// <returns>True only if item was removed (false if index out of bounds, etc...)</returns>
        bool TryToRemoveItemAt(int index);
    }
}