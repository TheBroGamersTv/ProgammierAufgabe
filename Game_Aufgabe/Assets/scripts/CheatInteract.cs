using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;


public class CheatInteract : MonoBehaviour
{
    //this is the script for the chest interct , the radis is witch in with the player can intercat with the chest.
    //we get the transform player for the position where the player is going to stand.
   
    public Transform player;
    // Use this for initialization
    public LayerMask newlayermask;
    ///*public*/ Animator chest;
    public Camera camer;
    //private void Start()
    //{
    //    chest = gameObject.GetComponent<Animator>();
    //}

    void Awake()

    {
        //player = GameObject.FindGameObjectWithTag("PLayer").GetComponent<Transform>();
        camer = GameObject.FindGameObjectWithTag("camera").GetComponent<Camera>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
        //with this funktion we can see the distance between the player and the chest witch is transporm.position.
        float distance = Vector3.Distance(player.position, transform.position);
        
            //with this funktion we ask if the button is pressed in the input menü Interact witch is E.
            if (Input.GetButtonDown("Interact"))
            {
                RaycastHit hit;
                if(Physics.Raycast( camer.transform.position,camer.transform.forward,out hit,(int)distance,newlayermask))
                {
                    if(hit.collider.tag=="chest")
                    {

                    //chest.Play("chest open");

                    Debug.Log("fehler");
                    }
                }
            }
        
    }
}
