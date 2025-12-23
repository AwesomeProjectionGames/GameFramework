using GameFramework.Bus;

namespace GameFramework
{
    /// <summary>
    /// Exists once per game run, persists across level transitions.
    /// Global manager for systems that need to survive across levels.
    /// </summary>
    public class IGameInstance
    {
        /// <summary>
        /// Event bus for global event communication (system wide).
        /// </summary>
        public IEventBus EventBus { get; }
    }
}