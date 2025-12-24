using System;
using System.Collections.Generic;
using GameFramework.Identification;

namespace GameFramework
{
    /// <summary>
    /// Represents state of the game that clients need to know.
    /// Scope / Persistence: Level-specific, replicated to clients.
    /// Key Responsibilities:
    /// - Holds all actors, including PlayerControllers.
    /// - Track player scores, match time, number of players.
    /// - Replicate game rules or state from server to clients.
    /// - Acts as a read-only interface for clients to query game state.
    /// </summary>
    public interface IGameState : IIDRegistry
    {
        IEnumerable<IController> Controllers { get; }
        IEnumerable<IActor> Actors { get; }
        Dictionary<string, IActor> ActorsById { get; }
        event Action OnControllersChanged;
        event Action OnActorsChanged;
    }
}