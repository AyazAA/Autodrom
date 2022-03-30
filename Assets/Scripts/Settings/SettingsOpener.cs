using UnityEngine;
using UnityEngine.UI;

public class SettingsOpener : MonoBehaviour
{
    [SerializeField] private GameObject _settingsHandler;
    [SerializeField] private PauseMenuOpener _pauseMenu;
    [SerializeField] private SettingsSO _settings;
    [SerializeField] private Toggle _musicToggle;
    [SerializeField] private Toggle _soundToggle;
    [SerializeField] private Slider _sensitivitySlider;

    public void SettingShow()
    {
        if(_pauseMenu != null)
        {
            _pauseMenu.SetStatus(false);
        }
        _settingsHandler.SetActive(true);
        _musicToggle.isOn = _settings.MusicOn;
        _soundToggle.isOn = _settings.SoundOn;
        _sensitivitySlider.value = _settings.GetSensetivityBetweenOneZero();
    }
        
    public void SettingsClose()
    {
        if(_pauseMenu != null)
        {
            _pauseMenu.SetStatus(true);
        }
        _settingsHandler.SetActive(false);
    }

    public void SetStatus(bool status)
    {
        _settingsHandler.SetActive(status);
    }
}
