using System;

namespace GameFramework.Effects
{
    public interface IBattery : IChargeableReadonly
    {
        public float MaxCharge { get; }
        public float CurrentCharge { get; }
        public float CurrentConsumptionPerSecond { get; set; }
        event Action<float> OnCurrentConsumptionPerSecondChanged;
    }
}