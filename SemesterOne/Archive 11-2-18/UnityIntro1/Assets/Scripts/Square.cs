﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour {


    [SerializeField]
    GameObject ballPreFab;
    float speed = 2f;

    Vector3 velocity = new Vector3(0, 0, 0);
	// Use this for initialization
	void Start ()
    {
       
	}
	
	// Update is called once per frame
	void Update ()
    {
        velocity = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z + 200 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z - 200 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            velocity += LookAtDirection(transform.eulerAngles.z);
        }

        if (Input.GetKey(KeyCode.S))
        {
            velocity -= LookAtDirection(transform.eulerAngles.z);
        }

        velocity.Normalize();


        transform.position += velocity * Time.deltaTime * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //int degree = 1;
           // for (int i = -180 / degree; i <= 180 / degree; i++) {}
             GameObject newBall = Instantiate(ballPreFab);
                newBall.transform.position = transform.position;
                newBall.GetComponent<Ball>().velocity = LookAtDirection(transform.eulerAngles.z); // + i * degree

                newBall.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            
      
            

        }

        ChangeColor();
	}
    void MoveWASD()
    {
        velocity = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            if (transform.position.y< 1)
            {
                velocity += Vector3.up;
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -1.75f)
            {
                velocity += Vector3.left;
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.y > -1)
            {
                velocity += Vector3.down;
            }
        }

        if (Input.GetKey(KeyCode.O))
        {
            if (transform.position.x< 1.75f)
            {
                velocity += Vector3.right;
            }
        }
    }

    public Vector3 LookAtDirection(float eulerAnglesZ)
    {
        return new Vector3(Mathf.Cos(eulerAnglesZ * Mathf.Deg2Rad), Mathf.Sin(eulerAnglesZ * Mathf.Deg2Rad), 0);
    }

    float timer = 0;
    float timerToReach = .25f;
    void ChangeColor()
    {
        timer += Time.deltaTime;
        if (timer > timerToReach)
        {
            timer = 0;
            GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
    }
}
