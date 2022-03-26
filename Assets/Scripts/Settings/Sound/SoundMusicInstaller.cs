using System.Collections.Generic;
using UnityEngine;

public class SoundMusicInstaller : MonoBehaviour
{
    [SerializeField] private List<AudioSource> _soundsList;
    [SerializeField] private SettingsSO _settings;

    private void Awake()
    {
        foreach (AudioSource sound in _soundsList)
        {
            sound.mute = !_settings.SoundOn;
        }
    }
}
