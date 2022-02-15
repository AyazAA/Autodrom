using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    [SerializeField] private int _sceneNumber = 0;

    public void RestartExercise()
    {
        SceneManager.LoadScene(_sceneNumber);
    }
}