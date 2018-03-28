using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementR : MonoBehaviour
{

    float MovementSpeed = 20.0f;
    Rigidbody rb;
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        rb.velocity = Vector3.zero;
		if(Input.GetKey("up"))
        {
       
            transform.position += Vector3.up * Time.deltaTime * MovementSpeed;
        }
        if(Input.GetKey("down"))
        {
            transform.position += Vector3.down * Time.deltaTime * MovementSpeed;
        }
	}
}
