namespace Assets.Scripts.Input
{
    public class KeyboardPlayerInput : PlayerInput
    {
        protected override void SetMovingInput()
        {
            VerticalInput = UnityEngine.Input.GetAxis("Vertical");
        }

        protected override void SetRotatingInput()
        {
            HorizontalInput = UnityEngine.Input.GetAxis("Horizontal");
        }
    }
}
