using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{

    public float speed;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w")) {
            pos.y += speed * Time.deltaTime;
        }

        if (Input.GetKey("a")) {
            pos.x -= speed * Time.deltaTime;
        }

        if (Input.GetKey("s")) {
            pos.y -= speed * Time.deltaTime;
        }

        if (Input.GetKey("d")) {
            pos.x += speed * Time.deltaTime;
        }

        transform.position = pos;

    }
}
