using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeEstado : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PediNaranjas(int Na)
    {
        transform.position = new Vector3(transform.position.x + 20, transform.position.y, transform.position.z);
    }
    public void PediAzules(int Az)
    {
        transform.position = new Vector3(transform.position.x - 20, transform.position.y, transform.position.z);
    }
}
