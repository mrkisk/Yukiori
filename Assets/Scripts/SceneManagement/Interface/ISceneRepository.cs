namespace Yukiori
{
    public interface ISceneRepository
    {
        SceneData GetSceneData(SceneId sceneId);
        SceneId GetStageSceneId(int stageNumber);
    }
}