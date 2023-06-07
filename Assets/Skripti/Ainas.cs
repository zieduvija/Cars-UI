using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ainas : MonoBehaviour {

    public void Spelet()
    {
        SceneManager.LoadScene(sceneName:"Spele");
    }
    
    public void Iziet()
    {
        Application.Quit();
    }
}
