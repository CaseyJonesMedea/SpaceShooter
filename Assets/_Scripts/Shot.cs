using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour {

	public GameObject shot;
	public Transform shotSpawn;

	public float fireRate;
	private float nextFire;




	void OnMouseDown()
	{
		if (Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
		}

	}
}
