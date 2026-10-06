#nullable enable

using GameFramework.Dependencies;
using UnityEngine;

namespace GameFramework.Inventory
{
    /// <summary>
    /// An actor representing an item (object that can generally be possessed by a pawn) in the game.
    /// Capable to be stored in all kind of IInventory.
    /// Items have capabilities / features represented as entity components.
    /// </summary>
    public interface IItemEntityComponent : IEntityComponent
    {
        string? LocalizedName { get; }
        Texture2D? Icon { get; }
        
        /// <summary>
        /// A prefab that can be instantiated to preview the item. It should not have any gameplay-related or network-related component.
        /// </summary>
        GameObject? PreviewPrefab { get; }
    }
}
