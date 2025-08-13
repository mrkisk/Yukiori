using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Yukiori
{
    public class AudioInstaller : MonoBehaviour, IInstaller
    {
        [SerializeField] private BgmDatabase _bgmDatabase;
        [SerializeField] private SeDatabase _seDatabase;

        public void Install(IContainerBuilder builder)
        {
            builder.Register<IBgmRepository, ISeRepository, AudioRepository>(Lifetime.Scoped);
            builder.Register<IAudioSourceFactory, AudioSourceFactory>(Lifetime.Scoped);

            builder.Register<IAudioManager, AudioManager>(Lifetime.Singleton);
            builder.Register<IBgmManager, BgmManager>(Lifetime.Singleton);
            builder.Register<ISeManager, SeManager>(Lifetime.Singleton);

            builder.RegisterComponent(_bgmDatabase);
            builder.RegisterComponent(_seDatabase);

            builder.RegisterEntryPoint<AudioEntryPoint>(Lifetime.Scoped);
        }
    }
}
