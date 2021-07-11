using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour
{

    public void ExitButton() {
        SceneManager.LoadScene("MainMenu");
    }

    public void StartOver() {
        SceneManager.LoadScene("Level1");
    }

}
