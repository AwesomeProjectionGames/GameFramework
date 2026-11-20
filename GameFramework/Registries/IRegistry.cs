#nullable enable

using System.Collections.Generic;

namespace GameFramework.Registries
{
    /// <summary>
    /// Generic interface for an in-memory key-value registry.
    /// </summary>
    /// <typeparam name="T">Type of elements stored in the registry.</typeparam>
    public interface IRegistry<T> : IEnumerable<T>
    {
        T? this[string id] { get; }
        IEnumerable<T> All { get; }
        int Count { get; }
        bool Contains(string id);
        T? GetById(string id);
        bool Register(string id, T item);
        bool Unregister(string id);
    }
}
