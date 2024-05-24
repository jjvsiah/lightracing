using Unity.Entities;

namespace LightRacing
{
    [GenerateAuthoringComponent]
    public struct AI : IComponentData
    {
        public float NormalDistanceFromTrack;
    }
}
