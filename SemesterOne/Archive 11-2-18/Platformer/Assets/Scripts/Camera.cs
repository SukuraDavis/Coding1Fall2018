using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Character;
    Vector3 goalVector = new Vector3();
    float speed = 3f;
    float hspeed = 1.2f;

	// Use this for initialization
	void Start ()
    {
        transform.position = new Vector3(Character.transform.position.x, Character.transform.position.y, -10);
	}
	
	// Update is called once per frame
	void Update ()
    {
       goalVector = new Vector3(Character.transform.position.x, Character.transform.position.y, -10);

        goalVector += new Vector3(Character.GetComponent<Rigidbody2D>().velocity.x, 
            Character.GetComponent<Rigidbody2D>().velocity.y, 0);



        Vector3 velocity = goalVector - transform.position;


        transform.position += new Vector3(velocity.x * Time.deltaTime * hspeed,
            velocity.y * Time.deltaTime * speed, 0);
    }
}
