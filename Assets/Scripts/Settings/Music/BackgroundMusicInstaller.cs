using UnityEngine;

public class BackgroundMusicInstaller : MonoBehaviour
{
    [SerializeField] private AudioSource _backgroundMusic;
    [SerializeField] private SettingsSO _settings;

    private void Awake()
    {
        if (_settings.MusicOn)
        {
            _backgroundMusic.Play();
        }
    }
}
