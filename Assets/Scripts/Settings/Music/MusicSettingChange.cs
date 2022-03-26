using UnityEngine;
using UnityEngine.UI;

public class MusicSettingChange : MonoBehaviour
{
    [SerializeField] private SettingsSO _settings;
    private Toggle _musicToggle;

    private void Awake()
    {
        _musicToggle = GetComponent<Toggle>();
    }

    public void ChangeStatus()
    {
        _settings.MusicOn = _musicToggle.isOn;
    }
}
