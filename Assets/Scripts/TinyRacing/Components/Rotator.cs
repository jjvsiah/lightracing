using Unity.Entities;

namespace LightRacing
{
    [GenerateAuthoringComponent]
    public struct Rotator : IComponentData
    {
        public float RotateSpeed;
    }
}
