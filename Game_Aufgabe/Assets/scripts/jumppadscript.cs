using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumppadscript : MonoBehaviour {

    public PlayerContoller player;


    //Awake is used to initialize any variables or game state before the game starts.Awake is called only once during the lifetime of the script instance. 
    //Awake is called after all objects are initialized so you can safely speak to other objects or query them using for example GameObject.FindWithTag.
    private void Awake()
    {
        //we are trying to find the objekt witch has the playercontroller script in it and the Name Player but you also can find with the Tag "Player"
        player = GameObject.Find("Player").GetComponent<PlayerContoller>();
    }

    //OnTriggerEnter is a Method witch is created by Unity and when the Objekt has a Boxkolider and a rigedbody then is going to trigger 
    private void OnTriggerEnter(Collider other)
    {
        //here we are trying to find if the obajekt whos tag is Player so we can jump
        if (other.gameObject.tag == "Player")
        {
            player.Jumping = true;
            
            player.JUMP(65f);
            //for this Method look pls in the PlayerContoller script.
        }
    }
}
