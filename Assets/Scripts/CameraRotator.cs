using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    [Range(0f,1f)]
    [SerializeField] private float _maxAngle = 1f;
    private Quaternion _startRotation;

    private void Start()
    {
        _startRotation = transform.rotation;
    }

    private void Update()
    {
        CameraRotate();
    }

    private void CameraRotate()
    {
        if (Input.GetKey(KeyCode.End))
        {
            transform.localRotation = new Quaternion(_startRotation.x, _maxAngle, _startRotation.z, _startRotation.w);
        }
        else if (Input.GetKey(KeyCode.PageDown))
        {
            transform.localRotation = new Quaternion(_startRotation.x, -_maxAngle, _startRotation.z, _startRotation.w);
        }
        else
        {
            transform.localRotation = _startRotation;
        }
    }
}