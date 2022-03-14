using UnityEngine;

public class FinishCheck : MonoBehaviour
{
    [SerializeField] private ObjectInsideArea _carInsideGarage;
    [SerializeField] private ResultWriter _resultWriter;
    private BoxCollider _finishCollider;
    private PenaltyInfo _penaltyInfo;

    private void Awake()
    {
        _penaltyInfo = GetComponent<PenaltyInfo>();
        _finishCollider = GetComponent<BoxCollider>();
    }


    private void OnTriggerStay(Collider other)
    {
        if (_finishCollider.bounds.Contains(other.bounds.min) && _finishCollider.bounds.Contains(other.bounds.max))
        {
            if (_carInsideGarage.DroveInto && _penaltyInfo.PenaltyPoints <= _penaltyInfo.MaxPenaltyPoints)
            {
                _resultWriter.WriteResult($"��������� ������� ����� � {_penaltyInfo.PenaltyPoints} ��������� �������");
            }
            else
            {
                _resultWriter.WriteResult($"��������� �� ����� � {_penaltyInfo.PenaltyPoints} ��������� �������");
            }
            Time.timeScale = 0f;
        }
    }
}
