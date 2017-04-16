using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

    public GameObject explosion;
    public GameObject playerExplosion;
    private Score score;

    public AudioClip audioClipPlayer;
    public AudioClip audioClipAsteriod;

    private void Start()
    {
        score = GameObject.Find("Score").GetComponent<Score>();
    }

    void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Boundary")
        {
            return;
        }

        Instantiate(explosion, transform.position, transform.rotation);

        if (other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            AudioSource.PlayClipAtPoint(audioClipPlayer, other.transform.position);
            score.saveResult();
        }

        if(other.tag == "Villain")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            AudioSource.PlayClipAtPoint(audioClipPlayer, other.transform.position);
        }

        if(other.tag == "Bolt")
        {
            score.killAsteroid();
        }

        AudioSource.PlayClipAtPoint(audioClipAsteriod, other.transform.position);
        

        Destroy(other.gameObject);
        Destroy(gameObject);
        
    }
}
