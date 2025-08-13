using UnityEngine;

namespace Yukiori
{
    public class AudioSourceFactory : IAudioSourceFactory
    {
        private readonly GameObject _host;

        public AudioSourceFactory()
        {
            _host = new GameObject("AudioSourceFactory");
            Object.DontDestroyOnLoad(_host);
        }

        public AudioSource Create()
        {
            AudioSource audioSource = _host.AddComponent<AudioSource>();
            return audioSource;
        }
    }
}
