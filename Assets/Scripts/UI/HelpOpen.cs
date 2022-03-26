using UnityEngine;

public class HelpOpen : MonoBehaviour
{
    [SerializeField] private GameObject _helpInfo;
    [SerializeField] private GameObject _pauseHandler;
    private bool _helpOpened = false;

    public void OpenHelp()
    {
        _helpOpened = _helpOpened ? false : true;
        if (_helpOpened)
        {
            _pauseHandler.SetActive(false);
            _helpInfo.SetActive(true);
        }
        else
        {
            _helpInfo.SetActive(false);
            _pauseHandler.SetActive(true);
        }
    }

    public void SetStatus(bool status)
    {
        _helpOpened = status;
        _helpInfo.SetActive(status);
    }
}