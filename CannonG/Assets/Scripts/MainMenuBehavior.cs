
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuBehavior : MonoBehaviour
{
    // Code from Brackeys https://www.youtube.com/watch?v=zc8ac_qUXQY&t=622s
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
