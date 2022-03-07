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
        PenaltyMessage = "Нельзя больше двух раз переключаться на заднюю передачу";
    }

    private void Update()
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