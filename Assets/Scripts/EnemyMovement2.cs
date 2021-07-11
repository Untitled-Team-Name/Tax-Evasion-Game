using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement2 : MonoBehaviour
{
    /* Enemy Move 1 is the movement script for the 2nd enemy type
     * that follows the player s*/

    // Sets the speed of this enemy type
    [SerializeField] float enemySpeed = 5;

    // Store the player (to follow) as a game object
    [SerializeField] GameObject player;

    // Floats will store the player positions
    private float playerX;
    private float playerY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerX = player.transform.position.x;
        playerY = player.transform.position.y;

        Vector3 target = new Vector3(playerX, playerY, 0);

        // Update the enemy's movement
        // Transform the enemy to the target vector
        transform.position = Vector3.MoveTowards(transform.position, target, enemySpeed * Time.deltaTime);
    }
}
