using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Yukiori
{
    public class RootLifetimeScope : LifetimeScope
    {
        [SerializeField] private SceneManagementInstaller _sceneManagementInstaller;
        [SerializeField] private AudioInstaller _audioInstaller;

        protected override void Configure(IContainerBuilder builder)
        {
            _sceneManagementInstaller.Install(builder);
            _audioInstaller.Install(builder);
        }
    }
}
