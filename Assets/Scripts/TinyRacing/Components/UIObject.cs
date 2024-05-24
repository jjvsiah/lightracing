using Unity.Entities;

namespace LightRacing
{
    [GenerateAuthoringComponent]
    public struct UIObject : IComponentData
    {
        public enum UITypes
        {
            MainMenuScreen,
            GameScreen,
            EndScreen
        }

        public UITypes UIType;
    }
}
