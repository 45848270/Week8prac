using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
        public float playerSpeed = 5f; // metre per second    


    // Update is called once per frame
    void Update()
    {
        float upDown = Input.GetAxis("Fire1");
        float leftRight = Input.GetAxis("Fire2");

        transform.Translate(upDown * playerSpeed * Vector3.forward * Time.deltaTime);       
        transform.Translate(leftRight * playerSpeed * Vector3.right * Time.deltaTime);
    }
}







