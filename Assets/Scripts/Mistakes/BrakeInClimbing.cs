using UnityEngine;
using Assets.Scripts.Input;

public class BrakeInClimbing : MistakeControl
{
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private Transform _target;
    [SerializeField] private float _startZPosition = 6f;
    [SerializeField] private float _endZPosition = 9.85f;
    private bool _brakeWasOn = false;

    private void Awake()
    {
        PenaltyPoints = 5;
        PenaltyMessage = "Не остановились на горке, начните заново";
    }

    private void Update()
    {
        if (_target.position.z > _startZPosition && _target.position.z < _endZPosition)
        {
            if (_playerInput.GetIsBrake)
            {
                _brakeWasOn = true;
            }
        }
        else if (_target.position.z > _endZPosition)
        {
            if (!_brakeWasOn)
            {
                _brakeWasOn = true;
                MistakeOccurredInvoke();
            }
        }
    }
}
