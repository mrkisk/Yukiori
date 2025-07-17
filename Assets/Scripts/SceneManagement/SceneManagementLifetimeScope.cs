using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Yukiori
{
    public class SceneManagementLifetimeScope : LifetimeScope
    {
        [SerializeField] private SceneDatabase _sceneDatabase;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<ISceneRepository, SceneRepository>(Lifetime.Scoped);
            builder.Register<ISceneLoader, SceneManager>(Lifetime.Scoped);
            builder.RegisterComponent(_sceneDatabase);
        }
    }
}
