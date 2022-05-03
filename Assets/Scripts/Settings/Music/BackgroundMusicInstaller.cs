using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BackgroundMusicInstaller : MonoBehaviour
{
    [SerializeField] private SettingsSO _settings;
    private AudioSource _backgroundMusic;

    private void Awake()
    {
        _backgroundMusic = GetComponent<AudioSource>();
        if (_settings.MusicOn)
        {
            _backgroundMusic.Play();
        }
    }
}
