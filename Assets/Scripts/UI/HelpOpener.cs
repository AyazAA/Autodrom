using UnityEngine;

public class HelpOpener : MonoBehaviour
{
    [SerializeField] private GameObject _helpInfo;
    [SerializeField] private PauseMenuOpener _pauseMenu;

    public void HelpShow()
    {
        _pauseMenu.SetStatus(false);
        _helpInfo.SetActive(true);
    }

    public void HelpHide()
    {
        _helpInfo.SetActive(false);
        _pauseMenu.SetStatus(true);
    }

    public void SetStatus(bool status)
    {
        _helpInfo.SetActive(status);
    }
}