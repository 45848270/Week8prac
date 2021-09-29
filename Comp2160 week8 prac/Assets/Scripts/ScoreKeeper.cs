using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{

    public static ScoreKeeper instance;
    public int coinPoints = 10;
    public Text scoreText;

    public int score;

    public void Awake()
    {
        instance = this;
        scoreText.text = "Score: 0" + score.ToString();
    }

    public void AddScore()
    {
        Debug.Log("Adding Score");
        score += coinPoints;
        scoreText.text= "Score: " + score.ToString();
    }
}
