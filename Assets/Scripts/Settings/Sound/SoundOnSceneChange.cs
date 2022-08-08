using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class SoundOnSceneChange : MonoBehaviour
{
    [SerializeField] private List<AudioSource> _soundSourceList;
    private Toggle _soundToggle;

    private void Awake()
    {
        _soundToggle = GetComponent<Toggle>();
    }

    public void ChangeOnSceneStatus()
    {
        foreach (AudioSource soundSource in _soundSourceList)
        {
            soundSource.mute = !_soundToggle.isOn;
        }
    }
}
