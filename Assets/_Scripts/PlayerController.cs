using UnityEngine;
using System.Collections;



public class PlayerController : MonoBehaviour 

{
	public float speed;
	public float tilt;


	public GameObject player;
	private Vector3 rightMax;
	private Vector3 leftMax;

	private int typeClick;


	void Start()
	{
		rightMax = new Vector3 (4.9f,1,-5.5f);
		leftMax = new Vector3 (-4.9f,1,-5.5f);
		typeClick = 0;
	}


	void Update()
	{
		if(typeClick == -1){
			player.transform.position = Vector3.MoveTowards (player.transform.position, rightMax, Time.deltaTime*speed);
		}else if(typeClick == 1){
			player.transform.position = Vector3.MoveTowards (player.transform.position, leftMax, Time.deltaTime*speed);
		}
	}


	void OnMouseDown()
	{
		switch (gameObject.name) {
		case "Button_Left":
			typeClick = 1;
			player.transform.rotation = Quaternion.Euler (0.0f, 0.0f, tilt);
			break;
		case "Button_Right":
			typeClick = -1;
			player.transform.rotation = Quaternion.Euler (0.0f, 0.0f, tilt);
			break;
		}
	}

	void OnMouseUp()
	{
		switch (gameObject.name) {
		case "Button_Left":
			typeClick = 0;
			player.transform.rotation = Quaternion.identity;
			break;
		case "Button_Right":
			typeClick = 0;
			player.transform.rotation = Quaternion.identity;
			break;
		}
	}
}







