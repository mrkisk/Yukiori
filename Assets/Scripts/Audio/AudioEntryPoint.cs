using VContainer;
using VContainer.Unity;

namespace Yukiori
{
    public class AudioEntryPoint : IStartable
    {
        private readonly IBgmManager _bgmManager;
        
        [Inject]
        public AudioEntryPoint(IBgmManager bgmManager)
        {
            _bgmManager = bgmManager;
        }
        
        public void Start()
        {
            _bgmManager.Play(BgmId.DEFAULT);
        }
    }
}