﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverAsteroid : MonoBehaviour {

    private float speed = 5;

    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody>().velocity = -transform.forward * speed;
    }
	
}