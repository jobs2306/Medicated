using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contadortiempo : MonoBehaviour
{
    float timer = 0;
    int timer1;
    public Text cTiempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    int n=0;
    void Update()
    {
        if (n<10)
        {
            if(timer1 == 60)
            {
                n = n+1;
                timer = 0;
            }
            timer += Time.deltaTime;
            timer1 = (int)timer;
            cTiempo.text = "0" + n + ":" + timer1;
        }
        else
        {
            if(timer1 == 60)
            {
                n = n + 1;
                timer = 0;
            }
            timer += Time.deltaTime;
            timer1 = (int)timer;
            cTiempo.text = n + ":" + timer1;

        }
    }
}
