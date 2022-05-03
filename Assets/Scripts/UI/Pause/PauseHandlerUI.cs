using UnityEngine;

public class PauseHandlerUI: MonoBehaviour 
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
