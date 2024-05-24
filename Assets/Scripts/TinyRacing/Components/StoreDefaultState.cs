using Unity.Entities;
using Unity.Mathematics;

namespace LightRacing
{
    [GenerateAuthoringComponent]
    public struct StoreDefaultState : IComponentData
    {
        public float3 StartPosition;
        public quaternion StartRotation;
    }
}
