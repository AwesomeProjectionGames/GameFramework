using System;

namespace GameFramework.Effects
{
    /// <summary>
    /// An effect that can be charged, such as a weapon, growing, batteries or ability.
    /// </summary>
    public interface IChargeableReadonly
    {
        public float ChargeRatio { get; }
        public float ChargeTime { get; }
        public bool IsCharging { get; }
        event Action<float> OnChargeRatioChanged;
        event Action<float> OnChargeTimeChanged;
        event Action<bool> OnIsChargingChanged;
    }

    /// <summary>
    /// An effect that can be charged and externally modified, such as a weapon, growing, batteries or ability.
    /// </summary>
    public interface IChargeable : IChargeableReadonly
    {
        public new float ChargeRatio { get; set; }
        public new float ChargeTime { get; set; }
        public new bool IsCharging { get; set; }
    }
}