using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{

    public static ScoreKeeper instance;
    public int coinPoints = 10;
    public int score = 0;
    public Text scoreText;
   
    public void Awake()
    {
        instance = this;
        scoreText.text = "Score: " + score.ToString();
    }

    public void AddScore()
    {
        score += coinPoints;
        scoreText.text= "Score: " + score.ToString();
    }
}
