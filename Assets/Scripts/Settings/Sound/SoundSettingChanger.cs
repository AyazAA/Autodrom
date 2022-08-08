using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class SoundSettingChanger : MonoBehaviour
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
