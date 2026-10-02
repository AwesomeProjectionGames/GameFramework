#nullable enable

using System;
using System.Collections.Generic;
using GameFramework.Dependencies;
using UnityEngine;

namespace GameFramework.Inventory
{
    /// <summary>
    /// An actor representing an item (object that can generally be possessed by a pawn) in the game
    /// Capable to be stored in all kind of IInventory.
    /// Items have capabilities / Feature. They are now the same as a regular ActorComponent.
    /// </summary>
    public interface IItemEntityComponent : IEntityComponent, IObserver<Dictionary<string, object>>, IObservable<Dictionary<string, object>>
    {
        string? LocalizedName { get; }
        Texture2D? Icon { get; }
        
        /// <summary>
        /// A dictionary of stats that can be used to store any kind of data related to the item, such as durability, weight, value, etc.
        /// </summary>
        Dictionary<string, object> Stats { get; }
        
        /// <summary>
        /// A prefab that we chould Instantiate to preview the item. It should not have any gameplay related component or network related component.
        /// </summary>
        GameObject? PreviewPrefab { get; }
    }
}
