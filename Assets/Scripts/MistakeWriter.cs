using System.Collections;
using TMPro;
using UnityEngine;

public class MistakeWriter : MonoBehaviour 
{
    [SerializeField] private float _delayDisappear = 4f;
    [SerializeField] private GameObject _mistakeUI;
    [SerializeField] private TMP_Text _mistakeTMP;

    public void WriteAllowableMistake(string mistake)
    {
        _mistakeUI.SetActive(true);
        _mistakeTMP.text = mistake;
        StartCoroutine(StopErrorMessage());
    }

    private IEnumerator StopErrorMessage()
    {
        yield return new WaitForSeconds(_delayDisappear);
        _mistakeTMP.text = "";
        _mistakeUI.SetActive(false);
    }
}   