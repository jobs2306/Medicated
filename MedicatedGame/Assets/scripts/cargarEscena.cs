using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class cargarEscena : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        Debug.Log("Funciona");
        GameObject soundController = GameObject.Find("click");
        soundController.SendMessage("PlayPopSound");
        SceneManager.LoadScene(sceneName);
        
    }
}
