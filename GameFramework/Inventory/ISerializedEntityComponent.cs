#nullable enable

using System;
using GameFramework.Dependencies;

namespace GameFramework.Inventory
{
    /// <summary>
    /// Combines observable reactive patterns with component state.
    /// Stat providers implement this interface to expose strongly-typed observable states.
    /// </summary>
    /// <typeparam name="TState">The state struct type.</typeparam>
    public interface ISerializedEntityComponent<TState> : IEntityComponent, IObservable<TState>
    {
        TState CurrentState { get; }
    }
}
