using UnityEngine;
using Assets.Scripts.Input;

public class RollbackControl : MistakeControl
{
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private float _startZPosition = 6f;
    [SerializeField] private float _endZPosition = 9.85f;
    [SerializeField] private float _allowedRollbackDistance = 2f;
    private Transform _target;
    private bool _brakeOn = false;
    private bool _rollbackWas = false;
    private Vector3 _brakePosition = Vector3.zero;

    private void Awake()
    {
        PenaltyPoints = 5;
        PenaltyMessage = $"Допущен большой откат ТС на подъёме, начните заново";
        _target = _playerInput.transform;
    }

    private void Update()
    {
        RollbackCheck();
    }

    private void RollbackCheck()
    {
        if (_target.position.z > _startZPosition && _target.position.z < _endZPosition)
        {
            if (_playerInput.GetIsBrake && !_brakeOn && _brakePosition == Vector3.zero)
            {
                _brakeOn = true;
                _brakePosition = _target.position;
            }
            else if (!_playerInput.GetIsBrake)
            {
                _brakeOn = false;
            }
        }
        if (!_rollbackWas && _brakePosition != Vector3.zero)
        {
            if ((_brakePosition.z - _target.position.z) > _allowedRollbackDistance)
            {
                _rollbackWas = true;
                MistakeOccurringInvoke();
            }
        }
    }
}