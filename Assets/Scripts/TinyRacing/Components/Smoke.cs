using Unity.Entities;

namespace LightRacing
{
    [GenerateAuthoringComponent]
    public struct Smoke : IComponentData
    {
        public Entity CarSmoke;
        public Entity Explosion;
        public Entity ExplosionPrefab;
    }
}
