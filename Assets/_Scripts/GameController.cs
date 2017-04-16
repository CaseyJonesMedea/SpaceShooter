using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject hazard;
    public GameObject villain;
    

    public Vector3 spanwValues;
    

	private float timerVillain = 3;

    private float timerAsteroid = 1;

    private float volume = 0.1f;

    private void Start()
    {
        GetComponent<AudioSource>().loop = true;
        GetComponent<AudioSource>().volume = volume;
        GetComponent<AudioSource>().Play();
    }


    void SpawnWaves()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-spanwValues.x, spanwValues.x), spanwValues.y, spanwValues.z);
        Quaternion spawnRotation = Quaternion.identity;
        Instantiate(hazard, spawnPosition, spawnRotation);
    }

    void SpawnVillain()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-spanwValues.x, spanwValues.x), spanwValues.y, spanwValues.z);
        Quaternion spawnRotation = Quaternion.Euler(180,0,0);
        
        Instantiate(villain, spawnPosition, spawnRotation);
    }

    private void Update()
    {
        if(timerVillain > 0)
        {
            timerVillain -= Time.deltaTime;
        }
        if(timerVillain < 0)
        {
            SpawnVillain();
            timerVillain = 3;
        }
        if (timerAsteroid > 0)
        {
            timerAsteroid -= Time.deltaTime;
        }
        if (timerAsteroid < 0)
        {
            SpawnWaves();
            timerAsteroid = 1;
        }
    }



	
}
