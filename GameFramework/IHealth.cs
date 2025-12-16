#nullable enable

namespace GameFramework
{
    /// <summary>
    /// Represents a component that defines health behavior for an entity.
    /// Can be used to track damage, healing, and life state.
    /// </summary>
    public interface IHealth
    {
        /// <summary>
        /// Gets or sets the current health value of the entity.
        /// </summary>
        int CurrentHealth { get; }
        
        /// <summary>
        /// Gets the health percentage of the entity, calculated as a float between 0 and 1.
        /// </summary>
        float HealthPercentage { get; }

        /// <summary>
        /// Determines whether the entity is currently alive.
        /// </summary>
        /// <returns><c>true</c> if <see cref="CurrentHealth"/> is greater than 0; otherwise, <c>false</c>.</returns>
        public bool IsAlive { get; }

        /// <summary>
        /// Forces the entity's health to zero, effectively killing it.
        /// </summary>
        /// <param name="damageType">An integer identifier for the type of damage (e.g. fire, fall, poison).</param>
        /// <param name="damageCauser">The actor responsible for causing the damage.</param>
        /// <param name="instigator">The controller that initiated the action, if applicable.</param>
        void Kill(int damageType, IActor damageCauser, IController? instigator = null);

        /// <summary>
        /// Increases the entity's health by the specified amount.
        /// </summary>
        /// <param name="amount">The amount of health to restore.</param>
        /// <param name="healer">The actor responsible for healing</param>
        void Heal(int amount, IActor healer, IController? instigator = null);

        /// <summary>
        /// Removes health from the entity by the specified amount.
        /// </summary>
        /// <param name="amount">The amount of health to remove.</param>
        /// <param name="damageCauser">The actor responsible for causing the damage.</param>
        /// <param name="instigator">The controller that initiated the damage, if applicable.</param>
        void RemoveHealth(int amount, IActor damageCauser, IController? instigator = null);
    }
}