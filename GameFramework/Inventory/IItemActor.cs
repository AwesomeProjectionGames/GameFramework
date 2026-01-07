#nullable enable

using UnityEngine;

namespace GameFramework.Inventory
{
    /// <summary>
    /// An actor representing an item (object that can generally be possessed by a pawn) in the game
    /// Capable to be stored in all kind of IInventory.
    /// Items have capabilities / Feature. They are now the same as a regular ActorComponent.
    /// </summary>
    public interface IItemActor : IActor
    {
        /// <summary>
        /// The base item identifier. Use to respawn the same item with default features configuration.
        /// Each instance of one prefab will have the same identifier.
        /// Don't confuse with UUID, which is unique for each instance.
        /// This can, for example, be the ResourcePath of the item prefab.
        /// </summary>
        string Identifier { get; }
        string? LocalizedName { get; }
        Texture2D? Icon { get; }
    }
}