using UnityEngine;

namespace Yukiori
{
    public enum SceneId
    {
        NONE,
        TITLE,
        STAGE_SELECTION,
        OPENING,
        STAGE_01, STAGE_02, STAGE_03, STAGE_04, STAGE_05, STAGE_06, STAGE_07, STAGE_08, STAGE_09, STAGE_10,
        STAGE_11, STAGE_12, STAGE_13, STAGE_14, STAGE_15, STAGE_16, STAGE_17, STAGE_18, STAGE_19, STAGE_20,
    }

    [System.Serializable]
    public class SceneData
    {
        [SerializeField] private SceneId _sceneId;
        [SerializeField] private string _scenePath;
        [SerializeField] private SceneId _previousSceneId;
        [SerializeField] private SceneId _nextSceneId;

        public SceneId SceneId => _sceneId;
        public string ScenePath => _scenePath;
        public SceneId PreviousSceneId => _previousSceneId;
        public SceneId NextSceneId => _nextSceneId;
    }
    
    [CreateAssetMenu(fileName = "SceneDatabase", menuName = "Korori/SceneDatabase")]
    public class SceneDatabase : ScriptableObject
    {
        [SerializeField] private SceneData[] _sceneDatas;

        public SceneData[] SceneDatas => _sceneDatas;
    }
}
