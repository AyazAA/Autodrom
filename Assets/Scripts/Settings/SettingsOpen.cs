using UnityEngine;
using UnityEngine.UI;

public class SettingsOpen : MonoBehaviour
{
    [SerializeField] private GameObject _settingsHandler;
    [SerializeField] private GameObject _pauseHandler;
    [SerializeField] private SettingsSO _settings;
    [SerializeField] private Toggle _musicToggle;
    [SerializeField] private Toggle _soundToggle;
    [SerializeField] private Slider _sensitivitySlider;
    private bool _settingsIsOpen = false;

    public void SettingShow()
    {
        if(_pauseHandler != null)
        {
            _pauseHandler.SetActive(false);
        }
        _settingsIsOpen = _settingsIsOpen ? false : true;
        _settingsHandler.SetActive(_settingsIsOpen);
        _musicToggle.isOn = _settings.MusicOn;
        _soundToggle.isOn = _settings.SoundOn;
        _sensitivitySlider.value = _settings.GetSensetivityBetweenOneZero();
    }
        
    public void SettingsClose()
    {
        _settingsIsOpen = false;
        _settingsHandler.SetActive(false);
        _pauseHandler?.SetActive(true);
    }

    public void SetStatus(bool status)
    {
        _settingsIsOpen = status;
        _settingsHandler.SetActive(status);
    }
}
