using UnityEngine;
using UnityEngine.UI;
using VContainer;

namespace Yukiori
{
    public class ButtonSe
    {
        private readonly ISeManager _seManager;

        private SeId _seId = SeId.UI_BUTTON_CLICK;

        [Inject]
        public ButtonSe(ISeManager seManager)
        {
            _seManager = seManager;
        }

        public void SetSeId(SeId seId)
        {
            _seId = seId;
        }

        public void Play()
        {
            _seManager.Play(_seId);
        }
    }

}