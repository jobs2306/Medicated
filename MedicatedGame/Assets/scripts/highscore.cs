using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscore : MonoBehaviour
{
    public static highscore inst;

    public int highScores = 0;
    public Text HiScore;
    public GameObject DataHSC;
    
    private void Start() 
    {
        if (RHS.inst.n == 1)
        {
            DataHSC = GameObject.Find("RecuperarHS");
            highScores = DataHSC.GetComponent<RHS>().HS;
        }
    }
    public void HighS(int s)
    {
        if(highScores<s)
        {
            Debug.Log(highScores+"");
            highScores = s;
        }
        HiScore.text = highScores + "";

    }
    private void Update() 
    {    
        HiScore.text = highScores + "";
    }
}
