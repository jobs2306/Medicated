using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Coin Controller para el naranja
public class coincontroller : MonoBehaviour
{
    private float velocidad = -40f;
    private float VV = 1;
    private GameObject DTiempo;

    private void OnTriggerEnter2D(Collider2D collision) 
    { 
        GameObject general = GameObject.Find("general"); 
        general.GetComponent<ScoreManager>().RaiseScore(1);
    
        GameObject Estado = GameObject.Find("ui_barra_circulo");
        Estado.GetComponent<changeEstado>().PediNaranjas(1);
        Destroy(gameObject);
    }
    private void Update() 
    {
        DTiempo = GameObject.Find("fondo");
        VV = DTiempo.GetComponent<movimientFondo>().VV;
        transform.Translate(Vector3.right * Time.deltaTime * velocidad * VV );
    }
 
}
