using System;
using UnityEngine;

public abstract class MistakeControl: MonoBehaviour
{
    public event Action<int, string> MistakeOccurring;
    protected int PenaltyPoints = 0;
    protected string PenaltyMessage = "";

    protected void MistakeOccurringInvoke()
    {
        MistakeOccurring?.Invoke(PenaltyPoints, PenaltyMessage);
    }
}