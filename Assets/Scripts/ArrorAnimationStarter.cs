using System.Collections;
using UnityEngine;

public class ArrorAnimationStarter : MonoBehaviour
{
    [SerializeField] private float _changedScale = 0.7f;
    [SerializeField] private float _delay = 2f;
    private Vector2 _startSize;
    private RectTransform _rectTransform;


    private void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
        _startSize = _rectTransform.sizeDelta;
    }

    public void PlayAnimation()
    {
        StartCoroutine(AnimationCoroutine());
    }

    private IEnumerator AnimationCoroutine()
    {
        _rectTransform.sizeDelta = new Vector2(_startSize.x * _changedScale, _startSize.y * _changedScale);
        yield return new WaitForSeconds(_delay);
        _rectTransform.sizeDelta = _startSize;
    }
}
