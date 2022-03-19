using UnityEngine;

public class ObjectWasTurned : MistakeControl
{
    private BoxCollider _areaCollider;
    private bool _droveInto;

    private void Awake()
    {
        PenaltyPoints = 5;
        PenaltyMessage = "Вы не развернули машину";
        _areaCollider = GetComponent<BoxCollider>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (_areaCollider.bounds.Contains(other.bounds.min) && _areaCollider.bounds.Contains(other.bounds.max) && !_droveInto)
        {
            _droveInto = true;
            if (!(other.transform.eulerAngles.y > 160f && other.transform.eulerAngles.y < 200f))
            {
                MistakeOccurredInvoke();
            }
        }
    }
}