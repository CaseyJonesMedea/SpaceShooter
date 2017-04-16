using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMaxResult : MonoBehaviour {

    Text score;

    
    void Start () {
        score = GetComponent<UnityEngine.UI.Text>();
        string result = PlayerPrefs.GetInt("score").ToString();
        score.text = result;
    }
	
	
}
