using Assets.Scripts.Input;
using UnityEngine;

public class ReverseGearLimiter : MistakeControl
{
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private int _reverseCanCount = 2;
    private bool _reverseGear = false;

    private void Awake()
    {
        PenaltyPoints = 5;
        PenaltyMessage = $"Нельзя больше {_reverseCanCount} раз переключаться на заднюю передачу, начните заново";
    }

    private void Update()
    {
        ReverseGearCheck();
    }

    private void ReverseGearCheck()
    {
        if (_playerInput.GetVerticalInput < 0 && _reverseCanCount > 0)
        {
            _reverseGear = true;
        }
        else if (_playerInput.GetVerticalInput < 0 && _reverseCanCount == 0 && !_reverseGear)
        {
            _reverseGear = true;
            MistakeOccurredInvoke();
        }
        else if (_playerInput.GetVerticalInput > 0)
        {
            if (_reverseGear)
            {
                _reverseCanCount--;
                _reverseGear = false;
            }
        }
    }
}