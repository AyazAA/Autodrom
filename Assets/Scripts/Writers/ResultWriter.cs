using TMPro;
using UnityEngine;

public class ResultWriter : MonoBehaviour
{
    [SerializeField] private ResultUI _resultUI;
    [SerializeField] private TMP_Text _resultTMP;

    public void WriteResult(string result)
    {
        _resultUI.gameObject.SetActive(true);
        _resultTMP.text = result;
    }
}
