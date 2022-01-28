using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruirFueraEscena : MonoBehaviour
{
    private float limite = -17;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < limite)
        {
            Destroy(gameObject);
        }
        
    }
}
