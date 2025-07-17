using System.Collections.Generic;

namespace Yukiori
{
    public class AudioRepository : IBgmRepository, ISeRepository
    {
        private readonly BgmDatabase _bgmDatabase;
        private readonly SeDatabase _seDatabase;

        private readonly Dictionary<BgmId, BgmData> _bgmDataCache = new Dictionary<BgmId, BgmData>();
        private readonly Dictionary<SeId, SeData> _seDataCache = new Dictionary<SeId, SeData>();

        public AudioRepository(BgmDatabase bgmDatabase, SeDatabase seDatabase)
        {
            _bgmDatabase = bgmDatabase;
            _seDatabase = seDatabase;

            foreach (var bgmData in _bgmDatabase.BgmDatas)
            {
                _bgmDataCache[bgmData.BgmId] = bgmData;
            }
            
            foreach (var seData in _seDatabase.SeDatas)
            {
                _seDataCache[seData.SeId] = seData;
            }
        }

        public BgmData GetBgmData(BgmId bgmId)
        {
            return _bgmDataCache.TryGetValue(bgmId, out var bgmData) ? bgmData : null;
        }

        public SeData GetSeData(SeId seId)
        {
            return _seDataCache.TryGetValue(seId, out var seData) ? seData : null;
        }
    }
}