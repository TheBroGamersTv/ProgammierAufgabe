using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour {
    public PlayerContoller player;
    public Item item;
    // Use this for initialization
    void Start () {
        //we are trying to find the objekt witch has the playercontroller script in it and the Name Player but you also can find with the Tag "Player"
        player = GameObject.Find("Player").GetComponent<PlayerContoller>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
