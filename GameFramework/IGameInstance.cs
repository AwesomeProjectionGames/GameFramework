#nullable enable

using GameFramework.Bus;
using GameFramework.Dependencies;

namespace GameFramework
{
    /// <summary>
    /// Exists once per game run, persists across level transitions.
    /// Global manager for systems that need to survive across levels.
    /// </summary>
    public interface IGameInstance : IEntity
    {
        /// <summary>
        /// The current game mode or null if no mode is active.
        /// </summary>
        public IGameMode? CurrentGameMode { get; set; }
    }
}