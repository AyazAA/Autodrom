using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerSettings : MonoBehaviour
    {
        private Input.PlayerInput _playerInput;

        public Input.PlayerInput PlayerInput => _playerInput;
        
        private void Awake()
        {
            SetInitialSettings();
        }

        private void SetInitialSettings()
        {
            _playerInput = gameObject.GetComponent<Input.PlayerInput>();
        }
    }
}
