using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class MusicOnSceneChange: MonoBehaviour
{
    [SerializeField] private AudioSource _musicSource;
    private Toggle _musicToggle;

    private void Awake()
    {
        _musicToggle = GetComponent<Toggle>();
    }

    public void ChangeOnSceneStatus()
    {
        if(_musicToggle.isOn)
        {
            _musicSource.Play();
        }
        else
        {
            _musicSource.Stop();
        }
    }
}