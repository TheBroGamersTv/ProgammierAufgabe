using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KamerMovent : MonoBehaviour {
    public Transform playerpos;

    public bool FirstPerson = false;
    public Vector3 thirdview;
    public Vector3 firstview;
    public Quaternion playerlook;
    
	
	// Update is called once per frame
	void Update () {
        playerlook = playerpos.rotation;
        if (FirstPerson==true)
        {
           
            transform.position = playerpos.position + thirdview;
        }
        else
        {
            transform.position = playerpos.position + firstview;
        }
        transform.rotation = playerlook;
    }
}
