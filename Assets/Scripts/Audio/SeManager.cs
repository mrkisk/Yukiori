using UnityEngine;

namespace Yukiori
{
    public class SeManager : ISeManager
    {
        private readonly ISeRepository _seRepository;
        private readonly AudioSource _audioSource;
        private readonly AudioSource _loopAudioSource;

        public SeManager(ISeRepository seRepository, IAudioSourceFactory audioSourceFactory)
        {
            _seRepository = seRepository;
            _audioSource = audioSourceFactory.Create();
            _loopAudioSource = audioSourceFactory.Create();
        }

        public void Play(SeId seId)
        {
            var se = _seRepository.GetSeData(seId);

            _audioSource.PlayOneShot(se.AudioClip, se.Volume);
        }

        public void PlayLoop(SeId seId)
        {
            var se = _seRepository.GetSeData(seId);

            _loopAudioSource.clip = se.AudioClip;
            _loopAudioSource.loop = true;
            _loopAudioSource.Play();
        }
        
        public void StopLoop()
        {
            _loopAudioSource.Stop();
        }
    }
}
