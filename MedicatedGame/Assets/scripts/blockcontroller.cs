using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockcontroller : MonoBehaviour
{
    private float velocidad = -40f;

    private void Update() 
    {
        transform.Translate(Vector3.right * Time.deltaTime * velocidad);
    }
 
}
