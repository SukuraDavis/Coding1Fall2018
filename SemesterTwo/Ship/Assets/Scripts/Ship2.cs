using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship2 : MonoBehaviour
{
    Vector3 direction = Vector3.zero;
    const float speed = 10.0f;

    void Update()
    {
        Vector3 direction = Vector3.zero;
        const float speed = 10.0f;

        if (Input.GetKey("w"))
        {
            direction += new Vector3(0, 1, 0);
        }
        if (Input.GetKey("s"))
        {
            direction += new Vector3(0, -1, 0);
        }
        if (Input.GetKey("a"))
        {
            direction += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            direction += new Vector3(1, 0, 0);
        }

        if (direction != Vector3.zero)
        {
            direction.Normalize();
            transform.Translate(direction * speed * Time.deltaTime);
        }
        
    }

}
