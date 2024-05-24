using Unity.Entities;

namespace LightRacing
{
    [GenerateAuthoringComponent]
    public struct BoostPad : IComponentData
    {
        public float SpeedMultiplier;
        public float SpeedBoostDuration;
    }
}
