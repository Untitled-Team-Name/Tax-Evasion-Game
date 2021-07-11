using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCollide : MonoBehaviour
{

    public Slider slider;    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Store game object of collision object
        GameObject other = collision.gameObject;

        // Condition for hitting enemy of type 3
        if (other.tag == "Enemy3")
        {
            Debug.Log("Hit enemy 3");

            // Decrease player health
            if(slider.value > 0)
            {
                slider.value -= 100f;
            }
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Store game object of collision object
        GameObject other = collision.gameObject;

        // Condition for hitting enemy of type 2
        if (other.tag == "Enemy2")
        {
            Debug.Log("Hit enemy 2");

            // Decrease player health
            if(slider.value > 0)
            {
                slider.value -= 50f;
            }
            
        }
    }
}
