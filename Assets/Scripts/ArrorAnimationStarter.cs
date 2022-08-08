using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class ArrorAnimationStarter : MonoBehaviour
{
    [SerializeField] private float _changedScale = 0.7f;
    [SerializeField] private float _delay = 0.2f;
    private Vector2 _startSize;
    private RectTransform _rectTransform;
    private Sequence _animationSequence;

    private void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
        _startSize = _rectTransform.sizeDelta;
    }

    private void OnDestroy()
    {
        _animationSequence.Kill();
    }

    public void PlayAnimation()
    {
        if(_animationSequence == null)
        {
            _animationSequence = DOTween.Sequence();
            _animationSequence.AppendCallback(() => { _rectTransform.sizeDelta = new Vector2(_startSize.x * _changedScale, _startSize.y * _changedScale); print("Start"); });
            _animationSequence.AppendInterval(_delay);
            _animationSequence.AppendCallback(() => { _rectTransform.sizeDelta = _startSize; print("End"); });
            _animationSequence.SetAutoKill(false);
        }
        _animationSequence.Restart();
    }
}
