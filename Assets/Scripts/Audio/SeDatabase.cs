using UnityEngine;

namespace Yukiori
{
    public enum SeId
    {
        NONE,
        UI_BUTTON_CLICK,
    }
    
    [System.Serializable]
    public class SeData
    {
        [SerializeField] private SeId _seId;
        [SerializeField] private AudioClip _audioClip;
        [SerializeField] private float _volume;

        public SeId SeId => _seId;
        public AudioClip AudioClip => _audioClip;
        public float Volume => _volume;
    }
    
    [CreateAssetMenu(fileName = "SeDatabase", menuName = "Korori/SeDatabase")]
    public class SeDatabase : ScriptableObject
    {
        [SerializeField] private SeData[] _seDatas;

        public SeData[] SeDatas => _seDatas;
    }
}