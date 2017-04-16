using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnExitClick : MonoBehaviour {

	public void ExitOnCLick()
    {
        Debug.Log("ExitOnCLick");
        Application.Quit();
    }
}
