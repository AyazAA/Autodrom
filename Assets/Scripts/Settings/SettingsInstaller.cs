using UnityEngine;
using UnityEngine.UI;

public class SettingsInstaller : MonoBehaviour
{
    [SerializeField] private SettingsSO _settings;
    [SerializeField] private Toggle _musicToggle;
    [SerializeField] private Toggle _soundToggle;
    [SerializeField] private Slider _sensitivitySlider;

    public void InitializeSettings()
    {
        _musicToggle.isOn = _settings.MusicOn;
        _soundToggle.isOn = _settings.SoundOn;
        _sensitivitySlider.value = _settings.GetSensetivityBetweenOneZero();
    }
}