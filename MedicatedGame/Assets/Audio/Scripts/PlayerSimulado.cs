using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSimulado : MonoBehaviour
{
    void Update()
    {
        // 1. Pildora Azul o naranja tomada
        if (Input.GetKeyDown(KeyCode.Q))
        {
            print("El personaje toma una pildora");
            
            /* Busca un game-object llamado "Efecto_PildoraAzul_y_Naranja" y 
               ejecuta el método "PlayPopSound" que se encuentra en el script */
            GameObject soundController = GameObject.Find("Efecto_PildoraAzul_y_Naranja");
            soundController.SendMessage("PlayPopSound");
        }

        // 2. El personaje pierde
        if (Input.GetKeyDown(KeyCode.W))
        {
            print("El personaje muere");

            GameObject soundController = GameObject.Find("Perder");
            soundController.SendMessage("PlayPopSound");
        }

        // 3. Click sobre un botón
        if (Input.GetKeyDown(KeyCode.E))
        {
            print("Click sobre un botón");

            GameObject soundController = GameObject.Find("Click");  
            soundController.SendMessage("PlayPopSound");
        }

        // 4. HighScore Superado
        if (Input.GetKeyDown(KeyCode.R))
        {
            print("High Score Superado :)");

            GameObject soundController = GameObject.Find("HighScore_Superado");
            soundController.SendMessage("PlayPopSound");
        }
    }
}
