using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatInteract : MonoBehaviour
{
    //this is the script for the chest interct , the radis is witch in with the player can intercat with the chest.
    //we get the transform player for the position where the player is going to stand.
    float radius = 2f;
    public Transform player;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //with this funktion we can see the distance between the player and the chest witch is transporm.position.
        float distance = Vector3.Distance(player.position, transform.position);
        if (distance < radius)
        {
            //with this funktion we ask if the button is pressed in the input menü Interact witch is E.
            if(Input.GetButtonDown("Interact"))
            {
                Debug.Log("hallo");
                //nachsuaen ob rotation auuf die kist schaut
                //dannach invantar machen

            }
        }
    }
}
