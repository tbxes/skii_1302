using UnityEngine;
using UnityEngine.SceneManagement;

public class MainM : MonoBehaviour
{
    public void Startgame()
    {
        
        SceneManager.LoadScene("Loading");
    }

    public void Exit()
    {
        Application.Quit();
    }
}