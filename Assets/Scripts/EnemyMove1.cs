using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove1 : MonoBehaviour
{
    /* Enemy Move 1 is the movement script for the 1st enemy type (default) */

    // Sets the speed of this enemy type
    [SerializeField] float enemySpeed = 5;

    // List of patrol locations' X values
    [SerializeField] List<float> patrolSpotsX = new List<float>();

    // List of patrol locations' Y values
    [SerializeField] List<float> patrolSpotsY = new List<float>();

    // Starting index of positions to move to
    private int startIndex = 0;

    private int numPositions;

    // Start is called before the first frame update
    void Start()
    {
        // Error if x, y position lists don't match in size
        if(patrolSpotsX.Count != patrolSpotsY.Count)
        {
            Debug.Log("Error: Enemy X/Y position list size not matching");
        }

        // Store the size of the X positions list
        numPositions = patrolSpotsX.Count;

        Debug.Log("Number of positions: " + numPositions);
    }

    // Update is called once per frame
    void Update()
    {

        // Condition for index exceeding the size of positions list
        if(startIndex == numPositions)
        {
            // Reset start index to 0
            startIndex = 0;
        }

        // Store next position coordinates
        float newX = patrolSpotsX[startIndex];
        float newY = patrolSpotsY[startIndex];

        // Create a target vector that the game object will be moving to
        Vector3 target = new Vector3(newX, newY, 0);

        // Transform the enemy to the target vector
        transform.position = Vector3.MoveTowards(transform.position, target, enemySpeed * Time.deltaTime);

        // Create condition once enemy game object reaches the destination x/y coordinates
        if(transform.position.x == newX && transform.position.y == newY)
        {
            Debug.Log("Arrived");

            // Increment index to align with next x/y coordinates
            startIndex++;
        }
    }
}
