using UnityEngine;

namespace Yukiori
{
    public class AudioManager : IAudioEnableControl
    {
        private bool _isAudioEnabled = true;
        
        public bool IsAudioEnabled
        {
            get => _isAudioEnabled;
            set => _isAudioEnabled = value;
        }

        public void SetAudioEnabled(bool enabled)
        {
            _isAudioEnabled = enabled;
            AudioListener.volume = _isAudioEnabled ? 1f : 0f;
        }
    }
}