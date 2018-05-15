using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotatewithplayerimage : MonoBehaviour {

    public Transform Player;
    RectTransform rectform;

    // Use this for initialization
    void Start () {
        //Player = GameObject.FindGameObjectWithTag("Player").transform;
        rectform = GetComponent<RectTransform>();
	}
	
	// Update is called once per frame
	void LateUpdate () {
       
      
        rectform.eulerAngles= new Vector3(0,0,(int)Player.eulerAngles.y);
	}
}
