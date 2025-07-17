using System.Collections.Generic;

namespace Yukiori
{
    public class SceneRepository : ISceneRepository
    {
        private readonly SceneDatabase _sceneDatabase;
        private readonly Dictionary<SceneId, SceneData> _sceneDataCache;

        public SceneRepository(SceneDatabase sceneDatabase)
        {
            _sceneDatabase = sceneDatabase;

            _sceneDataCache = new Dictionary<SceneId, SceneData>();
            foreach (var sceneData in _sceneDatabase.SceneDatas)
            {
                _sceneDataCache[sceneData.SceneId] = sceneData;
            }
        }

        public SceneData GetSceneData(SceneId sceneId)
        {
            return _sceneDataCache.TryGetValue(sceneId, out var sceneData) ? sceneData : null;
        }

        public SceneId GetStageSceneId(int stageNumber)
        {
            // ステージ番号（1ベース）をSceneIdに変換
            if (stageNumber < 1 || stageNumber > 20)
            {
                return SceneId.NONE;
            }
            
            return SceneId.STAGE_01 + (stageNumber - 1);
        }
    }
}