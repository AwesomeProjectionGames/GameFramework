using UnityEngine;

namespace GameFramework
{
    public interface IDroppable
    {
        public void Drop(IEntity instigator);
        public void Drop(IEntity instigator, Vector3 dropWorldPosition, Quaternion dropWorldRotation, Vector3 dropVelocity = default);
    }
}