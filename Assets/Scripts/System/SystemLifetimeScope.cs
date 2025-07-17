using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Yukiori
{
    public class SystemLifetimeScope : LifetimeScope
    {
        [SerializeField] private SceneManagementLifetimeScope _sceneManagementLifetimeScope;
        [SerializeField] private AudioLifetimeScope _audioLifetimeScope;

        protected override void Configure(IContainerBuilder builder)
        {
            _sceneManagementLifetimeScope.Build();
            _audioLifetimeScope.Build();
            
            builder.RegisterEntryPoint<SystemEntryPoint>();
        }
    }
}
