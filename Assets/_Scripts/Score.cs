using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

    private TextMesh score;
    private int result;

    // Use this for initialization
    void Start () {
        score = GetComponent<TextMesh>();
        score.text = "0";
        result = 0;
    }

    public void killAsteroid()
    {
        result = result + 10;
        score.text = "" + result;
    }

    public void killVillain()
    {
        result = result + 50;
        score.text = "" + result;
    }

    public int getResult()
    {
        return result;
    }

    public void saveResult()
    {
        if(PlayerPrefs.GetInt("score") <= result)
        {
            PlayerPrefs.SetInt("score", result);
        }
        SceneManager.LoadSceneAsync("Menu");
    }
}
