#nullable enable

using System.Collections.Generic;
using UnityEngine;

namespace GameFramework
{
    public interface IPhysics
    {
        Rigidbody Rigidbody { get; }
    }
    
    public interface ICollider
    {
        Collider Collider { get; }
    }
    
    public interface IColliders
    {
        IEnumerable<Collider> Colliders { get; }
    }
    
    public interface IRenderer
    {
        Renderer Renderer { get; }
    }
    
    public interface IRenderers
    {
        IEnumerable<Renderer> Renderers { get; }
    }
    
    public interface ITransform
    {
        Transform Transform { get; }
    }

    public interface IInstigator
    {
        IEntity? Instigator { get; }
    }
}
