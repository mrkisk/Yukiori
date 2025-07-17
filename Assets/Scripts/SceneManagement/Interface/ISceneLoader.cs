namespace Yukiori
{
    public interface ISceneLoader
    {
        void LoadPreviousScene();
        void LoadNextScene();
        void LoadStageScene(int stageId);
    }
}
