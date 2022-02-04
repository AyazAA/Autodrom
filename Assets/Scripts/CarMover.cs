using Assets.Scripts;
using System;
using UnityEngine;

public class CarMover : MonoBehaviour
{
    [SerializeField] private PlayerSettings _playerSettings;
    [SerializeField] private WheelCollider[] _wheelCollidersFront;
    [SerializeField] private WheelCollider[] _wheelCollidersBack;
    [SerializeField] private Transform _centerOfMass;
    [SerializeField] private float _maxSteer = 30;
    [SerializeField] private float _maxAccel = 500;
    [SerializeField] private float _maxBrake = 50;

    private void Start()
    {
        GetComponent<Rigidbody>().centerOfMass = _centerOfMass.position;
    }

    private void Update()
    {
        Move(_playerSettings.PlayerInput.GetVerticalInput, _playerSettings.PlayerInput.GetHorizontalInput);
    }

    private void Move(float accel, float steer)
    {
        foreach (var wheel in _wheelCollidersFront)
        {
            wheel.steerAngle = steer * _maxSteer;
        }
        if (accel == 0)
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
