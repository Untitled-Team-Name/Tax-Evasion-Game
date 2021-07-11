using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EndGame : MonoBehaviour
{
    // Slider of the player's health bar
    public Slider slider;

    // String name of scene to load
    public string sceneToLoad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value == 0f) {
            Debug.Log("Game over");

            // Load the game over screen
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
