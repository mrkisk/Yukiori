using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Yukiori
{
    public class AudioInstaller : MonoBehaviour
    {
        [SerializeField] private GameObject _audioSourceFactoryHost;
        [SerializeField] private BgmDatabase _bgmDatabase;
        [SerializeField] private SeDatabase _seDatabase;

        public void Configure(IContainerBuilder builder)
        {
            builder.Register<IBgmRepository, ISeRepository, AudioRepository>(Lifetime.Scoped);
            builder.Register<IAudioSourceFactory, AudioSourceFactory>(Lifetime.Scoped);

            builder.Register<IAudioEnableControl, AudioManager>(Lifetime.Singleton);
            builder.Register<IBgmPlayer, BgmManager>(Lifetime.Singleton);
            builder.Register<ISePlayer, SeManager>(Lifetime.Singleton);

            builder.RegisterComponent(_bgmDatabase);
            builder.RegisterComponent(_seDatabase);
            builder.RegisterComponent(_audioSourceFactoryHost);
        }
    }
}
