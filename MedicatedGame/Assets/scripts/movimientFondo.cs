using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientFondo : MonoBehaviour
{
    Material material1;
    private float velocidad = 10.2f;
    private float Vvelocidad;
    public float VV = 1;
    private float timer = 0;

    Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer spr = GetComponent<SpriteRenderer>();
        material1 = spr.material;
        offset = material1.mainTextureOffset;
    }

    void Update()
    {
        if(VV < 2.5)
        {
           timer += Time.deltaTime;
           VV = timer * (0.5f/60.0f) + 1;
        }

        offset.x += Time.deltaTime / (velocidad/VV); 
        material1.mainTextureOffset = offset;         
    }
}
