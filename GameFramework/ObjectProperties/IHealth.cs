#nullable enable

using System;

namespace GameFramework
{
    /// <summary>
    /// Represents a component that defines health behavior for an entity.
    /// Can be used to track damage, healing, and life state.
    /// </summary>
    public interface IHealth
    {
        /// <summary>
        /// Gets the current health value of the entity.
        /// Current health should never exceed <see cref="MaxHealth"/> and should not be less than zero.
        /// It can be either a representation of a health amount or a number of lives, depending on the game design.
        /// </summary>
        int CurrentHealth { get; }
        
        /// <summary>
        /// Gets the maximum health value of the entity.
        /// </summary>
        int MaxHealth { get; }
        
        /// <summary>
        /// Invoked when the player's current health has changed, Given the health and DELTA.
        /// </summary>
        event Action<IHealth, int> OnCurrentHealthChanged;
        
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
        /// Apply instant death type of damage to the entity.
        /// It CAN be forcing the entity's health to zero (in the case of CurrentHealth represent a health amount and not a number of lives),
        /// OR it can be removing one life from a pool of lives.
        /// </summary>
        /// <param name="damageType">An integer identifier for the type of damage (e.g. fire, fall, poison). Should be enumerated elsewhere.</param>
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
        /// Reset the current health to the default state (generally the maximum health value)
        /// </summary>
        void ResetCurrentHealth();

        /// <summary>
        /// Removes health from the entity by the specified amount.
        /// Note that instead of directly reducing health, you should favor using damage systems like IDamageable for more coherent experience.
        /// IDamageable should then try to call this method to apply the damage.
        /// </summary>
        /// <param name="damageType">An integer identifier for the type of damage (e.g. fire, fall, poison). Should be enumerated elsewhere.</param>
        /// <param name="amount">The amount of health to remove.</param>
        /// <param name="damageCauser">The actor responsible for causing the damage.</param>
        /// <param name="instigator">The controller that initiated the damage, if applicable.</param>
        void RemoveHealth(int damageType, int amount, IActor damageCauser, IController? instigator = null);
    }
}