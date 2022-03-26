using UnityEngine;
using UnityEngine.UI;

public class SensitivitySettingChange : MonoBehaviour
{
    [SerializeField] private SettingsSO _settings;
    private Slider _sensitivitySlider;

    private void Awake()
    {
        _sensitivitySlider = GetComponent<Slider>();
    }

    public void ChangeStatus()
    {
        _settings.SteerSensitivity = 700 * _sensitivitySlider.value + 100;
    }
}
