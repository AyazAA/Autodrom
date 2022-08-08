using UnityEngine;

public class CarCollisions : MistakeControl
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent<ICarDamageable>(out var _carDamageable))
        {
            PenaltyPoints = _carDamageable.GetPenaltyPoints();
            PenaltyMessage = _carDamageable.GetMistakeMessage();
            MistakeOccurringInvoke();
        }
    }
}
