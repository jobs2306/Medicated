using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    public void RaiseScore(int s)
    {
        GameObject highScore1 = GameObject.Find("mantenerHighScore");
        score+= s*1000;
        highScore1.GetComponent<highscore>().HighS(score);
        scoreText.text = score + "";
    }
}
