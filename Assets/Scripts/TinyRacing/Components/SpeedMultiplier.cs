using Unity.Entities;

namespace LightRacing
{
    [GenerateAuthoringComponent]
    public struct SpeedMultiplier : IComponentData
    {
        public float Multiplier;
        public float RemainingTime;
    }
}
