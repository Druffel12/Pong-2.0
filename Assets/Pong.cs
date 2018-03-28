using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pong : MonoBehaviour
{
    Rigidbody RB;
    public float Push;
	// Use this for initialization
    //random start direction 
	void Start ()
    {
       RB = GetComponent<Rigidbody>();
        RB.AddForce(Random.insideUnitSphere * Push, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update ()
    {
   
        // direction change up for only moving one way
        float xSign = Mathf.Sign(RB.velocity.x);
        float zSign = Mathf.Sign(RB.velocity.z);
        float ySign = Mathf.Sign(RB.velocity.y);
        if (Mathf.Abs(RB.velocity.x) < 5)
        {
            //figure out which direction it was going and apply force that way
            RB.AddForce(Vector3.right * xSign * Push);
        }
        if (Mathf.Abs(RB.velocity.z) < 5)
        {
            RB.AddForce(Vector3.forward * zSign * Push);
        }
        if (Mathf.Abs(RB.velocity.y) < 5)
        {
            RB.AddForce(Vector3.down * ySign * Push);
        }
        if (RB.transform.position = (43,0,0))
    }
}
