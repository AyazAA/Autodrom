using TMPro;
using UnityEngine;

public class ResultWriter : MonoBehaviour
{
    [SerializeField] private ResultUI _resultUI;
    [SerializeField] private TMP_Text _resultTMP;

    public void WriteResult(string result)
    {
        _resultUI.Show();
        _resultTMP.text = result;
    }
}
