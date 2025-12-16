#nullable enable

using System;
using UnityEngine;

namespace GameFramework.Inventory
{
    /// <summary>
    /// An inventory that can be selected.
    /// For example, one item can be selected at a time, and the user can navigate through the items with scroll or buttons.
    /// This can be used to select an item and iteract with him while picked up.
    /// </summary>
    public interface ISelectableInventory : IInventory
    {
        /// <summary>
        /// The current selected index.
        /// Note that setting this index will (MUST in implementations) use a modulo operation to ensure it is within the bounds of the inventory.
        /// </summary>
        int SelectedIndex { get; set; }
        IItem? SelectedItem { get; }
        event Action<IItem?> OnSelectedItemChanged;
        Transform SelectedAnchorTransform { get; }
        Transform DefaultAnchorTransform { get; }
        
        /// <summary>
        /// The owner of this inventory.
        /// </summary>
        IActor Owner { get; }

        void IncrementSelected()
        {
            // We try to enforce try to enforce a modulo implementation
            SelectedIndex++;
        }

        void DecrementSelected()
        {
            // We try to enforce try to enforce a modulo implementation
            SelectedIndex--;
        }
    }
}