using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TurnSignalSwitch : MonoBehaviour
{
    [SerializeField] private Color _blinkColor = Color.yellow;
    [SerializeField] private float _delayBetweenBlink = 1f;
    private static bool _oneSignalOn = false;
    private Image _buttonBackground;
    private bool _turnSignalOn = false;
    private Color _startColor;
    private AudioSource _turnSignalAudioSource;

    public bool TurnSignalOn => _turnSignalOn;

    private void Awake()
    {
        _buttonBackground = GetComponent<Image>();
        _startColor = _buttonBackground.color;
        _turnSignalAudioSource = GetComponent<AudioSource>();
    }

    public void ChangeTurnSignalStatus()
    {
        _turnSignalOn = _turnSignalOn ? false : true;
        if (_turnSignalOn && !_oneSignalOn)
        {
            StartCoroutine(TurnSignalBlink());
            _turnSignalAudioSource.Play();
            _oneSignalOn = true;
        }
        else if(!_turnSignalOn)
        {
            StopAllCoroutines();
            _turnSignalAudioSource.Stop();
            _buttonBackground.color = _startColor;
            _oneSignalOn = false;
        }
        else if (_turnSignalOn)
        {
            _turnSignalOn = false;
        }
    }

    private IEnumerator TurnSignalBlink()
    {
        while (true)
        {
            yield return new WaitForSeconds(_delayBetweenBlink);
            _buttonBackground.color = _startColor;
            yield return new WaitForSeconds(_delayBetweenBlink);
            _buttonBackground.color = _blinkColor;
        }
    }
}