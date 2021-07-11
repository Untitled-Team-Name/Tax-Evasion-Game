using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public string nextScene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Character")
        {
            Debug.Log("Collision detected");
            SceneManager.LoadScene(nextScene, LoadSceneMode.Single);
        }

    }
}
