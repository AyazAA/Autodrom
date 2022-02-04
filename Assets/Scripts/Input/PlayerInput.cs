using UnityEngine;

namespace Assets.Scripts.Input
{
    public abstract class PlayerInput : MonoBehaviour
    {
        protected float HorizontalInput;
        protected float VerticalInput;

        public float GetHorizontalInput => HorizontalInput;
        public float GetVerticalInput => VerticalInput;

        private void Update()
        {
            SetRotatingInput();
            SetMovingInput();
        }

        protected abstract void SetMovingInput();

        protected abstract void SetRotatingInput();
    }
}
