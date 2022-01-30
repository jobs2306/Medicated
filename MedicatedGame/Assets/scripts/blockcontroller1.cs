using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockcontroller1 : MonoBehaviour
{
    private float velocidad = -60f;

    private void Update() 
    {
        transform.Translate(Vector3.right * Time.deltaTime * velocidad);
    }
}
