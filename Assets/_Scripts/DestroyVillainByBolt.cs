using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyVillainByBolt : MonoBehaviour {

    public GameObject playerExplosion;
    public AudioClip audioClipVillain;
    private Score score;

    private void Start()
    {
        score = GameObject.Find("Score").GetComponent<Score>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }
        if (other.tag == "BoltVillain")
        {
            return;
        }
        if(other.tag == "Bolt")
        {
            score.killVillain();
        }

        
        Vector3 position = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z - 4);
        
        
        Instantiate(playerExplosion, position, other.transform.rotation);
        AudioSource.PlayClipAtPoint(audioClipVillain, other.transform.position);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }

}
