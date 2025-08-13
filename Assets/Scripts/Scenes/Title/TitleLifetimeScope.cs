using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Yukiori.Scenes.Title
{
    public class TitleLifetimeScope : LifetimeScope
    {
        [SerializeField] private TestButton _testButton;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterComponent(_testButton);
        }
    }
}
