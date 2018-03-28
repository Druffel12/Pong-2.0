using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreZoneB : MonoBehaviour {
    int RPoint;
    public Rigidbody RB;
    public GameObject RedWin;
    void OnTriggerEnter(Collider other)
    {
        if (RPoint == 7)
        {
            RedWin.SetActive(true);
        }

        else
        {
            RPoint++;
            RB = GetComponent<Rigidbody>();
            RB.transform.position = new Vector3(0, 20, 0);
            RB.velocity = new Vector3();
        }
    }
}
