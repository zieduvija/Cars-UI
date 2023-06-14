using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ainas : MonoBehaviour {
    public Objekti objekti;
    public void Spelet()
    {
        SceneManager.LoadScene(sceneName:"Spele");
    }
    
    public void Sakums()
    {
        SceneManager.LoadScene(sceneName:"Start");
    }

    public void Iziet()
    {
        Application.Quit();
    }
}
