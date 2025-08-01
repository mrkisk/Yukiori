using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Yukiori
{
    public class SystemLifetimeScope : LifetimeScope
    {
        [SerializeField] private SceneManagementInstaller _sceneManagementInstaller;
        [SerializeField] private AudioInstaller _audioInstaller;

        protected override void Configure(IContainerBuilder builder)
        {
            _sceneManagementInstaller.Configure(builder);
            _audioInstaller.Configure(builder);
            
            builder.RegisterEntryPoint<SystemEntryPoint>();
        }
    }
}
