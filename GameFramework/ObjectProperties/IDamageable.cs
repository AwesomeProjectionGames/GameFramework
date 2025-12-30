#nullable enable

using UnityEngine;

namespace GameFramework
{
    /// <summary>
    /// Defines an actor that can receive point or radial damage.
    /// </summary>
    public interface IDamageable
    {
        /// <summary>
        /// Applies point damage to the object at a specific hit location.
        /// </summary>
        /// <param name="damage">Amount of damage to apply.</param>
        /// <param name="damageType">Type of damage being applied. Should be an enum value cast to int.</param>
        /// <param name="hitLocation">World-space location where the hit occurred.</param>
        /// <param name="hitNormal">Normal vector at the hit location.</param>
        /// <param name="shotFromDirection">Direction the shot came from.</param>
        /// <param name="speed">Speed of the damaging projectile or effect.</param>
        /// <param name="damageCauser">Actor responsible for causing the damage. Can be anonymous if it wasn't an actor that caused it (only if it's the world / object with no importance).</param>
        /// <param name="instigator">Optional pawn that initiated the damage (e.g. a player).</param>
        void ReceivePointDamage(int damage, int damageType, Vector3 hitLocation, Vector3 hitNormal, Vector3 shotFromDirection,
            float speed, IActor? damageCauser = null, IPawn? instigator = null);

        /// <summary>
        /// Applies radial damage to the object based on its distance from the origin.
        /// </summary>
        /// <param name="damage">Maximum damage at the center of the effect.</param>
        /// <param name="damageType">Type of damage being applied. Should be an enum value cast to int.</param>
        /// <param name="origin">Center of the damage radius.</param>
        /// <param name="minimumDamageDistance">Distance within which full damage is applied.</param>
        /// <param name="maximumDamageDistance">Distance beyond which no damage is applied.</param>
        /// <param name="speed">Speed of the damaging effect.</param>
        /// <param name="damageCauser">Actor responsible for causing the damage. Can be anonymous if it wasn't an actor that caused it (only if it's the world / object with no importance).</param>
        /// <param name="instigator">Optional pawn that initiated the damage.</param>
        void ReceiveRadialDamage(int damage, int damageType, Vector3 origin, float minimumDamageDistance, float maximumDamageDistance,
            float speed, IActor? damageCauser = null, IPawn? instigator = null);
    }
}
