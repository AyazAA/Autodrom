using UnityEngine;

public class HelpInfoUI : MonoBehaviour 
{ 
    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
