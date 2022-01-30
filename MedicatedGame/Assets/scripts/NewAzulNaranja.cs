using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewAzulNaranja : MonoBehaviour
{
     float timer;
    public GameObject Block;
    public float limiteInferior = 3f;
    public float limiteSuperior = 8f;

    void Update()
    {
        timer += Time.deltaTime;
        float t = Random.Range(limiteSuperior, limiteInferior);
        if(timer >= t)
        {
            timer=0;
            float y = Random.Range(80f,280f);
            Vector3 position = new Vector3(420, y, 0);
            Quaternion rotation = new Quaternion();
            Instantiate(Block, position, rotation);
        }        
    }
}
