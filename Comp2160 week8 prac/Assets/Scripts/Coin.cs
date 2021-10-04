using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
   

    void OnTriggerEnter(Collider hit)
    {
        if(hit.gameObject.tag.Equals("Player1"))
        {
            
            ScoreKeeper.instance.AddPlayer1Score();
            Destroy(gameObject);

        }

        if (hit.gameObject.tag.Equals("Player2"))
        {

            ScoreKeeper.instance.AddPlayer2Score();
            Destroy(gameObject);

        }

    }

}

