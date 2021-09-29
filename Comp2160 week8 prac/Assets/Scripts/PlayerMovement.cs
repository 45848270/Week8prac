using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
        public float playerSpeed = 5f; // metre per second

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float upDown = Input.GetAxis("Vertical");
        float leftRight = Input.GetAxis("Horizontal");

        transform.Translate(upDown * playerSpeed * Vector3.up * Time.deltaTime);       
        transform.Translate(leftRight * playerSpeed * Vector3.right * Time.deltaTime);
    }
}






}
