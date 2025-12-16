using System;
using System.Collections.Generic;

namespace GameFramework
{
    public interface IGameState
    {
        IEnumerable<IController> Controllers { get; }
        IEnumerable<IPawn> Pawns { get; }
        IEnumerable<IActor> Actors { get; }
        Dictionary<string, IActor> ActorsById { get; }
        event Action OnControllersChanged;
        event Action OnPawnsChanged;
        event Action OnActorsChanged;
    }
}