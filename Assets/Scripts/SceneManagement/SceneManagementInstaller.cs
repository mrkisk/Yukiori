using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Yukiori
{
    public class SceneManagementInstaller : MonoBehaviour, IInstaller
    {
        public void Install(IContainerBuilder builder)
        {
            builder.Register<SceneRepository>(Lifetime.Scoped);
            builder.Register<ISceneLoader, SceneManager>(Lifetime.Singleton);
        }
    }
}
