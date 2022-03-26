using UnityEngine;

[CreateAssetMenu(menuName = "Settings")]
public class SettingsSO : ScriptableObject
{
    public bool MusicOn;
    public bool SoundOn;
    [Range(100f, 800f)]
    public float SteerSensitivity;

    public float GetSensetivityBetweenOneZero()
    {
        return (SteerSensitivity - 100) / 700;
    }
}

