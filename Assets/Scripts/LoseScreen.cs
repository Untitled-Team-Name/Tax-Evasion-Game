using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour
{

    // String name of scene to load
    public string sceneToStartOver;

    // String name of scene to load
    public string sceneToMainMenu;

    // Scene for exit to main menu
    public void ExitButton() {
        SceneManager.LoadScene(sceneToMainMenu);
    }

    // Scene for starting over
    public void StartOver() {
        SceneManager.LoadScene(sceneToStartOver);
    }

}
