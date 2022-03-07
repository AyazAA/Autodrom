using System.Collections;
using TMPro;
using UnityEngine;

public class TurnSignalSwitch : MonoBehaviour
{
    [SerializeField] private TMP_Text _signalTMP;
    private bool _turnSignalOn = false;
    private string _text;

    public bool TurnSignalOn => _turnSignalOn;

    private void Awake()
    {
        _text = _signalTMP.text;
    }

    public void ChangeTurnSignalStatus()
    {
        _turnSignalOn = _turnSignalOn ? false : true;
        if (_turnSignalOn)
        {
            StartCoroutine(TurnSignalBlink());
        }
        else
        {
            StopAllCoroutines();
            _signalTMP.text = _text;
        }
    }

    private IEnumerator TurnSignalBlink()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            _signalTMP.text = "";
            yield return new WaitForSeconds(1f);
            _signalTMP.text = _text;
        }
    }
}