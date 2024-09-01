using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{

    public LoseWindowScore LoseWindow;
    public static GameManeger Instance;

    private void Start()
    {
        Instance = this;
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Lose()
    {
        LoseWindow.gameObject.SetActive(true);
        LoseWindow.PlayerLose();
        Time.timeScale = 0;
    }

    public void LoadScenee(int scenenumber)
    {
        SceneManager.LoadScene(scenenumber);
        Time.timeScale = 1;
    }
}
