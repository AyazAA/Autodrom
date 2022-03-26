using TMPro;
using UnityEngine;

public class ResultWriter : MonoBehaviour
{
    [SerializeField] private GameObject _resultUI;
    [SerializeField] private TMP_Text _resultTMP;

    public void WriteResult(string result)
    {
        _resultUI.SetActive(true);
        _resultTMP.text = result;
    }
}
