using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverVillain : MonoBehaviour {

    private float speed = 1;
    private Vector3 left = new Vector3(0, 0, -5);
    private Vector3 right = new Vector3(0, 0, -5);
    

    private float timeRotation = 2;
    private float nextRotation;
    private int direction = -1;


    void Update()
    {
        if (Time.time > nextRotation)
        {
            nextRotation = Time.time + timeRotation;
            if (direction == -1)
            {
                GetComponent<Rigidbody>().velocity = right * speed;
                direction = 1;
            }
            else 
            {
                GetComponent<Rigidbody>().velocity = left * speed;
                direction = -1;
            }
            
        }

    }
}
