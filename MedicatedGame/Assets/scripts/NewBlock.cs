using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBlock : MonoBehaviour
{
 float timer;
    public GameObject Block;
    private float limiteInferior = 3f;
    private float limiteSuperior = 5f;

    void Update()
    {
        timer += Time.deltaTime;
        float t = Random.Range(limiteSuperior, limiteInferior);
        if(timer >= t)
        {
            timer=0;
            float y = Random.Range(50f, 250f);
            Vector3 position = new Vector3(420, y, 0);
            Quaternion rotation = new Quaternion();
            Instantiate(Block, position, rotation);
        }        
    }
}
