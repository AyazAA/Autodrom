using Assets.Scripts;
using UnityEngine;

public class SensitivityInstaller : MonoBehaviour
{
    [SerializeField] private SettingsSO _settings;
    private SteerRotator _steerRotator;

    private void Awake()
    {
        _steerRotator = GetComponent<SteerRotator>();
        _steerRotator.SetSensitivity(_settings.SteerSensitivity);
    }
}