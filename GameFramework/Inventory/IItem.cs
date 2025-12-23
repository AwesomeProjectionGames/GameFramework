#nullable enable

using System.Collections.Generic;
using GameFramework.Identification;
using UnityEngine;

namespace GameFramework.Inventory
{
    public interface IItem : IHaveUUID
    {
        /// <summary>
        /// The base item identifier. Use to respawn the same item with default features configuration.
        /// Each instance of one prefab will have the same identifier.
        /// Don't confuse with UUID, which is unique for each instance.
        /// </summary>
        string Identifier { get; }
        string LocalizedName { get; }
        Sprite Icon { get; }
        List<IItemFeature> Features { get; }
        
        /// <summary>
        /// Try to get a feature of type T from the item.
        /// </summary>
        /// <typeparam name="T">A type that implements IItemFeature</typeparam>
        /// <returns>Return the first feature of type T if it exists, otherwise null.</returns>
        T? GetFeature<T>() where T : IItemFeature;
    }
}