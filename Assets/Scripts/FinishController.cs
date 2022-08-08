using UnityEngine;

[RequireComponent(typeof(PenaltyInfo), typeof(BoxCollider))]
public class FinishController : MonoBehaviour
{
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
            if (_penaltyInfo.PenaltyPoints <= _penaltyInfo.MaxPenaltyPoints)
            {
                _resultWriter.WriteResult($"”пражнение успешно сдано с {_penaltyInfo.PenaltyPoints} штрафными баллами");
            }
            else
            {
                _resultWriter.WriteResult($"”пражнение не сдано с {_penaltyInfo.PenaltyPoints} штрафными баллами");
            }
            Time.timeScale = 0f;
        }
    }
}
