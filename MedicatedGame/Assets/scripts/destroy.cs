using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 

public class destroy : MonoBehaviour
{


     private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.tag == "block") //Detectar con que colisiono
        {

           Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

        }   
    }

}
