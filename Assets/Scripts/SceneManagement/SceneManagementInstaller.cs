using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Yukiori
{
    public class SceneManagementInstaller : MonoBehaviour
    {
        [SerializeField] private SceneDatabase _sceneDatabase;

        public void Configure(IContainerBuilder builder)
        {
            builder.Register<ISceneRepository, SceneRepository>(Lifetime.Scoped);
            builder.Register<ISceneLoader, SceneManager>(Lifetime.Singleton);
            builder.RegisterComponent(_sceneDatabase);
        }
    }
}
