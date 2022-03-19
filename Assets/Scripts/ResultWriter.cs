using System.Collections;
using TMPro;
using UnityEngine;

public class ResultWriter : MonoBehaviour
{
    [SerializeField] private float _delayDisappear = 4f;
    private TMP_Text _resultTMP;

    private void Awake()
    {
        _resultTMP = GetComponent<TMP_Text>();
    }

    public void WriteResult(string result)
    {
        _resultTMP.text = result;
    }

    public void WriteAllowableMistake(string mistake)
    {
        WriteResult(mistake);
        StartCoroutine(StopErrorMessage());
    }

    private IEnumerator StopErrorMessage()
    {
        yield return new WaitForSeconds(_delayDisappear);
        _resultTMP.text = "";
    }
}