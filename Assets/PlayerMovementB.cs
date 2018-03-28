using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementB : MonoBehaviour {

    float MovementSpeed = 20.0f;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {

            transform.position += Vector3.up * Time.deltaTime * MovementSpeed;
        }
        if (Input.GetKey("s"))
        {
            transform.position += Vector3.down * Time.deltaTime * MovementSpeed;
        }
    }
}
