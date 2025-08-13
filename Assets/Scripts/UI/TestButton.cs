using UnityEngine;
using VContainer;

namespace Yukiori
{
    [RequireComponent(typeof(ButtonStateController))]
    public class TestButton : MonoBehaviour
    {
        [SerializeField] private ButtonStateController _buttonStateController;

        private ButtonSe _buttonSe;

        [Inject]
        public void Construct(ISeManager seManager)
        {
            _buttonSe = new ButtonSe(seManager);

            _buttonStateController.OnStateChanged += OnButtonStateChanged;
            _buttonStateController.OnClicked += OnClicked;
        }

        private void OnClicked()
        {
            Debug.Log("Button clicked!");
            _buttonSe.Play();
        }

        private void OnButtonStateChanged(ButtonStateController.StateType state)
        {
            Debug.Log($"Button state changed to: {state}");
        }
    }
}
