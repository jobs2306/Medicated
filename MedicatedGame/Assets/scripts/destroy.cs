using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 

public class destroy : MonoBehaviour
{
    public string sceneName1;

     private void OnTriggerEnter2D(Collider2D collision) 
    {
        GameObject soundController = GameObject.Find("muerte");
        soundController.SendMessage("PlayPopSound");
        SceneManager.LoadScene(sceneName1);
    }

}
