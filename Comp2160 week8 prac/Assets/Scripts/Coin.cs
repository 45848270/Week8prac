using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
   

void OnTriggerEnter(Collider hit)
{

 if(hit.gameObject.tag.Equals("Player"))
        {
        Destroy(gameObject);
      ScoreKeeper.instance.AddScore();

        }

}

}

