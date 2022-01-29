using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    int score = 0;
    int highScore = 0;
    public Text HiScore;
    public Text scoreText;

    public void RaiseScore(int s)
    {
        score+= s;
        scoreText.text = score + "";
        if(highScore<score)
        {
            highScore = score;
            HiScore.text = highScore + "";
        }

    }
}
