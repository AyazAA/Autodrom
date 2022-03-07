using System;
using UnityEngine;

public abstract class MistakeControl: MonoBehaviour
{
    public event Action<int, string> MistakeOccurredEvent;
    protected int PenaltyPoints = 0;
    protected string PenaltyMessage = "";

    protected void MistakeOccurredInvoke()
    {
        MistakeOccurredEvent?.Invoke(PenaltyPoints, PenaltyMessage);
    }
}