using VContainer.Unity;

namespace Yukiori
{
    public class SystemEntryPoint : IStartable
    {
        private readonly ISceneLoader _sceneLoader;
        private readonly IBgmPlayer _bgmPlayer;
        
        public SystemEntryPoint(ISceneLoader sceneLoader, IBgmPlayer bgmPlayer)
        {
            _sceneLoader = sceneLoader;
            _bgmPlayer = bgmPlayer;
        }
        
        public void Start()
        {
#if UNITY_EDITOR
            PlayModeBootstrapper.LoadInitialScene();
#else
            _sceneLoader.LoadInitialScene();
#endif
            _bgmPlayer.Play(BgmId.DEFAULT);
        }
    }
}