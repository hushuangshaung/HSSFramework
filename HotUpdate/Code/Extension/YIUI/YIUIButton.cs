using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace YIUIFramework
{
    public enum EButtonType
    {
        Click,
        LongPress,
    }

    public enum EButtonSound
    {
        ButtonSound1,
        ButtonSound2,
        ButtonSound3,
        ButtonSound4,
        ButtonSound5,
        ButtonSound6,
        ButtonSound7,
        ButtonSound8,
        ButtonSound9,
        ButtonSound10,
    }

    public class YIUIButton: Selectable, IPointerClickHandler, ISubmitHandler
    {
        [Serializable]
        /// <summary>
        /// Function definition for a button click event.
        /// </summary>
        public class ButtonClickedEvent : UnityEvent {}
        
        // Event delegates triggered on click.
        [FormerlySerializedAs("onClick")]
        [SerializeField]
        private ButtonClickedEvent m_OnClick = new ButtonClickedEvent();

        public EButtonType ButtonType = EButtonType.Click;
        public EButtonSound ButtonSound = EButtonSound.ButtonSound1;
        public bool ClickEffect = true;

        private bool _isInitClickEffect;
        protected YIUIButton()
        {
           
        }
        
        public ButtonClickedEvent onClick
        {
            get { return m_OnClick; }
            set { m_OnClick = value; }
        }

        protected override void Awake()
        {
            AddClickEffect();
            base.Awake();
        }

        private void AddClickEffect()
        {
            if (Application.isEditor)
            {
                return;
            }

            if (_isInitClickEffect)
            {
                return;
            }

            _isInitClickEffect = true;
            if (!ClickEffect)
            {
                return;
            }
            
            var clickEffect= GetComponent<YIUIClickEffect>();
            if (!clickEffect)
            {
                gameObject.AddComponent<YIUIClickEffect>();
            }
        }

        private void Press()
        {
            if (!IsActive() || !IsInteractable())
                return;

            UISystemProfilerApi.AddMarker("Button.onClick", this);
            Debug.LogError("播放点击音效");
            m_OnClick.Invoke();
        }
        
        public void OnPointerClick(PointerEventData eventData)
        {
            if (eventData.button != PointerEventData.InputButton.Left)
                return;

            Press();
        }

        public void OnSubmit(BaseEventData eventData)
        {
            Press();

            // if we get set disabled during the press
            // don't run the coroutine.
            if (!IsActive() || !IsInteractable())
                return;

            DoStateTransition(SelectionState.Pressed, false);
            StartCoroutine(OnFinishSubmit());
        }
        
        private IEnumerator OnFinishSubmit()
        {
            var fadeTime = colors.fadeDuration;
            var elapsedTime = 0f;

            while (elapsedTime < fadeTime)
            {
                elapsedTime += Time.unscaledDeltaTime;
                yield return null;
            }

            DoStateTransition(currentSelectionState, false);
        }
    }
}