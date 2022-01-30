using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class azulNaranjaControlador : MonoBehaviour
{
    private float velocidad = -40f;
    
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        Destroy(gameObject);    
    }
    private void Update() 
    {
        transform.Translate(Vector3.right * Time.deltaTime * velocidad);
    }
}
