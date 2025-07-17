using UnityEngine;

namespace Yukiori
{
    public class AudioSourceFactory : IAudioSourceFactory
    {
        private readonly GameObject _host;

        public AudioSourceFactory(GameObject host)
        {
            _host = host;
        }

        public AudioSource Create()
        {
            AudioSource audioSource = _host.AddComponent<AudioSource>();
            return audioSource;
        }
    }
}
