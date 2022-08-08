using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class MusicSettingChanger : MonoBehaviour
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
