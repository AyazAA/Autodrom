using System.Collections.Generic;
using UnityEngine;

public class PenaltyInfo: MonoBehaviour
{
    [SerializeField] private List<MistakeControl> _mistakeControls;
    [SerializeField] private ResultWriter _resultWriter;
    private int _penaltyPoints = 0;
    private int _maxPenaltyPoints = 4;  

    public int PenaltyPoints => _penaltyPoints;
    public int MaxPenaltyPoints => _maxPenaltyPoints;
    
    private void Awake()
    {
        foreach (var mistakeControl in _mistakeControls)
        {
            mistakeControl.MistakeOccurredEvent += CarGetPenaltyInfo;
        }
    }

    private void OnDestroy()
    {
        foreach (var mistakeControl in _mistakeControls)
        {
            mistakeControl.MistakeOccurredEvent -= CarGetPenaltyInfo;
        }
    }

    private void CarGetPenaltyInfo(int penaltyPoints, string mistakeMessage)
    {
        _penaltyPoints += penaltyPoints;
        if (_penaltyPoints <= _maxPenaltyPoints)
        {
            _resultWriter.WriteAllowableMistake(mistakeMessage);
        }
        _resultWriter.WriteResult(mistakeMessage);
    }
}
