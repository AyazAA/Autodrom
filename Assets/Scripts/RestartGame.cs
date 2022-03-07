using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    [SerializeField] private int _sceneNumber = 0;

    public void RestartExercise()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(_sceneNumber);
    }
}