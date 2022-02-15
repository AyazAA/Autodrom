using UnityEngine;

namespace Assets.Scripts.Input
{
    public abstract class PlayerInput : MonoBehaviour
    {
        protected float HorizontalInput;
        protected float VerticalInput;
        protected bool IsBrakeInput;

        public float GetHorizontalInput => HorizontalInput;
        public float GetVerticalInput => VerticalInput;
        public bool GetIsBrake => IsBrakeInput;

        private void Update()
        {
            SetRotatingInput();
            SetMovingInput();
            SetBrakingInput();
        }

        protected abstract void SetMovingInput();

        protected abstract void SetRotatingInput();

        protected abstract void SetBrakingInput();
    }
}
