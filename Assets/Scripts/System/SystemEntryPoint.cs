using VContainer.Unity;

namespace Yukiori
{
    public class SystemEntryPoint : IStartable
    {
        public void Start()
        {
#if UNITY_EDITOR
            PlayModeBootstrapper.LoadInitialScene();
#else
            // PlayModeBootstrapper.LoadInitialScene();
#endif
        }
    }
}