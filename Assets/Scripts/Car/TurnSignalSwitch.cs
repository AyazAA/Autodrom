using DG.Tweening;
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
    private Sequence _blinkerSequence;

    public bool TurnSignalOn => _turnSignalOn;

    private void Awake()
    {
        _buttonBackground = GetComponent<Image>();
        _startColor = _buttonBackground.color;
        _turnSignalAudioSource = GetComponent<AudioSource>();
    }

    private void OnDestroy()
    {
        _blinkerSequence.Kill();
        DOTween.Clear(true);
    }

    public void ChangeTurnSignalStatus()
    {
        _turnSignalOn = _turnSignalOn ? false : true;
        if (_turnSignalOn && !_oneSignalOn)
        {
            TurnSignalBlink();
            _turnSignalAudioSource.Play();
            _oneSignalOn = true;
        }
        else if (!_turnSignalOn)
        {
            _blinkerSequence.Pause();
            _turnSignalAudioSource.Stop();
            _buttonBackground.color = _startColor;
            _oneSignalOn = false;
        }
        else if (_turnSignalOn)
        {
            _turnSignalOn = false;
        }
    }

    private void TurnSignalBlink()
    {
        if (_blinkerSequence == null)
        {
            _blinkerSequence = DOTween.Sequence();
            _blinkerSequence.AppendCallback(() => { _buttonBackground.color = _blinkColor; });
            _blinkerSequence.AppendInterval(_delayBetweenBlink);
            _blinkerSequence.AppendCallback(() => { _buttonBackground.color = _startColor; });
            _blinkerSequence.AppendInterval(_delayBetweenBlink);
            _blinkerSequence.SetAutoKill(true);
            _blinkerSequence.SetLoops(-1, LoopType.Restart);
        }
        _blinkerSequence.Play();
    }
}