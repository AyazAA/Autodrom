using TMPro;
using UnityEngine;

public class HelpOpen : MonoBehaviour
{
    [SerializeField] private GameObject _helpInfo;
    private bool _helpOpened = false;

    public void OpenHelp()
    {
        _helpOpened = _helpOpened ? false : true;
        if (_helpOpened)
        {
            _helpInfo.SetActive(true);
        }
        else
        {
            _helpInfo.SetActive(false);
        }
    }
}