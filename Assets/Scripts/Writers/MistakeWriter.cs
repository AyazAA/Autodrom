using DG.Tweening;
using TMPro;
using UnityEngine;

public class MistakeWriter : MonoBehaviour
{
    [SerializeField] private float _delayDisappear = 4f;
    [SerializeField] private Mistake _mistakeUI;
    [SerializeField] private TMP_Text _mistakeTMP;
    private Sequence _hideMessageSequence;

    private void OnDestroy()
    {
        _hideMessageSequence.Kill();
    }

    public void WriteAllowableMistake(string mistake)
    {
        _mistakeUI.Show();
        _mistakeTMP.text = mistake;
        StopErrorMessage();
    }

    private void StopErrorMessage()
    {
        if (_hideMessageSequence == null)
        {
            _hideMessageSequence = DOTween.Sequence();
            _hideMessageSequence.AppendInterval(_delayDisappear);
            _hideMessageSequence.AppendCallback(() => { _mistakeUI.Hide(); });
            _hideMessageSequence.SetAutoKill(false);
        }
        _hideMessageSequence.Restart();
    }
}