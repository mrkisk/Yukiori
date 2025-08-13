namespace Yukiori
{
    public class SceneRepository
    {
        public enum SceneType
        {
            TITLE,
            STAGE_SELECT,
            OPENING,
            STAGE,
        }
        
        private readonly string[] _scenePaths = new string[]
        {
            "Scenes/Title",
            "Scenes/StageSelect",
            "Scenes/Opening",
            "Scenes/Stages/Stage"
        };
        
        public const int MaxStageCount = 20;

        public SceneRepository()
        {
        }

        public string GetScenePath(SceneType sceneType)
        {
            return _scenePaths[(int)sceneType];
        }

        public string GetStageScenePath(int stageNumber)
        {
            return _scenePaths[(int)SceneType.STAGE] + stageNumber.ToString("D2");
        }
    }
}