using Assets.Scripts;
using UnityEngine;

[RequireComponent(typeof(SteerRotator))]
public class SensitivityInstaller : MonoBehaviour
{
    [SerializeField] private SettingsSO _settings;
    private SteerRotator _steerRotator;

    private void Awake()
    {
        _steerRotator = GetComponent<SteerRotator>();
        _steerRotator.Initialize(_settings.SteerSensitivity);
    }
}