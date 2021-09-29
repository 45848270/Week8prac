using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
   

    void OnTriggerEnter(Collider hit)
    {
        if(hit.gameObject.tag.Equals("Player"))
        {
            
            ScoreKeeper.instance.AddScore();
            Destroy(gameObject);

        }

    }

}

