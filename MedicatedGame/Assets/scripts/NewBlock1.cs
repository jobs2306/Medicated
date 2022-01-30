using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBlock1 : MonoBehaviour
{
    float timer;
    public GameObject Block;
    private float limiteInferior = 4f;
    private float limiteSuperior = 6f;

    void Update()
    {
        timer += Time.deltaTime;
        float t = Random.Range(limiteSuperior, limiteInferior);
        if(timer >= t)
        {
            timer=0;
            float y = Random.Range(80f, 250f);
            Vector3 position = new Vector3(420, y, 0);
            Quaternion rotation = new Quaternion();
            Instantiate(Block, position, rotation);
        }        
    }
}
