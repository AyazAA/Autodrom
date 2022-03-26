using UnityEngine;
using UnityEngine.UI;

public class SoundSettingChange : MonoBehaviour
{
    [SerializeField] private SettingsSO _settings;
    private Toggle _soundToggle;

    private void Awake()
    {
        _soundToggle = GetComponent<Toggle>();
    }

    public void ChangeStatus()
    {
        _settings.SoundOn = _soundToggle.isOn;
    }
}
