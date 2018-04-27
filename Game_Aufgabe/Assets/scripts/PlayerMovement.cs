using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float movementspeed = 200f;
    public float jumpforce = 30f;
    public float gravity = 4f;
    public float rotatespeed = 200f;
    private Vector3 nexpos;
    private Rigidbody playerbody;
    private float getcurx = 0;
    private float getcury = 0;

    // Use this for initialization
    void Start()
    {
        playerbody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        getcurx += Input.GetAxis("Mouse X");
        getcury += Input.GetAxis("Mouse Y");
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        
        Vector3 movedir = new Vector3(vertical, 0, horizontal) * movementspeed * Time.deltaTime;
        //if (Input.GetButtonDown("Jump")) ;
        //{
        //    movedir.y = jumpforce;
        //}
        
        playerbody.MovePosition(transform.position + movedir);
	}
}
