namespace Yukiori
{
    public interface ISceneLoader
    {
        void LoadInitialScene();
        void LoadPreviousScene();
        void LoadNextScene();
        void LoadStageScene(int stageId);
    }
}
