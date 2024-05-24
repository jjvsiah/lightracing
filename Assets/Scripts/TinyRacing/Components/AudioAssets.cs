using Unity.Entities;

namespace LightRacing
{
    [GenerateAuthoringComponent]
    public struct AudioAssets : IComponentData
    {
        public Entity IntroMusic;
        public Entity LevelMusic;
        public Entity EndMusic;
        public Entity CountDown;
        public Entity CarCrash;
    }
}
