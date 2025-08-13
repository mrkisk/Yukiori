using UnityEngine.SceneManagement;
using SceneType = Yukiori.SceneRepository.SceneType;

namespace Yukiori
{
    public class SceneManager : ISceneLoader
    {
        private static ISceneLoader _instance;
        public static ISceneLoader Instance => _instance;

        private readonly SceneRepository _sceneRepository;
        
        private SceneType _currentSceneType;
        private int _currentStageNumber;
        
        public SceneType CurrentSceneType => _currentSceneType;
        public int CurrentStageId => _currentStageNumber;

        public SceneManager(SceneRepository sceneRepository)
        {
            _instance = this;

            _sceneRepository = sceneRepository;
        }

        private void LoadScene(SceneType sceneType)
        {
            string scenePath = _sceneRepository.GetScenePath(sceneType);
            UnityEngine.SceneManagement.SceneManager.LoadScene(scenePath);_currentSceneType = sceneType;
        }

        private void LoadStageScene(int stageNumber)
        {
            string scenePath = _sceneRepository.GetStageScenePath(stageNumber);
            UnityEngine.SceneManagement.SceneManager.LoadScene(scenePath);
            _currentSceneType = SceneType.STAGE;
            _currentStageNumber = stageNumber;
        }

        public void LoadInitial()
        {
            if (_currentSceneType == SceneType.STAGE)
            {
                LoadScene(SceneType.TITLE);
            }
        }

        public void LoadPrevious()
        {
            if (_currentSceneType == SceneType.STAGE_SELECT)
            {
                LoadScene(SceneType.TITLE);
            }
            else if (_currentSceneType == SceneType.STAGE)
            {
                LoadScene(SceneType.STAGE_SELECT);
            }
        }

        public void LoadNext()
        {
            if (_currentSceneType == SceneType.TITLE)
            {
                LoadScene(SceneType.STAGE_SELECT);
            }
            else if (_currentSceneType == SceneType.OPENING)
            {
                LoadStageScene(1);
            }
        }

        public void LoadStage(int stageNumber)
        {
            if (stageNumber == 1)
            {
                LoadScene(SceneType.OPENING);
            }
            else
            {
                LoadStageScene(stageNumber);
            }
        }

        public void LoadNextStage()
        {
            if (HasNextStage())
            {
                LoadStage(_currentStageNumber + 1);
            }
        }
        
        public bool HasNextStage()
        {
            return _currentStageNumber < SceneRepository.MaxStageCount;
        }
    }
}