namespace Yukiori
{
    public interface ISceneLoader
    {
        SceneRepository.SceneType CurrentSceneType { get; }
        int CurrentStageId { get; }

        void LoadInitial();
        void LoadPrevious();
        void LoadNext();
        void LoadStage(int stageId);
        void LoadNextStage();
        bool HasNextStage();
    }
}
