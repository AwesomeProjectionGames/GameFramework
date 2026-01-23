#nullable enable

using GameFramework.Bus;
using GameFramework.Dependencies;

namespace GameFramework
{
    /// <summary>
    /// Exists once per game run, persists across level transitions.
    /// Global manager for systems that need to survive across levels.
    /// </summary>
    public interface IGameInstance
    {
        /// <summary>
        /// Event bus for global event communication (system wide).
        /// </summary>
        public IEventBus EventBus { get; }
                
        /// <summary>
        /// The global services container (dependency injection container).
        /// Register only services that need to persist across levels / not stateful per level.
        /// </summary>
        public IComponentsContainer Services { get; }
        
        /// <summary>
        /// The current game mode or null if no mode is active.
        /// </summary>
        public IGameMode? CurrentGameMode { get;  }
    }
}