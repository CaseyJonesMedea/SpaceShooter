using UnityEngine;
using UnityEngine.SceneManagement;

public class OnStartClick : MonoBehaviour {


    public void StartOnClick()
    {
        Debug.Log("StartOnClick");
        SceneManager.LoadSceneAsync("Main");
    }

   
}
