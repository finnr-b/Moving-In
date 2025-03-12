using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitApp()
    {
        Application.Quit();
        Debug.Log("Application Has Quit.");
    }
}
