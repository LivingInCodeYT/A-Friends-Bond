using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunctions : MonoBehaviour {

    public void MainMenu() {
        SceneManager.LoadScene(0);
    }
    public void PlayGame() {
        SceneManager.LoadScene(1);
    }
    public void QuitGame() {
        Application.Quit();
    }
}