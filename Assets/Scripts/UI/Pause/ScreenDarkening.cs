using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScreenDarkening: MonoBehaviour
{
    [SerializeField] private Image _pauseBackground;
    [SerializeField] private float _alphaTime = 1f;
    [SerializeField] private float _alphaMax = 0.8f;

    public void Darken()
    {
        StartCoroutine(FadeTo(_alphaMax, _alphaTime));
    }

    public void Undarken()
    {
        StartCoroutine(FadeTo(0f, _alphaTime));
    }

    private IEnumerator FadeTo(float aValue, float aTime)
    {
        float alpha = _pauseBackground.color.a;
        Color startColor = _pauseBackground.color;
        for (float t = 0.0f; t < 1.0f; t += Time.unscaledDeltaTime / aTime)
        {
            Color newColor = new Color(startColor.r, startColor.g, startColor.b, Mathf.Lerp(alpha, aValue, t));
            _pauseBackground.color = newColor;
            yield return null;
        }
    }
}
