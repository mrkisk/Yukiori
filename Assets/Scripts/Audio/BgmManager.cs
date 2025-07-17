using UnityEngine;

namespace Yukiori
{
    public class BgmManager : IBgmPlayer
    {
        private readonly IBgmRepository _bgmRepository;
        private readonly AudioSource _audioSource;

        public BgmManager(IBgmRepository bgmRepository, IAudioSourceFactory audioSourceFactory)
        {
            _bgmRepository = bgmRepository;
            _audioSource = audioSourceFactory.Create();
        }

        public void Play(BgmId bgmId)
        {
            var bgm = _bgmRepository.GetBgmData(bgmId);
            
            _audioSource.clip = bgm.AudioClip;
            _audioSource.volume = bgm.Volume;
            _audioSource.loop = true;
            _audioSource.Play();
        }
    }
}
