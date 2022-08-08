using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class ObjectInsideArea : MistakeControl
{
    private BoxCollider _areaCollider;
    private bool _droveInto;

    public bool DroveInto => _droveInto;

    private void Awake()
    {
        PenaltyPoints = 5;
        PenaltyMessage = "";
        _areaCollider = GetComponent<BoxCollider>();
    }

    private void Start()
    {
        MistakeOccurringInvoke();
    }

    private void OnTriggerStay(Collider other)
    {
        if (_areaCollider.bounds.Contains(other.bounds.min) &&
            _areaCollider.bounds.Contains(other.bounds.max) &&
            !_droveInto &&
            other.TryGetComponent<CarCollider>(out var carCollider))
        {
            _droveInto = true;
            PenaltyPoints = -5;
            MistakeOccurringInvoke();
        }
    }
}
