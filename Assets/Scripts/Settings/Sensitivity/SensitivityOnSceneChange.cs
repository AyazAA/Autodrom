using Assets.Scripts;
using UnityEngine;
using UnityEngine.UI;

public class SensitivityOnSceneChange : MonoBehaviour
{
    [SerializeField] private SteerRotator _steerRotator;
    private Slider _sensitivitySlider;

    private void Awake()
    {
        _sensitivitySlider = GetComponent<Slider>();
    }

    public void ChangeOnSceneStatus()
    {
        float sensitivity = 700 * _sensitivitySlider.value + 100;
        _steerRotator.SetSensitivity(sensitivity);
    }
}