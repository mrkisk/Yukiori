using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Yukiori
{
    public class ButtonStateController : MonoBehaviour, IPointerUpHandler, IPointerDownHandler, IPointerClickHandler
    {
        public enum StateType
        {
            UP,
            DOWN,
            DISABLED
        }

        private StateType _currentState = StateType.UP;
        private Action<StateType> _onStateChanged;
        private Action _onClicked;
        
        public event Action<StateType> OnStateChanged
        {
            add => _onStateChanged += value;
            remove => _onStateChanged -= value;
        }
        public event Action OnClicked
        {
            add => _onClicked += value;
            remove => _onClicked -= value;
        }
        
        private void SetState(StateType newState)
        {
            if (_currentState != newState)
            {
                _currentState = newState;
                _onStateChanged?.Invoke(_currentState);
            }
        }

        public void SetDisabled(bool isDisabled)
        {
            if (isDisabled)
            {
                SetState(StateType.DISABLED);
            }
            else
            {
                SetState(StateType.UP);
            }
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            if (_currentState == StateType.DOWN)
            {
                SetState(StateType.UP);
            }
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            if (_currentState == StateType.UP)
            {
                SetState(StateType.DOWN);
            }
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            if (_currentState != StateType.DISABLED)
            {
                _onClicked?.Invoke();
            }
        }
    }
}
