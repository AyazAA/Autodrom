using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private int _sceneNumber = 0;

    public void UploadScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(_sceneNumber);
    }
}