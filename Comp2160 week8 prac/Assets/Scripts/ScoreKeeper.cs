using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{

    public static ScoreKeeper instance;
    public int coinPoints = 10;
    public Text player1ScoreText;
    public Text player2ScoreText;

    public int player1Score;
    public int player2Score;

    public void Awake()
    {
        instance = this;
        player1ScoreText.text = "Player1 Score: 0" + player1Score.ToString();
        player2ScoreText.text = "Player2 Score: 0" + player2Score.ToString();
    }

    public void AddPlayer1Score()
    {
        Debug.Log("Adding Score To Player1");
        player1Score += coinPoints;
        player1ScoreText.text= "Score: " + player1Score.ToString();
    }
    public void AddPlayer2Score()
    {
        Debug.Log("Adding Score To Player2");
        player2Score += coinPoints;
        player2ScoreText.text = "Score: " + player2Score.ToString();
    }
}
