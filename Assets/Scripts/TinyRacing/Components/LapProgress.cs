using Unity.Entities;

namespace LightRacing
{
    [GenerateAuthoringComponent]
    public struct LapProgress : IComponentData
    {
        public int CurrentLap;
        public int CurrentControlPoint;
        public float TotalProgress;
        public float CurrentControlPointProgress;
    }
}
