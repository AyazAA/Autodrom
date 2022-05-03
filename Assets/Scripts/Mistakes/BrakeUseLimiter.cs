using UnityEngine;
using Assets.Scripts.Input;

public class BrakeUseLimiter : MistakeControl
{
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private float _startZPosition = 6f;
    [SerializeField] private float _endZPosition = 9.85f;
    [SerializeField] private int _brakeCanCount = 1;
    private Transform _target;
    private bool _brakeOn = false;

    private void Awake()
    {
        PenaltyPoints = 5;
        PenaltyMessage = $"Нельзя использовать тормоз больше {_brakeCanCount} раз на этом участке, начните заново";
        _target = _playerInput.transform;
    }

    private void Update()
    {
        BrakeUseCheck();
    }

    private void BrakeUseCheck()
    {
        if (_target.position.z > _startZPosition && _target.position.z < _endZPosition)
        {
            if (_playerInput.GetIsBrake && _brakeCanCount > 0)
            {
                _brakeOn = true;
            }
            else if (_playerInput.GetIsBrake && _brakeCanCount == 0 && !_brakeOn)
            {
                _brakeOn = true;
                MistakeOccurredInvoke();
            }
            else if (!_playerInput.GetIsBrake)
            {
                if (_brakeOn)
                {
                    _brakeCanCount--;
                    _brakeOn = false;
                }
            }
        }
    }
}
