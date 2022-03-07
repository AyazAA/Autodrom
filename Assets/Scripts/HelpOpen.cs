using TMPro;
using UnityEngine;

public class HelpOpen : MonoBehaviour
{
    [SerializeField] private TMP_Text _helpTMP;
    private bool _helpOpened = false;

    public void OpenHelp()
    {
        _helpOpened = _helpOpened ? false : true;
        if (_helpOpened)
        {
            _helpTMP.gameObject.SetActive(true);
        }
        else
        {
            _helpTMP.gameObject.SetActive(false);
        }
    }
}