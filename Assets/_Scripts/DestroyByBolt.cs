using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBolt : MonoBehaviour {

    public GameObject playerExplosion;
    public AudioClip audioClipPlayer;

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
        if(other.tag == "Bolt")
        {
            return;
        }

        score.saveResult();
        
        Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
        AudioSource.PlayClipAtPoint(audioClipPlayer, other.transform.position);
        Destroy(other.gameObject);
        Destroy(gameObject);
        
    }

}
