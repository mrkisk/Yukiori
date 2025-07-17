using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Yukiori
{
    public class AudioLifetimeScope : LifetimeScope
    {
        [SerializeField] private GameObject _audioSourceFactoryHost;
        [SerializeField] private BgmDatabase _bgmDatabase;
        [SerializeField] private SeDatabase _seDatabase;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<IBgmRepository, ISeRepository, AudioRepository>(Lifetime.Scoped);
            builder.Register<IAudioSourceFactory, AudioSourceFactory>(Lifetime.Scoped);

            // builder.Register<IAudioEnableControl, AudioManager>(Lifetime.Scoped);
            // builder.Register<IBgmPlayer, BgmManager>(Lifetime.Scoped);
            // builder.Register<ISePlayer, SeManager>(Lifetime.Scoped);

            builder.RegisterComponent(_bgmDatabase);
            builder.RegisterComponent(_seDatabase);
            builder.RegisterComponent(_audioSourceFactoryHost);
        }
    }
}
