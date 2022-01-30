using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockcontroller : MonoBehaviour
{
    private float velocidad = -40f;
    private float VV = 1;
    private GameObject DTiempo;
    private void Update() 
    {
        DTiempo = GameObject.Find("fondo");
        VV = DTiempo.GetComponent<movimientFondo>().VV;
        transform.Translate(Vector3.right * Time.deltaTime * velocidad*VV);
    }
 
}
