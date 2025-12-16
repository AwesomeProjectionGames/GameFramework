using UnityEngine;

namespace GameFramework.ObjectManipulation
{
    public interface IThrowable
    {
        /// <summary>
        /// Throws the item towards a target position with a specified velocity. Unlike the Drop method, we guarantee to hit a certain spot - hitPoint (if not object is between). We don't expect to handle the continuous changing end position.
        /// </summary>
        void ThrowAtPosition(IPawn instigator, Vector3 dropWorldPosition, Quaternion dropWorldRotation, Vector3 hitPoint, Vector3 hitNormal, float velocity);

        /// <summary>
        /// Throws the item towards a target actor with a specified velocity. Unlike the Drop method, we guarantee to hit the actor. We expect it to handle the continuous changing end position.
        /// </summary>
        void ThrowAtActor(IPawn instigator, Vector3 dropWorldPosition, Quaternion dropWorldRotation, Vector3 hitPoint, Vector3 hitNormal, float velocity, IActor actorTarget, Vector3 actorPosition);
        
        /// <summary>
        /// Precise if the item should be thrown or dropped (if false) when the player uses it.
        /// </summary>
        bool CanBeThrown { get; }
    }
}