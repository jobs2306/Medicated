using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Coin Controller para el azul
public class coincontroller1 : MonoBehaviour
{
    private float velocidad = -40f;
    private void OnTriggerEnter2D(Collider2D collision) 
    { 
        GameObject general = GameObject.Find("general"); 
        general.GetComponent<ScoreManager>().RaiseScore(1);

        GameObject Estado = GameObject.Find("ui_barra_circulo");
        Estado.GetComponent<changeEstado>().PediAzules(1);
        Destroy(gameObject);
    }
    private void Update() 
    {
        transform.Translate(Vector3.right * Time.deltaTime * velocidad);
    }
 
}
