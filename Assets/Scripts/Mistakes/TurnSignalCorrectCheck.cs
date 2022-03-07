using Assets.Scripts.Input;
using UnityEngine;


public class TurnSignalCorrectCheck : MistakeControl
{
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private bool _isLeftTurnSignal;
    private TurnSignalSwitch _turnSignalSwitch;
    private bool _nitralWheel = true;

    private void Awake()
    {
        PenaltyPoints = 3;
        PenaltyMessage = "Перед поворотом руля необходимо включить нужный сигнал поворота";
        _turnSignalSwitch = GetComponent<TurnSignalSwitch>();
    }

    private void Update()
    {
        if ((!_turnSignalSwitch.TurnSignalOn && _nitralWheel) &&
            ((_playerInput.GetHorizontalInput > 0 && !_isLeftTurnSignal) ||
            (_playerInput.GetHorizontalInput < 0 && _isLeftTurnSignal)))
        {
            MistakeOccurredInvoke();
            _nitralWheel = false;
        }
        else if (_playerInput.GetHorizontalInput == 0)
        {
            _nitralWheel = true;
        }
    }
}