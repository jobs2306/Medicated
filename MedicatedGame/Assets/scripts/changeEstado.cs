using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class changeEstado : MonoBehaviour
{
    private float positionIz;
    private float positionDe;
    private string sceneName1 = "lost";
    // Start is called before the first frame update
    void Start()
    {
        positionDe = transform.position.x+20*5;
        positionIz = transform.position.x-20*5;
    }

    public void PediNaranjas(int Na)
    {
        transform.position = new Vector3(transform.position.x + 20, transform.position.y, transform.position.z);
        if(transform.position.x == positionDe)
        {
            LoadScene(sceneName1);
        }
    }
    public void PediAzules(int Az)
    {
        transform.position = new Vector3(transform.position.x - 20, transform.position.y, transform.position.z);
        if(transform.position.x == positionIz)
        {
            LoadScene(sceneName1);
        }
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
