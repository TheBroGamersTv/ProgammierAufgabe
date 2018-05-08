using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumppadscript : MonoBehaviour {

    public PlayerContoller player;

    // Use this for initialization
    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<PlayerContoller>();
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.Jumping = true;
            
            player.JUMP(60f);
            
        }
    }
}
