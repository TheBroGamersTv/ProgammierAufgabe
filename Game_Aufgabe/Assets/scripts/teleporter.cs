using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporter : MonoBehaviour {

    public Transform destination;
    public GameObject Player;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Player.gameObject.transform.position = destination.transform.position+new Vector3(1,2,1);
        }
    }
 
}
