using UnityEngine;

public class ObjectCollisionArea : MistakeControl
{
    private void Awake()
    {
        PenaltyPoints = 5;
        PenaltyMessage = "Задели границу упражнения, начните заново";
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent<CarMover>(out var carMover))
        {
            MistakeOccurringInvoke();
        }
    }
}