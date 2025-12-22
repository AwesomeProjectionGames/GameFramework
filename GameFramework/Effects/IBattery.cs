using System;

namespace GameFramework.Effects
{
    /// <summary>
    /// Represents a time-based battery system with support for
    /// continuous charge/drain (units per second) and immediate charge changes.
    /// Intended for gameplay systems such as devices, tools, abilities, or resources.
    /// </summary>
    public interface IBattery : ITickable
    {
        /// <summary>
        /// Maximum battery capacity.
        /// </summary>
        float MaxCapacity { get; set; }

        /// <summary>
        /// Current battery charge.
        /// </summary>
        float CurrentCharge { get; }

        /// <summary>
        /// Charge variation per second.
        /// Positive = charging, Negative = draining, Zero = idle.
        /// </summary>
        float ChargeRatePerSecond { get; set; }

        /// <summary>
        /// True if the battery is currently charging (ChargeRatePerSecond > 0 and not full).
        /// </summary>
        bool IsCharging { get; }
        
        /// <summary>
        /// True if the battery current charge is equal to max capacity.
        /// </summary>
        bool IsFull { get; }
        
        /// <summary>
        /// True if the battery current charge is zero.
        /// </summary>
        bool IsEmpty { get; }

        /// <summary>
        /// Normalized charge value between 0 and 1.
        /// </summary>
        float NormalizedCharge { get; }
        
        /// <summary>
        /// Sets the charge/drain rate in units per second.
        /// </summary>
        void SetChargeRate(float unitsPerSecond);

        /// <summary>
        /// Immediately adds charge (clamped to MaxCapacity).
        /// Returns the actual amount added.
        /// </summary>
        float AddCharge(float amount);

        /// <summary>
        /// Immediately removes charge (clamped to zero).
        /// Returns the actual amount removed.
        /// </summary>
        float RemoveCharge(float amount);

        /// <summary>
        /// Immediately empties the battery.
        /// </summary>
        void Deplete();

        /// <summary>
        /// Immediately fills the battery to max.
        /// </summary>
        void Fill();
    }
}