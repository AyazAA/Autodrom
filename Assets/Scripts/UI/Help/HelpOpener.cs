using UnityEngine;

public class HelpOpener : MonoBehaviour
{
    [SerializeField] private HelpInfoUI _helpInfo;
    [SerializeField] private PauseMenuOpener _pauseMenu;

    public void HelpShow()
    {
        _pauseMenu.SetStatus(false);
        _helpInfo.Show();
    }

    public void HelpHide()
    {
        _helpInfo.Hide();
        _pauseMenu.SetStatus(true);
    }

    public void SetStatus(bool status)
    {
        if(status == true)
        {
            _helpInfo.Show();
        }
        else
        {
            _helpInfo.Hide();
        }
    }
}
