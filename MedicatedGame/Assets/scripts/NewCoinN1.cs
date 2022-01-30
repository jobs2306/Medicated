using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCoinN1 : MonoBehaviour
{
    float timer;
    public GameObject coinPrefab1;
    private float l1 = 6f;
    private float l2 = 8f;

    void Update()
    {
        timer += Time.deltaTime;
        float t = Random.Range(l1, l2);
        if(timer >= t)
        {
            timer=0;
            
            float y = Random.Range(50f, 190f);
            Vector3 position = new Vector3(420, y, 0);
            Quaternion rotation = new Quaternion();
            Instantiate(coinPrefab1, position, rotation);
        }        
    }
}