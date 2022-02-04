using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class changeEstado : MonoBehaviour
{

    public ScoreManager puntaje ;
    
    
    private float positionIz;
    private float positionDe;
    private string sceneName1 = "lost";
    private bool banderaCambio =false;
    // Start is called before the first frame update
    void Start()
    {
        positionDe = transform.position.x+20*5;
        positionIz = transform.position.x-20*5;
    }

    public void PediNaranjas(int Na)
    {
        transform.position = new Vector3(transform.position.x + 10, transform.position.y, transform.position.z);
        if(transform.position.x == positionDe)
        {
            LoadScene(sceneName1);
        }
    }
    public void PediAzules(int Az)
    {
        transform.position = new Vector3(transform.position.x - 10, transform.position.y, transform.position.z);
        if(transform.position.x == positionIz)
        {
            LoadScene(sceneName1);
        }
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    private void Update() 
    {
        
        float Score = puntaje.score/10000;
        float aumento = 0.01f*Score;
        
        if (aumento > 0.04f)
        {
            aumento = 0.04f;
        }
        Debug.Log(aumento*100);
        GameObject Monstruo1 = GameObject.Find("inicio-monstruo-1");
        GameObject Monstruo2 = GameObject.Find("inicio-monstruo-2");
        
        if(transform.position.x < 254)
        {
            transform.position = new Vector3(transform.position.x - aumento -0.01f, transform.position.y, transform.position.z);
            
            if ( banderaCambio == false)
            {
                Monstruo2.transform.localScale = new Vector3(0, 0, 0);
                Monstruo1.transform.localScale = new Vector3(-12, 12 ,1);
                banderaCambio =  true;
            }
            
            
        }

        if(transform.position.x > 255)
        {
            transform.position = new Vector3(transform.position.x + 0.01f + aumento, transform.position.y, transform.position.z);
            
            if ( banderaCambio == true)
            {
            Monstruo1.transform.localScale = new Vector3(0, 0, 0);
            Monstruo2.transform.localScale = new Vector3(11.825f, 10.329f ,1);       
            banderaCambio = false;
            }
            
        }

        if(transform.position.x < positionIz)
        {
            transform.position = new Vector3(positionIz, transform.position.y, transform.position.z);
            LoadScene(sceneName1);
        }
        if(transform.position.x > positionDe )
        {
            transform.position = new Vector3(positionDe, transform.position.y, transform.position.z);
            LoadScene(sceneName1);
        }
    }
}
