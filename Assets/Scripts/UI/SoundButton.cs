using UnityEngine;
using UnityEngine.UI;
using VContainer;

namespace Yukiori
{
    public class SoundButton : MonoBehaviour
    {
        [SerializeField] private Button _button;
        
        private ISePlayer _sePlayer;

        [Inject]
        public void Construct(ISePlayer sePlayer)
        {
            _sePlayer = sePlayer;
        }

        private void Start()
        {
            _button.onClick.AddListener(OnButtonClick);
        }

        private void OnButtonClick()
        {
            _sePlayer.Play(SeId.UI_BUTTON_CLICK);
        }
    }

}