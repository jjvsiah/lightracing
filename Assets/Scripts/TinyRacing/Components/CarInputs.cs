using Unity.Entities;

namespace LightRacing
{
    [GenerateAuthoringComponent]
    public struct CarInputs : IComponentData
    {
        public float HorizontalAxis;
        public float AccelerationAxis;
    }
}
