using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class azulNaranjaControlador : MonoBehaviour
{
    private float velocidad = -47f;

    private void Update() 
    {
        transform.Translate(Vector3.right * Time.deltaTime * velocidad);
    }
}
