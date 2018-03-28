using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreZoneR : MonoBehaviour {
    int BPoint;
    public Rigidbody RB;
    public GameObject BlueWin;
     void OnTriggerEnter(Collider other)
    {
       if (BPoint == 7)
        {
            BlueWin.SetActive(true);
        }

        else
        {
            BPoint++;
            RB = GetComponent<Rigidbody>();
            RB.transform.position = new Vector3(0, 20, 0);
            RB.velocity = new Vector3();
        }
    }
}
