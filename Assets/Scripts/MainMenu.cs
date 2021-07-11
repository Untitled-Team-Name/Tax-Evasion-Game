using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // String name of scene to load
    public string sceneToLoad;

    // Exit button
    public void ExitButton() {
        Application.Quit();
        Debug.Log("Game Closed");
    }

    // Start game button
    public void StartGame() {
        //SceneManager.LoadScene("Level1");
        SceneManager.LoadScene(sceneToLoad);
    }
}
