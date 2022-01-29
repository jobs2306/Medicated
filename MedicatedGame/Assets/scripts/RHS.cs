using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RHS : MonoBehaviour
{
    public static RHS inst;
    public GameObject DataHS;
    public int HS;

    public int n = 0;   //con esta variable se diferencia la primera vez que se ejecuta este codigo y poder pedirla 
    //en el objeto externo que se le quiere guardar la posición
    void Awake() 
    {
        if(RHS.inst == null)
        {
            //primera vez que se ejecuta el codigo
            RHS.inst = this;
            DontDestroyOnLoad(gameObject);
        }    
        else
        {
            //Ya hay una instancia. Eliminar esta
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        DataHS = GameObject.Find("mantenerHighScore"); //Aquí se indica el nombre del objeto al que se le quiere
        //mantener la posición al hacer el cambio de escena
        HS = DataHS.GetComponent<highscore>().highScores;
        n = 1;
    }
}
