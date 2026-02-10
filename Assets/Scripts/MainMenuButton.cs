using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuButton : MonoBehaviour
{
    
    public void LoadInstruct()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void LoadMainmenu()
    {
        SceneManager.LoadScene("Title screen");
    }

    public void Quitgame()
    {
        Application.Quit();
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
