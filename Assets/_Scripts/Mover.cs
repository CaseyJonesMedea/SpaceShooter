using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	public float speed;

	void Start () {
        GetComponent<AudioSource>().Play();
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
	}

}
