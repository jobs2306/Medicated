using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class compartirInfo : MonoBehaviour
{
  //instancia unica, este será un objeto unico, no se reiniciará al cambiar de escena
    public static compartirInfo inst;

    //variable para pedir 
    public GameObject DataMovim;
    public float pxa,pya,pza;
    public int n = 0;   //con esta variable se diferencia la primera vez que se ejecuta este codigo y poder pedirla 
    //en el objeto externo que se le quiere guardar la posición
    void Awake() 
    {
        if(compartirInfo.inst == null)
        {
            //primera vez que se ejecuta el codigo
            compartirInfo.inst = this;
            DontDestroyOnLoad(gameObject);
        }    
        else
        {
            //Ya hay una instancia. Eliminar esta
            Destroy(gameObject);
        }
    }
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        DataMovim = GameObject.Find("Ch17_nonPBR");  //Aquí se indica el nombre del objeto al que se le quiere
        //mantener la posición al hacer el cambio de escena
        transform.position = DataMovim.transform.position;  
        transform.rotation = DataMovim.transform.rotation;  //Se guarda la posición y rotación 
        n = 1;
    }
}
