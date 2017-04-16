using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBoltOfVillain : MonoBehaviour {

    public float speed;


    void Start () {
        GetComponent<AudioSource>().Play();
        GetComponent<Rigidbody>().velocity = -transform.forward * speed;
    }
}
