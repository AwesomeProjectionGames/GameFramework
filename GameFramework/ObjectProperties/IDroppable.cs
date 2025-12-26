using UnityEngine;

namespace GameFramework.ObjectManipulation
{
    public interface IDroppable
    {
        public void Drop(IPawn instigator, Vector3 dropWorldPosition, Quaternion dropWorldRotation, Vector3 dropVelocity = default);
    }
}