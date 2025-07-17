using UnityEngine;

namespace Yukiori
{
    public class SceneManager : ISceneLoader
    {
        private static ISceneLoader _instance;
        public static ISceneLoader Instance => _instance;

        private readonly ISceneRepository _sceneRepository;

        private SceneId _currentSceneId = SceneId.TITLE;

        public SceneManager(ISceneRepository sceneRepository)
        {
            _instance = this;
            
            _sceneRepository = sceneRepository;
        }

        private void Load(SceneId sceneId)
        {
            SceneData sceneData = _sceneRepository.GetSceneData(sceneId);
            if (sceneData != null)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(sceneData.ScenePath);
            }
            else
            {
                Debug.LogError($"Scene with ID {sceneId} not found in the database.");
            }
        }

        public void LoadPreviousScene()
        {
            SceneId previousSceneId = _sceneRepository.GetSceneData(_currentSceneId).PreviousSceneId;
            Load(previousSceneId);
        }

        public void LoadNextScene()
        {
            SceneId nextSceneId = _sceneRepository.GetSceneData(_currentSceneId).NextSceneId;
            Load(nextSceneId);
        }

        public void LoadStageScene(int stageNumber)
        {
            SceneId stageSceneId = _sceneRepository.GetStageSceneId(stageNumber);
            Load(stageSceneId);
        }
    }
}