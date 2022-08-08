using UnityEngine;

[RequireComponent(typeof(ScreenDarkening))]
public class PauseMenuOpener : MonoBehaviour
{
    [SerializeField] private PauseHandlerUI _pauseHandler;
    [SerializeField] private HelpOpener _infoHandler;
    [SerializeField] private SettingsOpener _settingsHandler;
    private ScreenDarkening _screenDarkening;
    private bool _pauseIsOpen = false;

    private void Start()
    {
        _screenDarkening = GetComponent<ScreenDarkening>();
    }

    public void PauseMenuChangeStatus()
    {
        _pauseIsOpen = !_pauseIsOpen;
        if (_pauseIsOpen)
        {
            PauseMenuShow();
            _screenDarkening.Darken();
            Time.timeScale = 0f;
        }
        else
        {
            PauseMenuHide();
            _screenDarkening.Undarken();
            Time.timeScale = 1f;
        }
    }

    private void PauseMenuShow()
    {
        _pauseHandler.Show();
    }

    private void PauseMenuHide()
    {
        _pauseHandler.Hide();
        _infoHandler.SetStatus(false);
        _settingsHandler.SetStatus(false);
    }

    public void SetStatus(bool status)
    {
        if (status == true)
        { 
            _pauseHandler.Show(); 
        }
        else 
        { 
            _pauseHandler.Hide(); 
        }
    }
}
