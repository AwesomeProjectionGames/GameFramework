using UnityEngine;

namespace GameFramework
{
    /// <summary>
    /// Character is a specialized Pawn that represents a controllable entity with movement capabilities.
    /// </summary>
    public interface ICharacter : IPawn
    {
        Vector3 Velocity { get; }
    }
}