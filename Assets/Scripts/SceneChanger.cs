using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void GoToScene(string sceneName)
    {
        //Debug.Log("pressed button"); //checking button functionality
        SceneManager.LoadScene(sceneName); //load selected scene; see button onClick 
    }
}