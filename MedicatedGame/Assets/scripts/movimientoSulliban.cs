using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoSulliban : MonoBehaviour
{
    public float velMov = 5.0f;
    public float x, y;
    //public float limiz = -67;
    //public float limder = 22;
    private float limab = 50;
    private float limarr = 190;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //control del jugador
        y = Input.GetAxis("Vertical");
        x = Input.GetAxis("Horizontal");
        transform.Translate(0, y * Time.deltaTime * velMov, 0);
        transform.Translate(x * Time.deltaTime * velMov, 0, 0);

        //limites
        if (transform.position.y > limarr)
        {
            transform.position = new Vector3(transform.position.x, limarr, transform.position.z);
        }
        if (transform.position.y < limab)
        {
            transform.position = new Vector3(transform.position.x, limab, transform.position.z);
        }
    }
}
