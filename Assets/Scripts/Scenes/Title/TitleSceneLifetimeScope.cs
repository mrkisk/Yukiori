using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Yukiori
{
    public class TitleSceneLifetimeScope : LifetimeScope
    {
        [SerializeField] private SoundButton _soundButton;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterComponent(_soundButton);
        }
    }
}
    