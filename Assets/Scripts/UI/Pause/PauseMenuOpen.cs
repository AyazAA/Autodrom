using UnityEngine;

public class PauseMenuOpen : MonoBehaviour
{
    [SerializeField] private GameObject _pauseHandler;
    [SerializeField] private HelpOpen _infoHandler;
    [SerializeField] private SettingsOpen _settingsHandler;
    private bool _pauseIsOpen = false;

    public void PauseMenuChangeStatus()
    {
        _pauseIsOpen = _pauseIsOpen ? false : true;
        if (_pauseIsOpen)
        {
            PauseMenuShow();
        }
        else
        {
            PauseMenuHide();
        }
    }

    private void PauseMenuShow()
    {
        _pauseHandler.SetActive(true);
    }

    private void PauseMenuHide()
    {
        _pauseHandler.SetActive(false);
        _infoHandler.SetStatus(false);
        _settingsHandler.SetStatus(false);
    }
}
