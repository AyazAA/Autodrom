using Assets.Scripts.Input;
using UnityEngine;

namespace Assets.Scripts
{
    public class SteerRotator : MonoBehaviour
    {
        [SerializeField] private PlayerInput _playerInput;
        [Tooltip("degrees per second")]
        [SerializeField] private float _rotateBackSpeed = 500f;
        [Tooltip("degrees per second")]
        [SerializeField] private float _rotateSpeed = 350f;
        [Tooltip("degrees")]
        [SerializeField] private float _angle = 0f;
        [Tooltip("degrees")]
        [SerializeField] private float _minAngle = -160f;
        [Tooltip("degrees")]
        [SerializeField] private float _maxAngle = 160f;
        private float _neutralAngle = 0f;

        private void Update()
        {
            _angle = Mathf.Clamp(_angle + _playerInput.GetHorizontalInput * _rotateSpeed * Time.deltaTime, _minAngle, _maxAngle);

            if (Mathf.Approximately(0f, _playerInput.GetHorizontalInput))
            {
                _angle = Mathf.MoveTowardsAngle(_angle, _neutralAngle, _rotateBackSpeed * Time.deltaTime);
            }

            transform.localEulerAngles = _angle * Vector3.back;
        }
    }
}
