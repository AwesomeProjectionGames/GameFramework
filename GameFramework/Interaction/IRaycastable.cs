using UnityEngine;

namespace GameFramework.Interaction
{
    /// <summary>
    /// Interface for objects that can raycast from where they are located (generally associated with camera transform attached scripts).
    /// </summary>
    public interface IRaycastable
    {
        RaycastHit? Raycast(LayerMask mask, float maxDistance);
        bool Raycast(LayerMask mask, float maxDistance, out RaycastHit hit);
    }
}