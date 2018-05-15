using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minimap : MonoBehaviour {

    //it gets the transform(x,y,z) and quaterion(looking at) of the objekt you set it in the inspector.
    //if it is public you can put everything in the inspector, but you can also do it in the start method where you search after the Tag Player.
    public Transform player;
    
    //LateUpdate is called after all Update functions have been called.This is useful to order script execution.
    //For example a follow camera should always be implemented in LateUpdate because it tracks objects that might have moved inside Update.
    void LateUpdate()
    {
        //Vector3 Contains 3 positions (x,y,z) and it sets the vector to the player Transform Objekt
        Vector3 newPosition = player.position;
        newPosition.y = transform.position.y;
        //transform means the objekt which is attched to the script.
        //it sets the position the player on the y to which you drag it up , because if not then the minimapcamera wold be at 0,0,0 which is players position , but we want it 0,20,0
        transform.position = newPosition;
        //here it is set the rotation, if the player moves then it rotates with him. You also can write  player.eulerAngles.x but I found it smoother with the z angle.
        transform.rotation = Quaternion.Euler(90f, 0, 0);

       
    }
}
