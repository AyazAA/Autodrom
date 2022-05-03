using Assets.Scripts;
using System;
using UnityEngine;
using UnityEngine.UI;

public class SensitivityOnSceneChange : MonoBehaviour
{
    public event Action<float> OnSensitivityChanged;
    private Slider _sensitivitySlider;

    private void Awake()
    {
        _sensitivitySlider = GetComponent<Slider>();
    }

    public void ChangeOnSceneStatus()
    {
        float sensitivity = 700 * _sensitivitySlider.value + 100;
        OnSensitivityChanged?.Invoke(sensitivity);
    }
}