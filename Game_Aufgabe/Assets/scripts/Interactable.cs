using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public PlayerContoller player;
    public float Radius = 4f;
    void OnDrawGizmosSelected()//To visualize to Radius where the player has to move to interact with the object
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, Radius);

    }
    private void Awake()
    {
        //we are trying to find the objekt witch has the playercontroller script in it and the Name Player but you also can find with the Tag "Player"
        player = GameObject.Find("Player").GetComponent<PlayerContoller>();
    }
}


//This Script isn't in use <-----------------------