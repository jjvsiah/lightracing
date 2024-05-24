using Unity.Entities;

namespace LightRacing
{
    [GenerateAuthoringComponent]
    public struct Car : IComponentData
    {
        public float CurrentSpeed;
        public float MaxSpeed;
        public float RotationSpeed;
        public bool IsEngineDestroyed;
        public bool PlayCrashAudio;
    }
}
