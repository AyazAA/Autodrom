using UnityEngine;

[RequireComponent(typeof(SettingsInstaller))]
public class SettingsOpener : MonoBehaviour
{
    [SerializeField] private SettingsHandler _settingsHandler;
    [SerializeField] private PauseMenuOpener _pauseMenu;
    private SettingsInstaller _settingsInstaller;

    private void Start()
    {
        _settingsInstaller = GetComponent<SettingsInstaller>();
    }

    public void SettingShow()
    {
        if (_pauseMenu != null)
        {
            _pauseMenu.SetStatus(false);
        }
        _settingsHandler.Show();
        _settingsInstaller.InitializeSettings();
    }

    public void SettingsClose()
    {
        if (_pauseMenu != null)
        {
            _pauseMenu.SetStatus(true);
        }
        _settingsHandler.Hide();
    }

    public void SetStatus(bool status)
    {
        if (status)
        {
            _settingsHandler.Show();
        }
        else
        {
            _settingsHandler.Hide();
        }
    }
}
