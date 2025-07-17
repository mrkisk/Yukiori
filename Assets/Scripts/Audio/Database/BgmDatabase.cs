using UnityEngine;

namespace Yukiori
{
    public enum BgmId
    {
        NONE,
        DEFAULT,
    }

    [System.Serializable]
    public class BgmData
    {
        [SerializeField] private BgmId _bgmId;
        [SerializeField] private AudioClip _audioClip;
        [SerializeField] private float _volume;

        public BgmId BgmId => _bgmId;
        public AudioClip AudioClip => _audioClip;
        public float Volume => _volume;
    }

    [CreateAssetMenu(fileName = "BgmDatabase", menuName = "Korori/BgmDatabase")]
    public class BgmDatabase : ScriptableObject
    {
        [SerializeField] private BgmData[] _bgmDatas;
        
        public BgmData[] BgmDatas => _bgmDatas;
    }
}