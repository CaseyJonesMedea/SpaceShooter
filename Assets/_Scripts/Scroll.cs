using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {

    public float speed;
    /*private GameObject background;*/
    private Renderer renderer;

	// Use this for initialization
	void Start () {
        //background = GetComponent<GameObject>();
        renderer = GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 offset = new Vector3(0, Time.time * speed, 0);
        renderer.material.mainTextureOffset = offset;
    }
}
