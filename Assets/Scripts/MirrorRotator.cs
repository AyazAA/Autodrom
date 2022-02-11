using UnityEngine;

public class MirrorRotator : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed = 1f;
    [SerializeField] private float _minXAngle = -22f;
    [SerializeField] private float _maxXAngle = 2f;
    [SerializeField] private float _minYAngle = 20f;
    [SerializeField] private float _maxYAngle = 33f;
    private Vector3 _localAngles;


    private void Start()
    {
        _localAngles = transform.localEulerAngles;
    }

    public void RotateHorizontIncrease()
    {
        _localAngles.y = Mathf.Clamp(_localAngles.y + _rotateSpeed, _minYAngle, _maxYAngle);
        Rotate();
    }


    public void RotateHorizontDecrease()
    {
        _localAngles.y = Mathf.Clamp(_localAngles.y - _rotateSpeed, _minYAngle, _maxYAngle);
        Rotate();
    }

    public void RotateVerticalIncrease()
    {
        _localAngles.x = Mathf.Clamp(_localAngles.x + _rotateSpeed, _minXAngle, _maxXAngle);
        Rotate();
    }

    public void RotateVerticalDecrease()
    {
        _localAngles.x = Mathf.Clamp(_localAngles.x - _rotateSpeed, _minXAngle, _maxXAngle);
        Rotate();
    }
    
    private void Rotate()
    {
        transform.localEulerAngles = _localAngles;
    }
}
