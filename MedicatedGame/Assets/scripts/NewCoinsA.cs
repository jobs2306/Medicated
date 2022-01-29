using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCoinsA : MonoBehaviour
{
    float timer;
    public GameObject coinPrefab;
    public float l1 = 3f;
    public float l2 = 5f;
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
            Instantiate(coinPrefab, position, rotation);
        }        
    }
}
