using Assets.Scripts.Input;
using UnityEngine;

public class CarMover : MonoBehaviour
{
    [SerializeField] private WheelCollider[] _wheelCollidersFront;
    [SerializeField] private WheelCollider[] _wheelCollidersBack;
    [SerializeField] private Transform _centerOfMass;
    [SerializeField] private float _maxSteer = 30;
    [SerializeField] private float _maxAccel = 500;
    [SerializeField] private float _maxBrake = 500;
    private PlayerInput _playerInput;

    private void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
        GetComponent<Rigidbody>().centerOfMass = _centerOfMass.position;
    }

    private void Update()
    {
        Move(_playerInput.GetVerticalInput, _playerInput.GetHorizontalInput, _playerInput.GetIsBrake);
    }

    private void Move(float accel, float steer, bool isBrakePressed)
    {
        foreach (var wheel in _wheelCollidersFront)
        {
            wheel.steerAngle = steer * _maxSteer;
        }

        if (isBrakePressed)
        {
            foreach (var wheel in _wheelCollidersFront)
            {
                wheel.brakeTorque = _maxBrake;
            }
        }
        else
        {
            foreach (var wheel in _wheelCollidersFront)
            {
                wheel.brakeTorque = 0;
                wheel.motorTorque = _maxAccel * accel;
            }
        }
    }
}
